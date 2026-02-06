using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class CurrencyPairTests
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
        var pair = new CurrencyPair(
            id: "BTC_USDT",
            _base: "BTC",
            baseName: "Bitcoin",
            quote: "USDT",
            quoteName: "Tether",
            fee: "0.2",
            minBaseAmount: "0.0001",
            minQuoteAmount: "1",
            maxBaseAmount: "10000",
            maxQuoteAmount: "1000000",
            amountPrecision: 4,
            precision: 2,
            tradeStatus: CurrencyPair.TradeStatusEnum.Tradable,
            sellStart: 1710000000L,
            buyStart: 1710000000L,
            delistingTime: 0L,
            type: "normal",
            tradeUrl: "https://gate.io/trade/BTC_USDT",
            stTag: false
        );

        Assert.AreEqual("BTC_USDT", pair.Id);
        Assert.AreEqual("BTC", pair.Base);
        Assert.AreEqual("Bitcoin", pair.BaseName);
        Assert.AreEqual("USDT", pair.Quote);
        Assert.AreEqual("Tether", pair.QuoteName);
        Assert.AreEqual("0.2", pair.Fee);
        Assert.AreEqual("0.0001", pair.MinBaseAmount);
        Assert.AreEqual("1", pair.MinQuoteAmount);
        Assert.AreEqual("10000", pair.MaxBaseAmount);
        Assert.AreEqual("1000000", pair.MaxQuoteAmount);
        Assert.AreEqual(4, pair.AmountPrecision);
        Assert.AreEqual(2, pair.Precision);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Tradable, pair.TradeStatus);
        Assert.AreEqual(1710000000L, pair.SellStart);
        Assert.AreEqual(1710000000L, pair.BuyStart);
        Assert.AreEqual(0L, pair.DelistingTime);
        Assert.AreEqual("normal", pair.Type);
        Assert.AreEqual("https://gate.io/trade/BTC_USDT", pair.TradeUrl);
        Assert.AreEqual(false, pair.StTag);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithDefaults_SetsDefaultValues()
    {
        var pair = new CurrencyPair();

        Assert.IsNull(pair.Id);
        Assert.IsNull(pair.Base);
        Assert.IsNull(pair.BaseName);
        Assert.IsNull(pair.Quote);
        Assert.IsNull(pair.QuoteName);
        Assert.IsNull(pair.Fee);
        Assert.IsNull(pair.MinBaseAmount);
        Assert.IsNull(pair.MinQuoteAmount);
        Assert.IsNull(pair.MaxBaseAmount);
        Assert.IsNull(pair.MaxQuoteAmount);
        Assert.AreEqual(0, pair.AmountPrecision);
        Assert.AreEqual(0, pair.Precision);
        Assert.IsNull(pair.TradeStatus);
        Assert.AreEqual(0L, pair.SellStart);
        Assert.AreEqual(0L, pair.BuyStart);
        Assert.AreEqual(0L, pair.DelistingTime);
        Assert.IsNull(pair.Type);
        Assert.IsNull(pair.TradeUrl);
        Assert.AreEqual(false, pair.StTag);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = TestDataFactory.GetCurrencyPairJsonSample();
        var pair = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(pair);
        Assert.AreEqual("BTC_USDT", pair.Id);
        Assert.AreEqual("BTC", pair.Base);
        Assert.AreEqual("USDT", pair.Quote);
        Assert.AreEqual("0.2", pair.Fee);
        Assert.AreEqual("0.0001", pair.MinBaseAmount);
        Assert.AreEqual("1", pair.MinQuoteAmount);
        Assert.AreEqual(4, pair.AmountPrecision);
        Assert.AreEqual(2, pair.Precision);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Tradable, pair.TradeStatus);
        Assert.AreEqual(0L, pair.SellStart);
        Assert.AreEqual(0L, pair.BuyStart);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var original = TestDataFactory.CreateSampleCurrencyPair();

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.Id, deserialized.Id);
        Assert.AreEqual(original.Base, deserialized.Base);
        Assert.AreEqual(original.Quote, deserialized.Quote);
        Assert.AreEqual(original.Fee, deserialized.Fee);
        Assert.AreEqual(original.MinBaseAmount, deserialized.MinBaseAmount);
        Assert.AreEqual(original.MinQuoteAmount, deserialized.MinQuoteAmount);
        Assert.AreEqual(original.AmountPrecision, deserialized.AmountPrecision);
        Assert.AreEqual(original.Precision, deserialized.Precision);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TradeStatusTradable_DeserializesCorrectly()
    {
        var json = @"{ ""trade_status"": ""tradable"" }";
        var pair = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(pair);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Tradable, pair.TradeStatus);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TradeStatusUntradable_DeserializesCorrectly()
    {
        var json = @"{ ""trade_status"": ""untradable"" }";
        var pair = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(pair);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Untradable, pair.TradeStatus);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TradeStatusBuyable_DeserializesCorrectly()
    {
        var json = @"{ ""trade_status"": ""buyable"" }";
        var pair = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(pair);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Buyable, pair.TradeStatus);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TradeStatusSellable_DeserializesCorrectly()
    {
        var json = @"{ ""trade_status"": ""sellable"" }";
        var pair = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);

        Assert.IsNotNull(pair);
        Assert.AreEqual(CurrencyPair.TradeStatusEnum.Sellable, pair.TradeStatus);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var pair1 = TestDataFactory.CreateSampleCurrencyPair();
        var pair2 = TestDataFactory.CreateSampleCurrencyPair();

        Assert.IsTrue(pair1.Equals(pair2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var pair1 = new CurrencyPair(id: "BTC_USDT", _base: "BTC", quote: "USDT");
        var pair2 = new CurrencyPair(id: "ETH_USDT", _base: "ETH", quote: "USDT");

        Assert.IsFalse(pair1.Equals(pair2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var pair = TestDataFactory.CreateSampleCurrencyPair();

        Assert.IsFalse(pair.Equals((CurrencyPair?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var pair1 = TestDataFactory.CreateSampleCurrencyPair();
        var pair2 = TestDataFactory.CreateSampleCurrencyPair();

        Assert.AreEqual(pair1.GetHashCode(), pair2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var pair = TestDataFactory.CreateSampleCurrencyPair();

        var json = pair.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<CurrencyPair>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var pair = TestDataFactory.CreateSampleCurrencyPair();

        var result = pair.ToString();

        Assert.IsTrue(result.Contains("class CurrencyPair"));
    }
}
