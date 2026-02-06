using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class SpotAccountTests
{
    private static readonly JsonSerializerSettings JsonSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy { OverrideSpecifiedNames = true }
        }
    };

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithAllParams_SetsProperties()
    {
        var account = new SpotAccount(
            currency: "BTC",
            available: "1.5",
            locked: "0.5",
            updateId: 12345L
        );

        Assert.AreEqual("BTC", account.Currency);
        Assert.AreEqual("1.5", account.Available);
        Assert.AreEqual("0.5", account.Locked);
        Assert.AreEqual(12345L, account.UpdateId);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithDefaults_SetsDefaultValues()
    {
        var account = new SpotAccount();

        Assert.IsNull(account.Currency);
        Assert.IsNull(account.Available);
        Assert.IsNull(account.Locked);
        Assert.AreEqual(0L, account.UpdateId);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = TestDataFactory.GetSpotAccountJsonSample();
        var account = JsonConvert.DeserializeObject<SpotAccount>(json, JsonSettings);

        Assert.IsNotNull(account);
        Assert.AreEqual("BTC", account.Currency);
        Assert.AreEqual("1.5", account.Available);
        Assert.AreEqual("0.5", account.Locked);
        Assert.AreEqual(123L, account.UpdateId);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var original = TestDataFactory.CreateSampleSpotAccount();

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<SpotAccount>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.Currency, deserialized.Currency);
        Assert.AreEqual(original.Available, deserialized.Available);
        Assert.AreEqual(original.Locked, deserialized.Locked);
        Assert.AreEqual(original.UpdateId, deserialized.UpdateId);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_WithSnakeCaseFields_MapsCorrectly()
    {
        var json = @"{
            ""currency"": ""ETH"",
            ""available"": ""10.0"",
            ""locked"": ""2.5"",
            ""update_id"": 999
        }";
        var account = JsonConvert.DeserializeObject<SpotAccount>(json, JsonSettings);

        Assert.IsNotNull(account);
        Assert.AreEqual("ETH", account.Currency);
        Assert.AreEqual("10.0", account.Available);
        Assert.AreEqual("2.5", account.Locked);
        Assert.AreEqual(999L, account.UpdateId);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var account1 = TestDataFactory.CreateSampleSpotAccount();
        var account2 = TestDataFactory.CreateSampleSpotAccount();

        Assert.IsTrue(account1.Equals(account2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var account1 = new SpotAccount(currency: "BTC", available: "1.5", locked: "0.5");
        var account2 = new SpotAccount(currency: "ETH", available: "10.0", locked: "2.0");

        Assert.IsFalse(account1.Equals(account2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var account = TestDataFactory.CreateSampleSpotAccount();

        Assert.IsFalse(account.Equals((SpotAccount?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var account1 = TestDataFactory.CreateSampleSpotAccount();
        var account2 = TestDataFactory.CreateSampleSpotAccount();

        Assert.AreEqual(account1.GetHashCode(), account2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var account = TestDataFactory.CreateSampleSpotAccount();

        var json = account.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<SpotAccount>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var account = TestDataFactory.CreateSampleSpotAccount();

        var result = account.ToString();

        Assert.IsTrue(result.Contains("class SpotAccount"));
    }
}
