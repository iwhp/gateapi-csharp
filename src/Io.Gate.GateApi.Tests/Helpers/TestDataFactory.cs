using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Newtonsoft.Json;

namespace Io.Gate.GateApi.Tests.Helpers;

public static class TestDataFactory
{
    /// <summary>
    /// SDK version these tests were written/validated against.
    /// Update after verifying tests pass on a new upstream version.
    /// </summary>
    public const string TestedSdkVersion = "7.105.8";

    public static Configuration CreateTestConfiguration()
    {
        var config = new Configuration();
        config.SetGateApiV4KeyPair("test-api-key", "test-api-secret");
        return config;
    }

    public static Order CreateSampleOrder()
    {
        return new Order(
            text: "t-test-order",
            currencyPair: "BTC_USDT",
            type: Order.TypeEnum.Limit,
            account: "spot",
            side: Order.SideEnum.Buy,
            amount: "0.001",
            price: "50000",
            timeInForce: Order.TimeInForceEnum.Gtc
        );
    }

    public static Ticker CreateSampleTicker()
    {
        return new Ticker(
            currencyPair: "BTC_USDT",
            last: "50000.00",
            lowestAsk: "50001.00",
            highestBid: "49999.00",
            changePercentage: "2.5",
            baseVolume: "1234.56",
            quoteVolume: "61728000",
            high24h: "51000.00",
            low24h: "49000.00"
        );
    }

    public static Trade CreateSampleTrade()
    {
        return new Trade(
            id: "123456",
            currencyPair: "BTC_USDT",
            side: Trade.SideEnum.Buy,
            amount: "0.001",
            price: "50000"
        );
    }

    public static CurrencyPair CreateSampleCurrencyPair()
    {
        return new CurrencyPair(
            id: "BTC_USDT",
            _base: "BTC",
            quote: "USDT",
            fee: "0.2",
            minBaseAmount: "0.0001",
            minQuoteAmount: "1",
            amountPrecision: 4,
            precision: 2
        );
    }

    public static SpotAccount CreateSampleSpotAccount()
    {
        return new SpotAccount(
            currency: "BTC",
            available: "1.5",
            locked: "0.5"
        );
    }

    // JSON samples that mirror real Gate.io API responses
    public static string GetOrderJsonSample() => @"{
        ""id"": ""123456789"",
        ""text"": ""t-my-order"",
        ""create_time"": ""1710000000"",
        ""update_time"": ""1710000001"",
        ""create_time_ms"": 1710000000123,
        ""update_time_ms"": 1710000001456,
        ""status"": ""open"",
        ""currency_pair"": ""BTC_USDT"",
        ""type"": ""limit"",
        ""account"": ""spot"",
        ""side"": ""buy"",
        ""amount"": ""0.001"",
        ""price"": ""50000"",
        ""time_in_force"": ""gtc"",
        ""iceberg"": ""0"",
        ""auto_borrow"": false,
        ""auto_repay"": false,
        ""left"": ""0.001"",
        ""filled_amount"": ""0"",
        ""fill_price"": ""0"",
        ""filled_total"": ""0"",
        ""avg_deal_price"": ""0"",
        ""fee"": ""0"",
        ""fee_currency"": ""BTC"",
        ""point_fee"": ""0"",
        ""gt_fee"": ""0"",
        ""gt_discount"": false,
        ""rebated_fee"": ""0"",
        ""rebated_fee_currency"": ""USDT"",
        ""stp_id"": 0,
        ""stp_act"": ""-"",
        ""finish_as"": ""open""
    }";

    public static string GetTradeJsonSample() => @"{
        ""id"": ""987654321"",
        ""create_time"": ""1710000000"",
        ""create_time_ms"": ""1710000000123"",
        ""currency_pair"": ""BTC_USDT"",
        ""side"": ""buy"",
        ""role"": ""taker"",
        ""amount"": ""0.001"",
        ""price"": ""50000"",
        ""order_id"": ""123456789"",
        ""fee"": ""0.00000002"",
        ""fee_currency"": ""BTC"",
        ""point_fee"": ""0"",
        ""gt_fee"": ""0""
    }";

    public static string GetTickerJsonSample() => @"{
        ""currency_pair"": ""BTC_USDT"",
        ""last"": ""50000.00"",
        ""lowest_ask"": ""50001.00"",
        ""lowest_size"": ""0.1"",
        ""highest_bid"": ""49999.00"",
        ""highest_size"": ""0.2"",
        ""change_percentage"": ""2.5"",
        ""change_utc0"": ""2.3"",
        ""change_utc8"": ""2.1"",
        ""base_volume"": ""1234.56"",
        ""quote_volume"": ""61728000"",
        ""high_24h"": ""51000.00"",
        ""low_24h"": ""49000.00""
    }";

    public static string GetCurrencyPairJsonSample() => @"{
        ""id"": ""BTC_USDT"",
        ""base"": ""BTC"",
        ""quote"": ""USDT"",
        ""fee"": ""0.2"",
        ""min_base_amount"": ""0.0001"",
        ""min_quote_amount"": ""1"",
        ""amount_precision"": 4,
        ""precision"": 2,
        ""trade_status"": ""tradable"",
        ""sell_start"": 0,
        ""buy_start"": 0
    }";

    public static string GetSpotAccountJsonSample() => @"{
        ""currency"": ""BTC"",
        ""available"": ""1.5"",
        ""locked"": ""0.5"",
        ""update_id"": ""123""
    }";

    public static string GetGateApiErrorJsonSample() => @"{
        ""label"": ""INVALID_PARAM_VALUE"",
        ""message"": ""Invalid parameter value"",
        ""detail"": ""currency_pair is required""
    }";
}
