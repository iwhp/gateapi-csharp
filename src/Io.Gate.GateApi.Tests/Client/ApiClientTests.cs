using System.Reflection;
using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class ApiClientTests
{
    private MethodInfo _buildQueryStringMethod = null!;
    private MethodInfo _resolvePathMethod = null!;

    [TestInitialize]
    public void Setup()
    {
        _buildQueryStringMethod = typeof(ApiClient).GetMethod(
            "BuildQueryString",
            BindingFlags.NonPublic | BindingFlags.Static)!;

        _resolvePathMethod = typeof(ApiClient).GetMethod(
            "ResolvePath",
            BindingFlags.NonPublic | BindingFlags.Static)!;

        Assert.IsNotNull(_buildQueryStringMethod, "BuildQueryString method not found via reflection.");
        Assert.IsNotNull(_resolvePathMethod, "ResolvePath method not found via reflection.");
    }

    private string InvokeBuildQueryString(Multimap<string, string>? queryParameters)
    {
        return (string)_buildQueryStringMethod.Invoke(null, new object?[] { queryParameters })!;
    }

    private string InvokeResolvePath(string path, RequestOptions? options)
    {
        return (string)_resolvePathMethod.Invoke(null, new object?[] { path, options })!;
    }

    #region BuildQueryString

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_NullParameters_ReturnsEmptyString()
    {
        var result = InvokeBuildQueryString(null);

        Assert.AreEqual(string.Empty, result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_EmptyParameters_ReturnsEmptyString()
    {
        var queryParams = new Multimap<string, string>();

        var result = InvokeBuildQueryString(queryParams);

        Assert.AreEqual(string.Empty, result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_SingleParameter_ReturnsEncodedKeyValue()
    {
        var queryParams = new Multimap<string, string>();
        queryParams.Add("currency_pair", "BTC_USDT");

        var result = InvokeBuildQueryString(queryParams);

        Assert.AreEqual("currency_pair=BTC_USDT", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_MultipleParameters_JoinedWithAmpersand()
    {
        var queryParams = new Multimap<string, string>();
        queryParams.Add("currency_pair", "BTC_USDT");
        queryParams.Add("limit", "100");

        var result = InvokeBuildQueryString(queryParams);

        Assert.IsTrue(result.Contains("currency_pair=BTC_USDT"));
        Assert.IsTrue(result.Contains("limit=100"));
        Assert.IsTrue(result.Contains("&"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_SpecialCharacters_AreUrlEncoded()
    {
        var queryParams = new Multimap<string, string>();
        queryParams.Add("query", "hello world");

        var result = InvokeBuildQueryString(queryParams);

        Assert.AreEqual("query=hello%20world", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void BuildQueryString_MultipleValuesForSameKey_ProducesMultipleEntries()
    {
        var queryParams = new Multimap<string, string>();
        queryParams.Add("status", "open");
        queryParams.Add("status", "closed");

        var result = InvokeBuildQueryString(queryParams);

        Assert.IsTrue(result.Contains("status=open"));
        Assert.IsTrue(result.Contains("status=closed"));
    }

    #endregion BuildQueryString

    #region ResolvePath

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_NullOptions_ReturnsPathUnchanged()
    {
        var result = InvokeResolvePath("/api/v4/spot/orders", null);

        Assert.AreEqual("/api/v4/spot/orders", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_NoPathParameters_ReturnsPathUnchanged()
    {
        var options = new RequestOptions();

        var result = InvokeResolvePath("/api/v4/spot/orders", options);

        Assert.AreEqual("/api/v4/spot/orders", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_WithPathParameter_ReplacesPlaceholder()
    {
        var options = new RequestOptions();
        options.PathParameters["order_id"] = "12345";

        var result = InvokeResolvePath("/api/v4/spot/orders/{order_id}", options);

        Assert.AreEqual("/api/v4/spot/orders/12345", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_WithMultiplePathParameters_ReplacesAllPlaceholders()
    {
        var options = new RequestOptions();
        options.PathParameters["currency_pair"] = "BTC_USDT";
        options.PathParameters["order_id"] = "67890";

        var result = InvokeResolvePath("/api/v4/spot/{currency_pair}/orders/{order_id}", options);

        Assert.AreEqual("/api/v4/spot/BTC_USDT/orders/67890", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_WithSpecialCharacters_UrlEncodesValue()
    {
        var options = new RequestOptions();
        options.PathParameters["name"] = "hello world";

        var result = InvokeResolvePath("/api/v4/items/{name}", options);

        Assert.AreEqual("/api/v4/items/hello%20world", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ResolvePath_NoMatchingPlaceholder_ReturnsPathUnchanged()
    {
        var options = new RequestOptions();
        options.PathParameters["nonexistent"] = "value";

        var result = InvokeResolvePath("/api/v4/spot/orders", options);

        Assert.AreEqual("/api/v4/spot/orders", result);
    }

    #endregion ResolvePath
}
