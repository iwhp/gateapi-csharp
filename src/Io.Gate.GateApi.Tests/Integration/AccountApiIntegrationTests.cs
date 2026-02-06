using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Integration;

[TestClass]
public class AccountApiIntegrationTests : IntegrationTestBase
{
    private AccountApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        BaseSetup();
        RequireApiKeys();
        _api = new AccountApi(Config);
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void GetAccountDetail_ReturnsValidAccount()
    {
        var detail = _api.GetAccountDetail();

        Assert.IsNotNull(detail);
        Assert.IsTrue(detail.UserId > 0, "Expected account detail to have a valid user ID.");
    }

    [TestMethod]
    [TestCategory("IntegrationAuth")]
    public void GetAccountRateLimit_ReturnsLimits()
    {
        var rateLimits = _api.GetAccountRateLimit();

        Assert.IsNotNull(rateLimits);
        // Rate limits may be an empty list if no limits are set, but the response should not be null
    }
}
