using Io.Gate.GateApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class ContractTests
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
    public void Constructor_WithKeyParams_SetsProperties()
    {
        var contract = new Contract(
            name: "BTC_USDT",
            type: Contract.TypeEnum.Direct,
            quantoMultiplier: "0.0001",
            leverageMin: "1",
            leverageMax: "100",
            maintenanceRate: "0.005",
            markType: Contract.MarkTypeEnum.Index,
            markPrice: "50000.00",
            indexPrice: "49999.50",
            lastPrice: "50001.00",
            makerFeeRate: "-0.00025",
            takerFeeRate: "0.00075",
            orderPriceRound: "0.1",
            markPriceRound: "0.01",
            fundingRate: "0.0001",
            fundingInterval: 28800,
            fundingNextApply: 1710028800.0,
            orderSizeMin: 1L,
            orderSizeMax: 1000000L,
            ordersLimit: 50
        );

        Assert.AreEqual("BTC_USDT", contract.Name);
        Assert.AreEqual(Contract.TypeEnum.Direct, contract.Type);
        Assert.AreEqual("0.0001", contract.QuantoMultiplier);
        Assert.AreEqual("1", contract.LeverageMin);
        Assert.AreEqual("100", contract.LeverageMax);
        Assert.AreEqual("0.005", contract.MaintenanceRate);
        Assert.AreEqual(Contract.MarkTypeEnum.Index, contract.MarkType);
        Assert.AreEqual("50000.00", contract.MarkPrice);
        Assert.AreEqual("49999.50", contract.IndexPrice);
        Assert.AreEqual("50001.00", contract.LastPrice);
        Assert.AreEqual("-0.00025", contract.MakerFeeRate);
        Assert.AreEqual("0.00075", contract.TakerFeeRate);
        Assert.AreEqual("0.1", contract.OrderPriceRound);
        Assert.AreEqual("0.01", contract.MarkPriceRound);
        Assert.AreEqual("0.0001", contract.FundingRate);
        Assert.AreEqual(28800, contract.FundingInterval);
        Assert.AreEqual(1710028800.0, contract.FundingNextApply);
        Assert.AreEqual(1L, contract.OrderSizeMin);
        Assert.AreEqual(1000000L, contract.OrderSizeMax);
        Assert.AreEqual(50, contract.OrdersLimit);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithDefaults_SetsDefaultValues()
    {
        var contract = new Contract();

        Assert.IsNull(contract.Name);
        Assert.IsNull(contract.Type);
        Assert.IsNull(contract.QuantoMultiplier);
        Assert.IsNull(contract.LeverageMin);
        Assert.IsNull(contract.LeverageMax);
        Assert.IsNull(contract.MaintenanceRate);
        Assert.IsNull(contract.MarkType);
        Assert.IsNull(contract.MarkPrice);
        Assert.IsNull(contract.IndexPrice);
        Assert.IsNull(contract.LastPrice);
        Assert.IsNull(contract.MakerFeeRate);
        Assert.IsNull(contract.TakerFeeRate);
        Assert.IsNull(contract.OrderPriceRound);
        Assert.IsNull(contract.MarkPriceRound);
        Assert.IsNull(contract.FundingRate);
        Assert.AreEqual(0, contract.FundingInterval);
        Assert.AreEqual(0.0, contract.FundingNextApply);
        Assert.IsNull(contract.RiskLimitBase);
        Assert.IsNull(contract.RiskLimitStep);
        Assert.IsNull(contract.RiskLimitMax);
        Assert.AreEqual(0L, contract.OrderSizeMin);
        Assert.AreEqual(0L, contract.OrderSizeMax);
        Assert.IsNull(contract.OrderPriceDeviate);
        Assert.IsNull(contract.RefDiscountRate);
        Assert.IsNull(contract.RefRebateRate);
        Assert.AreEqual(0L, contract.OrderbookId);
        Assert.AreEqual(0L, contract.TradeId);
        Assert.AreEqual(0L, contract.TradeSize);
        Assert.AreEqual(0L, contract.PositionSize);
        Assert.AreEqual(0.0, contract.ConfigChangeTime);
        Assert.AreEqual(false, contract.InDelisting);
        Assert.AreEqual(0, contract.OrdersLimit);
        Assert.AreEqual(false, contract.EnableBonus);
        Assert.AreEqual(false, contract.EnableCredit);
        Assert.AreEqual(0.0, contract.CreateTime);
        Assert.IsNull(contract.FundingCapRatio);
        Assert.IsNull(contract.Status);
        Assert.AreEqual(0L, contract.LaunchTime);
        Assert.AreEqual(0L, contract.DelistingTime);
        Assert.AreEqual(0L, contract.DelistedTime);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithAllParams_SetsAllProperties()
    {
        var contract = new Contract(
            name: "BTC_USDT",
            type: Contract.TypeEnum.Direct,
            quantoMultiplier: "0.0001",
            leverageMin: "1",
            leverageMax: "100",
            maintenanceRate: "0.005",
            markType: Contract.MarkTypeEnum.Index,
            markPrice: "50000.00",
            indexPrice: "49999.50",
            lastPrice: "50001.00",
            makerFeeRate: "-0.00025",
            takerFeeRate: "0.00075",
            orderPriceRound: "0.1",
            markPriceRound: "0.01",
            fundingRate: "0.0001",
            fundingInterval: 28800,
            fundingNextApply: 1710028800.0,
            riskLimitBase: "100",
            riskLimitStep: "50",
            riskLimitMax: "5000",
            orderSizeMin: 1L,
            orderSizeMax: 1000000L,
            orderPriceDeviate: "0.5",
            refDiscountRate: "0.1",
            refRebateRate: "0.05",
            orderbookId: 999L,
            tradeId: 888L,
            tradeSize: 777L,
            positionSize: 666L,
            configChangeTime: 1710000000.0,
            inDelisting: false,
            ordersLimit: 50,
            enableBonus: true,
            enableCredit: true,
            createTime: 1700000000.0,
            fundingCapRatio: "0.75",
            status: "trading",
            launchTime: 1690000000L,
            delistingTime: 0L,
            delistedTime: 0L
        );

        Assert.AreEqual("BTC_USDT", contract.Name);
        Assert.AreEqual("100", contract.RiskLimitBase);
        Assert.AreEqual("50", contract.RiskLimitStep);
        Assert.AreEqual("5000", contract.RiskLimitMax);
        Assert.AreEqual("0.5", contract.OrderPriceDeviate);
        Assert.AreEqual("0.1", contract.RefDiscountRate);
        Assert.AreEqual("0.05", contract.RefRebateRate);
        Assert.AreEqual(999L, contract.OrderbookId);
        Assert.AreEqual(888L, contract.TradeId);
        Assert.AreEqual(777L, contract.TradeSize);
        Assert.AreEqual(666L, contract.PositionSize);
        Assert.AreEqual(1710000000.0, contract.ConfigChangeTime);
        Assert.AreEqual(false, contract.InDelisting);
        Assert.AreEqual(true, contract.EnableBonus);
        Assert.AreEqual(true, contract.EnableCredit);
        Assert.AreEqual(1700000000.0, contract.CreateTime);
        Assert.AreEqual("0.75", contract.FundingCapRatio);
        Assert.AreEqual("trading", contract.Status);
        Assert.AreEqual(1690000000L, contract.LaunchTime);
        Assert.AreEqual(0L, contract.DelistingTime);
        Assert.AreEqual(0L, contract.DelistedTime);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = @"{
            ""name"": ""BTC_USDT"",
            ""type"": ""direct"",
            ""quanto_multiplier"": ""0.0001"",
            ""leverage_min"": ""1"",
            ""leverage_max"": ""100"",
            ""maintenance_rate"": ""0.005"",
            ""mark_type"": ""index"",
            ""mark_price"": ""50000.00"",
            ""index_price"": ""49999.50"",
            ""last_price"": ""50001.00"",
            ""maker_fee_rate"": ""-0.00025"",
            ""taker_fee_rate"": ""0.00075"",
            ""order_price_round"": ""0.1"",
            ""mark_price_round"": ""0.01"",
            ""funding_rate"": ""0.0001"",
            ""funding_interval"": 28800,
            ""funding_next_apply"": 1710028800.0,
            ""risk_limit_base"": ""100"",
            ""risk_limit_step"": ""50"",
            ""risk_limit_max"": ""5000"",
            ""order_size_min"": 1,
            ""order_size_max"": 1000000,
            ""order_price_deviate"": ""0.5"",
            ""ref_discount_rate"": ""0.1"",
            ""ref_rebate_rate"": ""0.05"",
            ""orderbook_id"": 999,
            ""trade_id"": 888,
            ""trade_size"": 777,
            ""position_size"": 666,
            ""config_change_time"": 1710000000.0,
            ""in_delisting"": false,
            ""orders_limit"": 50,
            ""enable_bonus"": true,
            ""enable_credit"": false,
            ""create_time"": 1700000000.0,
            ""funding_cap_ratio"": ""0.75"",
            ""status"": ""trading"",
            ""launch_time"": 1690000000,
            ""delisting_time"": 0,
            ""delisted_time"": 0
        }";
        var contract = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(contract);
        Assert.AreEqual("BTC_USDT", contract.Name);
        Assert.AreEqual(Contract.TypeEnum.Direct, contract.Type);
        Assert.AreEqual("0.0001", contract.QuantoMultiplier);
        Assert.AreEqual("1", contract.LeverageMin);
        Assert.AreEqual("100", contract.LeverageMax);
        Assert.AreEqual("0.005", contract.MaintenanceRate);
        Assert.AreEqual(Contract.MarkTypeEnum.Index, contract.MarkType);
        Assert.AreEqual("50000.00", contract.MarkPrice);
        Assert.AreEqual("49999.50", contract.IndexPrice);
        Assert.AreEqual("50001.00", contract.LastPrice);
        Assert.AreEqual("-0.00025", contract.MakerFeeRate);
        Assert.AreEqual("0.00075", contract.TakerFeeRate);
        Assert.AreEqual("0.1", contract.OrderPriceRound);
        Assert.AreEqual("0.01", contract.MarkPriceRound);
        Assert.AreEqual("0.0001", contract.FundingRate);
        Assert.AreEqual(28800, contract.FundingInterval);
        Assert.AreEqual(1710028800.0, contract.FundingNextApply);
        Assert.AreEqual("100", contract.RiskLimitBase);
        Assert.AreEqual("50", contract.RiskLimitStep);
        Assert.AreEqual("5000", contract.RiskLimitMax);
        Assert.AreEqual(1L, contract.OrderSizeMin);
        Assert.AreEqual(1000000L, contract.OrderSizeMax);
        Assert.AreEqual("0.5", contract.OrderPriceDeviate);
        Assert.AreEqual("0.1", contract.RefDiscountRate);
        Assert.AreEqual("0.05", contract.RefRebateRate);
        Assert.AreEqual(999L, contract.OrderbookId);
        Assert.AreEqual(888L, contract.TradeId);
        Assert.AreEqual(777L, contract.TradeSize);
        Assert.AreEqual(666L, contract.PositionSize);
        Assert.AreEqual(1710000000.0, contract.ConfigChangeTime);
        Assert.AreEqual(false, contract.InDelisting);
        Assert.AreEqual(50, contract.OrdersLimit);
        Assert.AreEqual(true, contract.EnableBonus);
        Assert.AreEqual(false, contract.EnableCredit);
        Assert.AreEqual(1700000000.0, contract.CreateTime);
        Assert.AreEqual("0.75", contract.FundingCapRatio);
        Assert.AreEqual("trading", contract.Status);
        Assert.AreEqual(1690000000L, contract.LaunchTime);
        Assert.AreEqual(0L, contract.DelistingTime);
        Assert.AreEqual(0L, contract.DelistedTime);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var original = new Contract(
            name: "ETH_USDT",
            type: Contract.TypeEnum.Inverse,
            quantoMultiplier: "1",
            leverageMin: "1",
            leverageMax: "50",
            maintenanceRate: "0.01",
            markType: Contract.MarkTypeEnum.Internal,
            markPrice: "3000.00",
            indexPrice: "2999.50",
            lastPrice: "3001.00",
            makerFeeRate: "-0.0002",
            takerFeeRate: "0.0005",
            orderPriceRound: "0.05",
            markPriceRound: "0.01",
            fundingRate: "0.00015",
            fundingInterval: 28800,
            fundingNextApply: 1710028800.0,
            orderSizeMin: 1L,
            orderSizeMax: 500000L,
            ordersLimit: 100,
            status: "trading"
        );

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.Name, deserialized.Name);
        Assert.AreEqual(original.Type, deserialized.Type);
        Assert.AreEqual(original.QuantoMultiplier, deserialized.QuantoMultiplier);
        Assert.AreEqual(original.LeverageMin, deserialized.LeverageMin);
        Assert.AreEqual(original.LeverageMax, deserialized.LeverageMax);
        Assert.AreEqual(original.MarkType, deserialized.MarkType);
        Assert.AreEqual(original.MarkPrice, deserialized.MarkPrice);
        Assert.AreEqual(original.LastPrice, deserialized.LastPrice);
        Assert.AreEqual(original.FundingInterval, deserialized.FundingInterval);
        Assert.AreEqual(original.OrderSizeMin, deserialized.OrderSizeMin);
        Assert.AreEqual(original.OrderSizeMax, deserialized.OrderSizeMax);
        Assert.AreEqual(original.Status, deserialized.Status);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TypeDirect_DeserializesCorrectly()
    {
        var json = @"{ ""type"": ""direct"", ""name"": ""BTC_USDT"" }";
        var contract = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(contract);
        Assert.AreEqual(Contract.TypeEnum.Direct, contract.Type);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_TypeInverse_DeserializesCorrectly()
    {
        var json = @"{ ""type"": ""inverse"", ""name"": ""BTC_USD"" }";
        var contract = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(contract);
        Assert.AreEqual(Contract.TypeEnum.Inverse, contract.Type);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_MarkTypeIndex_DeserializesCorrectly()
    {
        var json = @"{ ""mark_type"": ""index"", ""name"": ""BTC_USDT"" }";
        var contract = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(contract);
        Assert.AreEqual(Contract.MarkTypeEnum.Index, contract.MarkType);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void EnumDeserialization_MarkTypeInternal_DeserializesCorrectly()
    {
        var json = @"{ ""mark_type"": ""internal"", ""name"": ""BTC_USDT"" }";
        var contract = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);

        Assert.IsNotNull(contract);
        Assert.AreEqual(Contract.MarkTypeEnum.Internal, contract.MarkType);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var contract1 = new Contract(name: "BTC_USDT", type: Contract.TypeEnum.Direct, leverageMax: "100", status: "trading");
        var contract2 = new Contract(name: "BTC_USDT", type: Contract.TypeEnum.Direct, leverageMax: "100", status: "trading");

        Assert.IsTrue(contract1.Equals(contract2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var contract1 = new Contract(name: "BTC_USDT", type: Contract.TypeEnum.Direct, status: "trading");
        var contract2 = new Contract(name: "ETH_USDT", type: Contract.TypeEnum.Inverse, status: "delisting");

        Assert.IsFalse(contract1.Equals(contract2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var contract = new Contract(name: "BTC_USDT");

        Assert.IsFalse(contract.Equals((Contract?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameValues_ReturnsSameHash()
    {
        var contract1 = new Contract(name: "BTC_USDT", type: Contract.TypeEnum.Direct, leverageMax: "100");
        var contract2 = new Contract(name: "BTC_USDT", type: Contract.TypeEnum.Direct, leverageMax: "100");

        Assert.AreEqual(contract1.GetHashCode(), contract2.GetHashCode());
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var contract = new Contract(
            name: "BTC_USDT",
            type: Contract.TypeEnum.Direct,
            lastPrice: "50000.00",
            status: "trading"
        );

        var json = contract.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<Contract>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var contract = new Contract(name: "BTC_USDT");

        var result = contract.ToString();

        Assert.IsTrue(result.Contains("class Contract"));
    }
}
