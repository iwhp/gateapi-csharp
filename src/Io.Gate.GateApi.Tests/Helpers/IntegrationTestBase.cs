using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Helpers;

[TestClass]
public abstract class IntegrationTestBase
{
    protected Configuration Config { get; private set; } = null!;
    protected bool HasApiKeys => !string.IsNullOrEmpty(Config.ApiV4Key);

    [TestInitialize]
    public void BaseSetup()
    {
        Config = new Configuration
        {
            BasePath = "https://api.gateio.ws/api/v4"
        };

        var apiKey = Environment.GetEnvironmentVariable("GATE_API_KEY");
        var apiSecret = Environment.GetEnvironmentVariable("GATE_API_SECRET");
        if (!string.IsNullOrEmpty(apiKey) && !string.IsNullOrEmpty(apiSecret))
        {
            Config.SetGateApiV4KeyPair(apiKey, apiSecret);
        }
    }

    protected void RequireApiKeys()
    {
        if (!HasApiKeys)
            Assert.Inconclusive("Skipped: GATE_API_KEY and GATE_API_SECRET environment variables not set.");
    }
}
