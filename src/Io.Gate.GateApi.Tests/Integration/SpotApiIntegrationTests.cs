using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Integration;

[TestClass]
public class SpotApiIntegrationTests : IntegrationTestBase
{
    private SpotApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        BaseSetup();
        _api = new SpotApi(Config);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListCurrencies_ReturnsNonEmptyList()
    {
        var currencies = _api.ListCurrencies();

        Assert.IsNotNull(currencies);
        Assert.IsTrue(currencies.Count > 0, "Expected at least one currency from the API.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListCurrencyPairs_ReturnsNonEmptyList()
    {
        var pairs = _api.ListCurrencyPairs();

        Assert.IsNotNull(pairs);
        Assert.IsTrue(pairs.Count > 0, "Expected at least one currency pair from the API.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListCurrencyPairs_ContainsBtcUsdt()
    {
        var pairs = _api.ListCurrencyPairs();

        Assert.IsNotNull(pairs);

        var btcUsdt = pairs.Find(p => p.Id == "BTC_USDT");
        Assert.IsNotNull(btcUsdt, "Expected BTC_USDT to be present in the currency pairs list.");
        Assert.AreEqual("BTC", btcUsdt.Base);
        Assert.AreEqual("USDT", btcUsdt.Quote);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void GetCurrency_Btc_ReturnsValidCurrency()
    {
        var currency = _api.GetCurrency("BTC");

        Assert.IsNotNull(currency);
        Assert.AreEqual("BTC", currency._Currency);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListTickers_ReturnsNonEmptyList()
    {
        var tickers = _api.ListTickers();

        Assert.IsNotNull(tickers);
        Assert.IsTrue(tickers.Count > 0, "Expected at least one ticker from the API.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListTickers_BtcUsdt_ReturnsSingleTicker()
    {
        var tickers = _api.ListTickers(currencyPair: "BTC_USDT");

        Assert.IsNotNull(tickers);
        Assert.AreEqual(1, tickers.Count, "Expected exactly one ticker for BTC_USDT.");

        var ticker = tickers[0];
        Assert.AreEqual("BTC_USDT", ticker.CurrencyPair);
        Assert.IsFalse(string.IsNullOrEmpty(ticker.Last), "Expected a non-empty 'Last' price.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListOrderBook_BtcUsdt_HasBidsAndAsks()
    {
        var orderBook = _api.ListOrderBook("BTC_USDT");

        Assert.IsNotNull(orderBook);
        Assert.IsNotNull(orderBook.Asks, "Expected asks to be present in the order book.");
        Assert.IsNotNull(orderBook.Bids, "Expected bids to be present in the order book.");
        Assert.IsTrue(orderBook.Asks.Count > 0, "Expected at least one ask entry.");
        Assert.IsTrue(orderBook.Bids.Count > 0, "Expected at least one bid entry.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListTrades_BtcUsdt_ReturnsRecentTrades()
    {
        var trades = _api.ListTrades("BTC_USDT");

        Assert.IsNotNull(trades);
        Assert.IsTrue(trades.Count > 0, "Expected at least one trade for BTC_USDT.");

        var firstTrade = trades[0];
        Assert.IsFalse(string.IsNullOrEmpty(firstTrade.Id), "Expected trade to have an ID.");
        Assert.AreEqual("BTC_USDT", firstTrade.CurrencyPair);
        Assert.IsFalse(string.IsNullOrEmpty(firstTrade.Price), "Expected trade to have a price.");
        Assert.IsFalse(string.IsNullOrEmpty(firstTrade.Amount), "Expected trade to have an amount.");
    }
}
