using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class TradeTests
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
        var trade = new Trade(
            id: "12345",
            createTime: "1710000000",
            createTimeMs: "1710000000123",
            currencyPair: "BTC_USDT",
            side: Trade.SideEnum.Buy,
            role: Trade.RoleEnum.Taker,
            amount: "0.001",
            price: "50000",
            orderId: "99999",
            fee: "0.00000002",
            feeCurrency: "BTC",
            pointFee: "0",
            gtFee: "0",
            amendText: "amend-text",
            sequenceId: "seq-001",
            text: "t-my-trade"
        );

        Assert.AreEqual("12345", trade.Id);
        Assert.AreEqual("1710000000", trade.CreateTime);
        Assert.AreEqual("1710000000123", trade.CreateTimeMs);
        Assert.AreEqual("BTC_USDT", trade.CurrencyPair);
        Assert.AreEqual(Trade.SideEnum.Buy, trade.Side);
        Assert.AreEqual(Trade.RoleEnum.Taker, trade.Role);
        Assert.AreEqual("0.001", trade.Amount);
        Assert.AreEqual("50000", trade.Price);
        Assert.AreEqual("99999", trade.OrderId);
        Assert.AreEqual("0.00000002", trade.Fee);
        Assert.AreEqual("BTC", trade.FeeCurrency);
        Assert.AreEqual("0", trade.PointFee);
        Assert.AreEqual("0", trade.GtFee);
        Assert.AreEqual("amend-text", trade.AmendText);
        Assert.AreEqual("seq-001", trade.SequenceId);
        Assert.AreEqual("t-my-trade", trade.Text);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithDefaults_SetsNullValues()
    {
        var trade = new Trade();

        Assert.IsNull(trade.Id);
        Assert.IsNull(trade.CreateTime);
        Assert.IsNull(trade.CreateTimeMs);
        Assert.IsNull(trade.CurrencyPair);
        Assert.IsNull(trade.Side);
        Assert.IsNull(trade.Role);
        Assert.IsNull(trade.Amount);
        Assert.IsNull(trade.Price);
        Assert.IsNull(trade.OrderId);
        Assert.IsNull(trade.Fee);
        Assert.IsNull(trade.FeeCurrency);
        Assert.IsNull(trade.PointFee);
        Assert.IsNull(trade.GtFee);
        Assert.IsNull(trade.AmendText);
        Assert.IsNull(trade.SequenceId);
        Assert.IsNull(trade.Text);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = TestDataFactory.GetTradeJsonSample();
        var trade = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(trade);
        Assert.AreEqual("987654321", trade.Id);
        Assert.AreEqual("1710000000", trade.CreateTime);
        Assert.AreEqual("1710000000123", trade.CreateTimeMs);
        Assert.AreEqual("BTC_USDT", trade.CurrencyPair);
        Assert.AreEqual(Trade.SideEnum.Buy, trade.Side);
        Assert.AreEqual(Trade.RoleEnum.Taker, trade.Role);
        Assert.AreEqual("0.001", trade.Amount);
        Assert.AreEqual("50000", trade.Price);
        Assert.AreEqual("123456789", trade.OrderId);
        Assert.AreEqual("0.00000002", trade.Fee);
        Assert.AreEqual("BTC", trade.FeeCurrency);
        Assert.AreEqual("0", trade.PointFee);
        Assert.AreEqual("0", trade.GtFee);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var original = new Trade(
            id: "111",
            createTime: "1710000000",
            createTimeMs: "1710000000999",
            currencyPair: "ETH_USDT",
            side: Trade.SideEnum.Sell,
            role: Trade.RoleEnum.Maker,
            amount: "1.5",
            price: "3000",
            orderId: "222",
            fee: "0.001",
            feeCurrency: "ETH",
            pointFee: "0",
            gtFee: "0"
        );

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.Id, deserialized.Id);
        Assert.AreEqual(original.CurrencyPair, deserialized.CurrencyPair);
        Assert.AreEqual(original.Side, deserialized.Side);
        Assert.AreEqual(original.Role, deserialized.Role);
        Assert.AreEqual(original.Amount, deserialized.Amount);
        Assert.AreEqual(original.Price, deserialized.Price);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_SideBuy_DeserializesCorrectly()
    {
        var json = @"{ ""side"": ""buy"", ""currency_pair"": ""BTC_USDT"" }";
        var trade = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(trade);
        Assert.AreEqual(Trade.SideEnum.Buy, trade.Side);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_SideSell_DeserializesCorrectly()
    {
        var json = @"{ ""side"": ""sell"", ""currency_pair"": ""BTC_USDT"" }";
        var trade = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(trade);
        Assert.AreEqual(Trade.SideEnum.Sell, trade.Side);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_RoleTaker_DeserializesCorrectly()
    {
        var json = @"{ ""role"": ""taker"", ""currency_pair"": ""BTC_USDT"" }";
        var trade = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(trade);
        Assert.AreEqual(Trade.RoleEnum.Taker, trade.Role);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_RoleMaker_DeserializesCorrectly()
    {
        var json = @"{ ""role"": ""maker"", ""currency_pair"": ""BTC_USDT"" }";
        var trade = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);

        Assert.IsNotNull(trade);
        Assert.AreEqual(Trade.RoleEnum.Maker, trade.Role);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var trade1 = TestDataFactory.CreateSampleTrade();
        var trade2 = TestDataFactory.CreateSampleTrade();

        Assert.IsTrue(trade1.Equals(trade2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var trade1 = new Trade(id: "111", currencyPair: "BTC_USDT", amount: "0.001", price: "50000");
        var trade2 = new Trade(id: "222", currencyPair: "ETH_USDT", amount: "1.0", price: "3000");

        Assert.IsFalse(trade1.Equals(trade2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var trade = TestDataFactory.CreateSampleTrade();

        Assert.IsFalse(trade.Equals((Trade?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var trade1 = TestDataFactory.CreateSampleTrade();
        var trade2 = TestDataFactory.CreateSampleTrade();

        Assert.AreEqual(trade1.GetHashCode(), trade2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var trade = TestDataFactory.CreateSampleTrade();

        var json = trade.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<Trade>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var trade = TestDataFactory.CreateSampleTrade();

        var result = trade.ToString();

        Assert.IsTrue(result.Contains("class Trade"));
    }
}
