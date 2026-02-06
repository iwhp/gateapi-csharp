using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Integration;

[TestClass]
public class WalletApiIntegrationTests : IntegrationTestBase
{
    private WalletApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        BaseSetup();
        RequireApiKeys();
        _api = new WalletApi(Config);
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void GetTotalBalance_ReturnsBalance()
    {
        var totalBalance = _api.GetTotalBalance();

        Assert.IsNotNull(totalBalance);
        Assert.IsNotNull(totalBalance.Total, "Expected total balance to have a total value.");
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void GetTradeFee_ReturnsValidFeeInfo()
    {
        var tradeFee = _api.GetTradeFee();

        Assert.IsNotNull(tradeFee);
        Assert.IsTrue(tradeFee.UserId > 0, "Expected trade fee to have a valid user ID.");
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void ListCurrencyChains_Btc_ReturnsSupportedChains()
    {
        var chains = _api.ListCurrencyChains("BTC");

        Assert.IsNotNull(chains);
        Assert.IsTrue(chains.Count > 0, "Expected at least one chain for BTC.");
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void ListSmallBalance_ReturnsResult()
    {
        var smallBalances = _api.ListSmallBalance();

        Assert.IsNotNull(smallBalances);
        // Small balances list may be empty, but the response should not be null
    }
}
