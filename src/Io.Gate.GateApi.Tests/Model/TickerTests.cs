using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class TickerTests
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
        var ticker = new Ticker(
            currencyPair: "BTC_USDT",
            last: "50000.00",
            lowestAsk: "50001.00",
            lowestSize: "0.1",
            highestBid: "49999.00",
            highestSize: "0.2",
            changePercentage: "2.5",
            changeUtc0: "2.3",
            changeUtc8: "2.1",
            baseVolume: "1234.56",
            quoteVolume: "61728000",
            high24h: "51000.00",
            low24h: "49000.00",
            etfNetValue: "100.5",
            etfPreNetValue: "99.8",
            etfPreTimestamp: 1710000000L,
            etfLeverage: "3.0"
        );

        Assert.AreEqual("BTC_USDT", ticker.CurrencyPair);
        Assert.AreEqual("50000.00", ticker.Last);
        Assert.AreEqual("50001.00", ticker.LowestAsk);
        Assert.AreEqual("0.1", ticker.LowestSize);
        Assert.AreEqual("49999.00", ticker.HighestBid);
        Assert.AreEqual("0.2", ticker.HighestSize);
        Assert.AreEqual("2.5", ticker.ChangePercentage);
        Assert.AreEqual("2.3", ticker.ChangeUtc0);
        Assert.AreEqual("2.1", ticker.ChangeUtc8);
        Assert.AreEqual("1234.56", ticker.BaseVolume);
        Assert.AreEqual("61728000", ticker.QuoteVolume);
        Assert.AreEqual("51000.00", ticker.High24h);
        Assert.AreEqual("49000.00", ticker.Low24h);
        Assert.AreEqual("100.5", ticker.EtfNetValue);
        Assert.AreEqual("99.8", ticker.EtfPreNetValue);
        Assert.AreEqual(1710000000L, ticker.EtfPreTimestamp);
        Assert.AreEqual("3.0", ticker.EtfLeverage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithDefaults_SetsNullValues()
    {
        var ticker = new Ticker();

        Assert.IsNull(ticker.CurrencyPair);
        Assert.IsNull(ticker.Last);
        Assert.IsNull(ticker.LowestAsk);
        Assert.IsNull(ticker.LowestSize);
        Assert.IsNull(ticker.HighestBid);
        Assert.IsNull(ticker.HighestSize);
        Assert.IsNull(ticker.ChangePercentage);
        Assert.IsNull(ticker.ChangeUtc0);
        Assert.IsNull(ticker.ChangeUtc8);
        Assert.IsNull(ticker.BaseVolume);
        Assert.IsNull(ticker.QuoteVolume);
        Assert.IsNull(ticker.High24h);
        Assert.IsNull(ticker.Low24h);
        Assert.IsNull(ticker.EtfNetValue);
        Assert.IsNull(ticker.EtfPreNetValue);
        Assert.IsNull(ticker.EtfPreTimestamp);
        Assert.IsNull(ticker.EtfLeverage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = TestDataFactory.GetTickerJsonSample();
        var ticker = JsonConvert.DeserializeObject<Ticker>(json, JsonSettings);

        Assert.IsNotNull(ticker);
        Assert.AreEqual("BTC_USDT", ticker.CurrencyPair);
        Assert.AreEqual("50000.00", ticker.Last);
        Assert.AreEqual("50001.00", ticker.LowestAsk);
        Assert.AreEqual("0.1", ticker.LowestSize);
        Assert.AreEqual("49999.00", ticker.HighestBid);
        Assert.AreEqual("0.2", ticker.HighestSize);
        Assert.AreEqual("2.5", ticker.ChangePercentage);
        Assert.AreEqual("2.3", ticker.ChangeUtc0);
        Assert.AreEqual("2.1", ticker.ChangeUtc8);
        Assert.AreEqual("1234.56", ticker.BaseVolume);
        Assert.AreEqual("61728000", ticker.QuoteVolume);
        Assert.AreEqual("51000.00", ticker.High24h);
        Assert.AreEqual("49000.00", ticker.Low24h);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var original = TestDataFactory.CreateSampleTicker();

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<Ticker>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.CurrencyPair, deserialized.CurrencyPair);
        Assert.AreEqual(original.Last, deserialized.Last);
        Assert.AreEqual(original.LowestAsk, deserialized.LowestAsk);
        Assert.AreEqual(original.HighestBid, deserialized.HighestBid);
        Assert.AreEqual(original.ChangePercentage, deserialized.ChangePercentage);
        Assert.AreEqual(original.BaseVolume, deserialized.BaseVolume);
        Assert.AreEqual(original.QuoteVolume, deserialized.QuoteVolume);
        Assert.AreEqual(original.High24h, deserialized.High24h);
        Assert.AreEqual(original.Low24h, deserialized.Low24h);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var ticker1 = TestDataFactory.CreateSampleTicker();
        var ticker2 = TestDataFactory.CreateSampleTicker();

        Assert.IsTrue(ticker1.Equals(ticker2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var ticker1 = new Ticker(currencyPair: "BTC_USDT", last: "50000.00");
        var ticker2 = new Ticker(currencyPair: "ETH_USDT", last: "3000.00");

        Assert.IsFalse(ticker1.Equals(ticker2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var ticker = TestDataFactory.CreateSampleTicker();

        Assert.IsFalse(ticker.Equals((Ticker?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var ticker1 = TestDataFactory.CreateSampleTicker();
        var ticker2 = TestDataFactory.CreateSampleTicker();

        Assert.AreEqual(ticker1.GetHashCode(), ticker2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var ticker = TestDataFactory.CreateSampleTicker();

        var json = ticker.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<Ticker>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var ticker = TestDataFactory.CreateSampleTicker();

        var result = ticker.ToString();

        Assert.IsTrue(result.Contains("class Ticker"));
    }
}
