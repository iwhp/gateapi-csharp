using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class AuthenticationTests
{
    private ApiClient _apiClient = null!;
    private MethodInfo _applyApiV4AuthMethod = null!;

    [TestInitialize]
    public void Setup()
    {
        _apiClient = new ApiClient("https://api.gateio.ws/api/v4");
        _applyApiV4AuthMethod = typeof(ApiClient).GetMethod(
            "ApplyApiV4Auth",
            BindingFlags.NonPublic | BindingFlags.Instance)!;

        Assert.IsNotNull(_applyApiV4AuthMethod, "ApplyApiV4Auth method not found via reflection.");
    }

    private void InvokeApplyApiV4Auth(
        RestRequest request,
        RequestOptions options,
        IReadableConfiguration configuration,
        string? serializedBody,
        string resolvedPath,
        string queryString)
    {
        _applyApiV4AuthMethod.Invoke(_apiClient, new object?[]
        {
            request, options, configuration, serializedBody, resolvedPath, queryString
        });
    }

    private static string? GetHeaderValue(RestRequest request, string headerName)
    {
        return request.Parameters
            .FirstOrDefault(p => p.Name == headerName && p.Type == ParameterType.HttpHeader)
            ?.Value?.ToString();
    }

    private static string ComputeSha512Hash(string input)
    {
        using var sha512 = SHA512.Create();
        var bytes = Encoding.UTF8.GetBytes(input);
        var hash = sha512.ComputeHash(bytes);
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }

    private static string ComputeHmacSha512(string secret, string data)
    {
        using var hmac = new HMACSHA512(Encoding.UTF8.GetBytes(secret));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }

    #region Auth Skipped

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_WhenRequireApiV4AuthIsFalse_NoHeadersAdded()
    {
        var request = new RestRequest("/api/v4/spot/tickers", Method.Get);
        var options = new RequestOptions { RequireApiV4Auth = false };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-key", "test-secret");

        InvokeApplyApiV4Auth(request, options, config, null, "/api/v4/spot/tickers", "");

        Assert.IsNull(GetHeaderValue(request, "KEY"));
        Assert.IsNull(GetHeaderValue(request, "Timestamp"));
        Assert.IsNull(GetHeaderValue(request, "SIGN"));
    }

    #endregion Auth Skipped

    #region KEY Header

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_SetsKeyHeader()
    {
        var request = new RestRequest("/api/v4/spot/orders", Method.Post);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("my-api-key-123", "my-api-secret-456");

        InvokeApplyApiV4Auth(request, options, config, "{}", "/api/v4/spot/orders", "");

        Assert.AreEqual("my-api-key-123", GetHeaderValue(request, "KEY"));
    }

    #endregion KEY Header

    #region Timestamp Header

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_SetsTimestampHeader()
    {
        var request = new RestRequest("/api/v4/spot/orders", Method.Post);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-key", "test-secret");

        InvokeApplyApiV4Auth(request, options, config, "{}", "/api/v4/spot/orders", "");

        var timestampStr = GetHeaderValue(request, "Timestamp");
        Assert.IsNotNull(timestampStr, "Timestamp header should be present.");
        Assert.IsTrue(long.TryParse(timestampStr, out var timestamp), "Timestamp should be parseable as long.");
        Assert.IsTrue(timestamp > 0, "Timestamp should be a positive number.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_TimestampIsCloseToCurrentTime()
    {
        var request = new RestRequest("/api/v4/spot/orders", Method.Post);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-key", "test-secret");

        var beforeTimestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        InvokeApplyApiV4Auth(request, options, config, "{}", "/api/v4/spot/orders", "");
        var afterTimestamp = DateTimeOffset.Now.ToUnixTimeSeconds();

        var timestampStr = GetHeaderValue(request, "Timestamp");
        var timestamp = long.Parse(timestampStr!);

        Assert.IsTrue(timestamp >= beforeTimestamp, "Timestamp should be >= time before call.");
        Assert.IsTrue(timestamp <= afterTimestamp, "Timestamp should be <= time after call.");
    }

    #endregion Timestamp Header

    #region SIGN Header

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_SetsSignHeader()
    {
        var request = new RestRequest("/api/v4/spot/orders", Method.Post);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-key", "test-secret");

        InvokeApplyApiV4Auth(request, options, config, "{}", "/api/v4/spot/orders", "");

        var sign = GetHeaderValue(request, "SIGN");
        Assert.IsNotNull(sign, "SIGN header should be present.");
        Assert.IsTrue(sign.Length > 0, "SIGN header should not be empty.");
    }

    #endregion SIGN Header

    #region Known Vector Verification

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_KnownVector_ProducesCorrectSignature()
    {
        var request = new RestRequest("/api/v4/spot/orders", Method.Post);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("known-key", "known-secret");

        var body = @"{""currency_pair"":""BTC_USDT"",""side"":""buy"",""amount"":""0.001"",""price"":""50000""}";
        var resolvedPath = "/api/v4/spot/orders";
        var queryString = "";

        InvokeApplyApiV4Auth(request, options, config, body, resolvedPath, queryString);

        // Extract the timestamp that was actually used
        var timestampStr = GetHeaderValue(request, "Timestamp")!;
        var sign = GetHeaderValue(request, "SIGN")!;

        // Recompute the expected signature using the same timestamp
        var bodyHash = ComputeSha512Hash(body);
        var signatureString = $"POST\n{resolvedPath}\n{queryString}\n{bodyHash}\n{timestampStr}";
        var expectedSign = ComputeHmacSha512("known-secret", signatureString);

        Assert.AreEqual(expectedSign, sign, "SIGN header should match recomputed HMAC-SHA512 signature.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_GetRequest_ProducesCorrectSignature()
    {
        var request = new RestRequest("/api/v4/spot/tickers", Method.Get);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("get-key", "get-secret");

        var resolvedPath = "/api/v4/spot/tickers";
        var queryString = "currency_pair=BTC_USDT";

        InvokeApplyApiV4Auth(request, options, config, null, resolvedPath, queryString);

        var timestampStr = GetHeaderValue(request, "Timestamp")!;
        var sign = GetHeaderValue(request, "SIGN")!;

        // Null body should be treated as empty string for hashing
        var bodyHash = ComputeSha512Hash("");
        var signatureString = $"GET\n{resolvedPath}\n{queryString}\n{bodyHash}\n{timestampStr}";
        var expectedSign = ComputeHmacSha512("get-secret", signatureString);

        Assert.AreEqual(expectedSign, sign, "SIGN should match for GET request with null body.");
    }

    #endregion Known Vector Verification

    #region Empty Body Hash

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_NullBody_UsesEmptyStringHash()
    {
        var request = new RestRequest("/api/v4/spot/accounts", Method.Get);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-key", "test-secret");

        InvokeApplyApiV4Auth(request, options, config, null, "/api/v4/spot/accounts", "");

        var timestampStr = GetHeaderValue(request, "Timestamp")!;
        var sign = GetHeaderValue(request, "SIGN")!;

        // Verify the hash of empty string is used
        var emptyBodyHash = ComputeSha512Hash("");
        var signatureString = $"GET\n/api/v4/spot/accounts\n\n{emptyBodyHash}\n{timestampStr}";
        var expectedSign = ComputeHmacSha512("test-secret", signatureString);

        Assert.AreEqual(expectedSign, sign, "Null body should produce same signature as empty string body.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EmptyStringHash_IsSha512OfEmptyString()
    {
        // Verify our test helper produces the well-known SHA-512 hash of empty string
        var hash = ComputeSha512Hash("");

        Assert.AreEqual(
            "cf83e1357eefb8bdf1542850d66d8007d620e4050b5715dc83f4a921d36ce9ce47d0d13c5d85f2b0ff8318d2877eec2f63b931bd47417a81a538327af927da3e",
            hash,
            "SHA-512 of empty string should match the known constant.");
    }

    #endregion Empty Body Hash

    #region Delete Method Signature

    [TestMethod]
    [TestCategory("Unit")]
    public void ApplyApiV4Auth_DeleteRequest_UsesCorrectMethod()
    {
        var request = new RestRequest("/api/v4/spot/orders/12345", Method.Delete);
        var options = new RequestOptions { RequireApiV4Auth = true };
        var config = new Configuration();
        config.SetGateApiV4KeyPair("del-key", "del-secret");

        InvokeApplyApiV4Auth(request, options, config, null, "/api/v4/spot/orders/12345", "");

        var timestampStr = GetHeaderValue(request, "Timestamp")!;
        var sign = GetHeaderValue(request, "SIGN")!;

        var bodyHash = ComputeSha512Hash("");
        var signatureString = $"DELETE\n/api/v4/spot/orders/12345\n\n{bodyHash}\n{timestampStr}";
        var expectedSign = ComputeHmacSha512("del-secret", signatureString);

        Assert.AreEqual(expectedSign, sign, "DELETE request should use DELETE in signature string.");
    }

    #endregion Delete Method Signature
}
