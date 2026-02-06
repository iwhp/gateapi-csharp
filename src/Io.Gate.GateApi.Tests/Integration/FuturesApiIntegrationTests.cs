using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Integration;

[TestClass]
public class FuturesApiIntegrationTests : IntegrationTestBase
{
    private FuturesApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        BaseSetup();
        _api = new FuturesApi(Config);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListFuturesContracts_Usdt_ReturnsNonEmptyList()
    {
        var contracts = _api.ListFuturesContracts("usdt");

        Assert.IsNotNull(contracts);
        Assert.IsTrue(contracts.Count > 0, "Expected at least one USDT futures contract.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void GetFuturesContract_BtcUsdt_ReturnsValidContract()
    {
        var contract = _api.GetFuturesContract("usdt", "BTC_USDT");

        Assert.IsNotNull(contract);
        Assert.AreEqual("BTC_USDT", contract.Name);
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListFuturesTickers_Usdt_ReturnsNonEmptyList()
    {
        var tickers = _api.ListFuturesTickers("usdt");

        Assert.IsNotNull(tickers);
        Assert.IsTrue(tickers.Count > 0, "Expected at least one USDT futures ticker.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListFuturesOrderBook_BtcUsdt_HasBidsAndAsks()
    {
        var orderBook = _api.ListFuturesOrderBook("usdt", "BTC_USDT");

        Assert.IsNotNull(orderBook);
        Assert.IsNotNull(orderBook.Asks, "Expected asks to be present in the futures order book.");
        Assert.IsNotNull(orderBook.Bids, "Expected bids to be present in the futures order book.");
        Assert.IsTrue(orderBook.Asks.Count > 0, "Expected at least one ask entry.");
        Assert.IsTrue(orderBook.Bids.Count > 0, "Expected at least one bid entry.");
    }

    [TestMethod]
    [TestCategory("Integration")]
    public void ListFuturesTrades_BtcUsdt_ReturnsRecentTrades()
    {
        var trades = _api.ListFuturesTrades("usdt", "BTC_USDT");

        Assert.IsNotNull(trades);
        Assert.IsTrue(trades.Count > 0, "Expected at least one futures trade for BTC_USDT.");

        var firstTrade = trades[0];
        Assert.IsTrue(firstTrade.Id > 0, "Expected futures trade to have a valid ID.");
        Assert.AreEqual("BTC_USDT", firstTrade.Contract);
        Assert.IsFalse(string.IsNullOrEmpty(firstTrade.Price), "Expected futures trade to have a price.");
    }
}
