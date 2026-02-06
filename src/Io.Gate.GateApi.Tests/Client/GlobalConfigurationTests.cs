using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class GlobalConfigurationTests
{
    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_IsNotNull()
    {
        Assert.IsNotNull(GlobalConfiguration.Instance);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_HasCorrectDefaultBasePath()
    {
        Assert.AreEqual("https://api.gateio.ws/api/v4", GlobalConfiguration.Instance.BasePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_IsReadableConfiguration()
    {
        Assert.IsInstanceOfType(GlobalConfiguration.Instance, typeof(IReadableConfiguration));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_CanBeReplacedAndRestored()
    {
        var original = GlobalConfiguration.Instance;

        try
        {
            var custom = new Configuration { BasePath = "https://custom.example.com" };
            GlobalConfiguration.Instance = custom;

            Assert.AreSame(custom, GlobalConfiguration.Instance);
            Assert.AreEqual("https://custom.example.com", GlobalConfiguration.Instance.BasePath);
        }
        finally
        {
            GlobalConfiguration.Instance = original;
        }
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_DefaultUserAgent()
    {
        Assert.AreEqual("OpenAPI-Generator/7.105.8/csharp", GlobalConfiguration.Instance.UserAgent);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Instance_DefaultTimeout()
    {
        Assert.AreEqual(100000, GlobalConfiguration.Instance.Timeout);
    }
}
