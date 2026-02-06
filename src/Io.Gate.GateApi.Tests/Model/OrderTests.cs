using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class OrderTests
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
    public void Constructor_WithRequiredParams_SetsProperties()
    {
        var order = new Order(
            text: "t-test",
            currencyPair: "BTC_USDT",
            side: Order.SideEnum.Buy,
            amount: "0.001",
            price: "50000"
        );

        Assert.AreEqual("t-test", order.Text);
        Assert.AreEqual("BTC_USDT", order.CurrencyPair);
        Assert.AreEqual(Order.SideEnum.Buy, order.Side);
        Assert.AreEqual("0.001", order.Amount);
        Assert.AreEqual("50000", order.Price);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Constructor_WithoutCurrencyPair_ThrowsArgumentNullException()
    {
        _ = new Order(
            currencyPair: null!,
            side: Order.SideEnum.Buy,
            amount: "0.001"
        );
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Constructor_WithoutAmount_ThrowsArgumentNullException()
    {
        _ = new Order(
            currencyPair: "BTC_USDT",
            side: Order.SideEnum.Buy,
            amount: null!
        );
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_DefaultType_IsLimit()
    {
        var order = new Order(
            currencyPair: "BTC_USDT",
            side: Order.SideEnum.Buy,
            amount: "0.001"
        );

        Assert.AreEqual(Order.TypeEnum.Limit, order.Type);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_DefaultTimeInForce_IsGtc()
    {
        var order = new Order(
            currencyPair: "BTC_USDT",
            side: Order.SideEnum.Buy,
            amount: "0.001"
        );

        Assert.AreEqual(Order.TimeInForceEnum.Gtc, order.TimeInForce);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_DefaultAccount_IsSpot()
    {
        var order = new Order(
            currencyPair: "BTC_USDT",
            side: Order.SideEnum.Buy,
            amount: "0.001"
        );

        Assert.AreEqual("spot", order.Account);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = TestDataFactory.GetOrderJsonSample();
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual("123456789", order.Id);
        Assert.AreEqual("t-my-order", order.Text);
        Assert.AreEqual("1710000000", order.CreateTime);
        Assert.AreEqual("1710000001", order.UpdateTime);
        Assert.AreEqual(1710000000123L, order.CreateTimeMs);
        Assert.AreEqual(1710000001456L, order.UpdateTimeMs);
        Assert.AreEqual(Order.StatusEnum.Open, order.Status);
        Assert.AreEqual("BTC_USDT", order.CurrencyPair);
        Assert.AreEqual(Order.TypeEnum.Limit, order.Type);
        Assert.AreEqual("spot", order.Account);
        Assert.AreEqual(Order.SideEnum.Buy, order.Side);
        Assert.AreEqual("0.001", order.Amount);
        Assert.AreEqual("50000", order.Price);
        Assert.AreEqual(Order.TimeInForceEnum.Gtc, order.TimeInForce);
        Assert.AreEqual("0.001", order.Left);
        Assert.AreEqual("0", order.FilledAmount);
        Assert.AreEqual("0", order.FillPrice);
        Assert.AreEqual("0", order.FilledTotal);
        Assert.AreEqual("0", order.AvgDealPrice);
        Assert.AreEqual("0", order.Fee);
        Assert.AreEqual("BTC", order.FeeCurrency);
        Assert.AreEqual("0", order.PointFee);
        Assert.AreEqual("0", order.GtFee);
        Assert.AreEqual(false, order.GtDiscount);
        Assert.AreEqual("0", order.RebatedFee);
        Assert.AreEqual("USDT", order.RebatedFeeCurrency);
        Assert.AreEqual(0, order.StpId);
        Assert.AreEqual(Order.StpActEnum.Minus, order.StpAct);
        Assert.AreEqual(Order.FinishAsEnum.Open, order.FinishAs);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_StatusOpen_DeserializesCorrectly()
    {
        var json = @"{ ""status"": ""open"", ""currency_pair"": ""BTC_USDT"", ""amount"": ""1"", ""side"": ""buy"" }";
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual(Order.StatusEnum.Open, order.Status);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_StatusClosed_DeserializesCorrectly()
    {
        var json = @"{ ""status"": ""closed"", ""currency_pair"": ""BTC_USDT"", ""amount"": ""1"", ""side"": ""buy"" }";
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual(Order.StatusEnum.Closed, order.Status);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_StatusCancelled_DeserializesCorrectly()
    {
        var json = @"{ ""status"": ""cancelled"", ""currency_pair"": ""BTC_USDT"", ""amount"": ""1"", ""side"": ""buy"" }";
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual(Order.StatusEnum.Cancelled, order.Status);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_SideBuy_DeserializesCorrectly()
    {
        var json = @"{ ""side"": ""buy"", ""currency_pair"": ""BTC_USDT"", ""amount"": ""1"" }";
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual(Order.SideEnum.Buy, order.Side);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_SideSell_DeserializesCorrectly()
    {
        var json = @"{ ""side"": ""sell"", ""currency_pair"": ""BTC_USDT"", ""amount"": ""1"" }";
        var order = JsonConvert.DeserializeObject<Order>(json, JsonSettings);

        Assert.IsNotNull(order);
        Assert.AreEqual(Order.SideEnum.Sell, order.Side);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var order1 = TestDataFactory.CreateSampleOrder();
        var order2 = TestDataFactory.CreateSampleOrder();

        Assert.IsTrue(order1.Equals(order2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var order1 = new Order(currencyPair: "BTC_USDT", side: Order.SideEnum.Buy, amount: "0.001", price: "50000");
        var order2 = new Order(currencyPair: "ETH_USDT", side: Order.SideEnum.Sell, amount: "1.0", price: "3000");

        Assert.IsFalse(order1.Equals(order2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var order = TestDataFactory.CreateSampleOrder();

        Assert.IsFalse(order.Equals((Order?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var order1 = TestDataFactory.CreateSampleOrder();
        var order2 = TestDataFactory.CreateSampleOrder();

        Assert.AreEqual(order1.GetHashCode(), order2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var order = TestDataFactory.CreateSampleOrder();

        var json = order.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        // Verify it can be parsed as JSON
        var parsed = JsonConvert.DeserializeObject<Order>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var order = TestDataFactory.CreateSampleOrder();

        var result = order.ToString();

        Assert.IsTrue(result.Contains("class Order"));
    }
}
