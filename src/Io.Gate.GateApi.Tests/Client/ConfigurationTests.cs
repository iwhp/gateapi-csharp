using System.Collections.Concurrent;
using System.Net;
using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class ConfigurationTests
{
    #region Default Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_SetsBasePath()
    {
        var config = new Configuration();

        Assert.AreEqual("https://api.gateio.ws/api/v4", config.BasePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_SetsTimeout()
    {
        var config = new Configuration();

        Assert.AreEqual(100000, config.Timeout);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_SetsUserAgent()
    {
        var config = new Configuration();

        Assert.AreEqual("OpenAPI-Generator/7.105.8/csharp", config.UserAgent);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_InitializesDefaultHeaders()
    {
        var config = new Configuration();

        Assert.IsNotNull(config.DefaultHeaders);
        Assert.IsInstanceOfType(config.DefaultHeaders, typeof(ConcurrentDictionary<string, string>));
        Assert.AreEqual(0, config.DefaultHeaders.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_ApiV4KeyIsNull()
    {
        var config = new Configuration();

        Assert.IsNull(config.ApiV4Key);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_ApiV4SecretIsNull()
    {
        var config = new Configuration();

        Assert.IsNull(config.ApiV4Secret);
    }

    #endregion Default Constructor

    #region Parameterized Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithHeaders_SetsHeaders()
    {
        var headers = new Dictionary<string, string> { { "X-Custom", "value" } };

        var config = new Configuration(headers, null, null);

        Assert.IsTrue(config.DefaultHeaders.ContainsKey("X-Custom"));
        Assert.AreEqual("value", config.DefaultHeaders["X-Custom"]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithCustomBasePath_SetsBasePath()
    {
        var config = new Configuration(
            new Dictionary<string, string>(),
            null,
            null,
            "https://custom.api.example.com/v1");

        Assert.AreEqual("https://custom.api.example.com/v1", config.BasePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithNullHeaders_InitializesEmptyHeaders()
    {
        var config = new Configuration(null, null, null);

        Assert.IsNotNull(config.DefaultHeaders);
        Assert.AreEqual(0, config.DefaultHeaders.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_WithBlankBasePath_ThrowsArgumentException()
    {
        _ = new Configuration(new Dictionary<string, string>(), null, null, "");
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_WithWhitespaceBasePath_ThrowsArgumentException()
    {
        _ = new Configuration(new Dictionary<string, string>(), null, null, "   ");
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_WithNullBasePath_ThrowsArgumentException()
    {
        _ = new Configuration(new Dictionary<string, string>(), null, null, null!);
    }

    #endregion Parameterized Constructor

    #region SetGateApiV4KeyPair

    [TestMethod]
    [TestCategory("Unit")]
    public void SetGateApiV4KeyPair_SetsBothKeyAndSecret()
    {
        var config = new Configuration();

        config.SetGateApiV4KeyPair("my-key", "my-secret");

        Assert.AreEqual("my-key", config.ApiV4Key);
        Assert.AreEqual("my-secret", config.ApiV4Secret);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SetGateApiV4KeyPair_OverwritesPreviousValues()
    {
        var config = new Configuration();
        config.SetGateApiV4KeyPair("old-key", "old-secret");

        config.SetGateApiV4KeyPair("new-key", "new-secret");

        Assert.AreEqual("new-key", config.ApiV4Key);
        Assert.AreEqual("new-secret", config.ApiV4Secret);
    }

    #endregion SetGateApiV4KeyPair

    #region Version

    [TestMethod]
    [TestCategory("Unit")]
    public void Version_ReturnsExpectedValue()
    {
        Assert.AreEqual("7.105.8", Configuration.Version);
    }

    #endregion Version

    #region DateTimeFormat

    [TestMethod]
    [TestCategory("Unit")]
    public void DateTimeFormat_DefaultIsIso8601()
    {
        var config = new Configuration();

        Assert.AreEqual("o", config.DateTimeFormat);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DateTimeFormat_CanBeSetToCustomFormat()
    {
        var config = new Configuration();

        config.DateTimeFormat = "yyyy-MM-dd";

        Assert.AreEqual("yyyy-MM-dd", config.DateTimeFormat);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DateTimeFormat_ResetsToDefaultWhenSetToEmpty()
    {
        var config = new Configuration();
        config.DateTimeFormat = "yyyy-MM-dd";

        config.DateTimeFormat = "";

        Assert.AreEqual(Configuration.ISO8601_DATETIME_FORMAT, config.DateTimeFormat);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DateTimeFormat_ResetsToDefaultWhenSetToNull()
    {
        var config = new Configuration();
        config.DateTimeFormat = "yyyy-MM-dd";

        config.DateTimeFormat = null;

        Assert.AreEqual(Configuration.ISO8601_DATETIME_FORMAT, config.DateTimeFormat);
    }

    #endregion DateTimeFormat

    #region TempFolderPath

    [TestMethod]
    [TestCategory("Unit")]
    public void TempFolderPath_DefaultIsSystemTemp()
    {
        var config = new Configuration();

        Assert.AreEqual(Path.GetTempPath(), config.TempFolderPath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void TempFolderPath_ResetsToDefaultWhenSetToEmpty()
    {
        var config = new Configuration();

        config.TempFolderPath = "";

        Assert.AreEqual(Path.GetTempPath(), config.TempFolderPath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void TempFolderPath_ResetsToDefaultWhenSetToNull()
    {
        var config = new Configuration();

        config.TempFolderPath = null;

        Assert.AreEqual(Path.GetTempPath(), config.TempFolderPath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void TempFolderPath_AppendsDirectorySeparatorIfMissing()
    {
        var config = new Configuration();
        var tempDir = Path.Combine(Path.GetTempPath(), "gateapi_test_" + Guid.NewGuid().ToString("N"));

        try
        {
            config.TempFolderPath = tempDir;

            Assert.IsTrue(config.TempFolderPath.EndsWith(Path.DirectorySeparatorChar.ToString()));
        }
        finally
        {
            if (Directory.Exists(tempDir))
                Directory.Delete(tempDir);
        }
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void TempFolderPath_KeepsDirectorySeparatorIfPresent()
    {
        var config = new Configuration();
        var tempDir = Path.Combine(Path.GetTempPath(), "gateapi_test_" + Guid.NewGuid().ToString("N")) + Path.DirectorySeparatorChar;

        try
        {
            config.TempFolderPath = tempDir;

            Assert.AreEqual(tempDir, config.TempFolderPath);
        }
        finally
        {
            var dirWithoutSeparator = tempDir.TrimEnd(Path.DirectorySeparatorChar);
            if (Directory.Exists(dirWithoutSeparator))
                Directory.Delete(dirWithoutSeparator);
        }
    }

    #endregion TempFolderPath

    #region MergeConfigurations

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_BothNull_ReturnsGlobalInstance()
    {
        var result = Configuration.MergeConfigurations(null!, null);

        Assert.AreSame(GlobalConfiguration.Instance, result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_SecondNull_ReturnsFirst()
    {
        var first = new Configuration();

        var result = Configuration.MergeConfigurations(first, null);

        Assert.AreSame(first, result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_PrefersSecondBasePath()
    {
        var first = new Configuration { BasePath = "https://first.example.com" };
        var second = new Configuration { BasePath = "https://second.example.com" };

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual("https://second.example.com", result.BasePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_FallsBackToFirstWhenSecondBasePathIsNull()
    {
        var first = new Configuration { BasePath = "https://first.example.com" };
        var second = new Configuration { BasePath = null! };

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual("https://first.example.com", result.BasePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_MergesHeaders()
    {
        var first = new Configuration();
        first.DefaultHeaders["X-First"] = "first-value";

        var second = new Configuration();
        second.DefaultHeaders["X-Second"] = "second-value";

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual("first-value", result.DefaultHeaders["X-First"]);
        Assert.AreEqual("second-value", result.DefaultHeaders["X-Second"]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_SecondHeaderOverridesFirst()
    {
        var first = new Configuration();
        first.DefaultHeaders["X-Shared"] = "first-value";

        var second = new Configuration();
        second.DefaultHeaders["X-Shared"] = "second-value";

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual("second-value", result.DefaultHeaders["X-Shared"]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_PrefersSecondApiV4Key()
    {
        var first = new Configuration();
        first.SetGateApiV4KeyPair("first-key", "first-secret");

        var second = new Configuration();
        second.SetGateApiV4KeyPair("second-key", "second-secret");

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual("second-key", result.ApiV4Key);
        Assert.AreEqual("second-secret", result.ApiV4Secret);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void MergeConfigurations_UsesSecondTimeout()
    {
        var first = new Configuration { Timeout = 5000 };
        var second = new Configuration { Timeout = 30000 };

        var result = Configuration.MergeConfigurations(first, second);

        Assert.AreEqual(30000, result.Timeout);
    }

    #endregion MergeConfigurations

    #region DefaultExceptionFactory

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_SuccessStatusCode_ReturnsNull()
    {
        var response = new ApiResponse<string>(HttpStatusCode.OK, "data", "data");

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNull(exception);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_Status400WithGateApiExceptionJson_ReturnsGateApiException()
    {
        var rawContent = @"{""label"":""INVALID_PARAM_VALUE"",""message"":""Invalid parameter""}";
        var response = new ApiResponse<string>(HttpStatusCode.BadRequest, "error", rawContent);

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNotNull(exception);
        Assert.IsInstanceOfType(exception, typeof(GateApiException));
        var gateEx = (GateApiException)exception;
        Assert.AreEqual("INVALID_PARAM_VALUE", gateEx.ErrorLabel);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_Status400WithInvalidJson_ReturnsApiException()
    {
        var rawContent = "this is not json";
        var response = new ApiResponse<string>(HttpStatusCode.BadRequest, "error", rawContent);

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNotNull(exception);
        Assert.IsInstanceOfType(exception, typeof(ApiException));
        var apiEx = (ApiException)exception;
        Assert.AreEqual(400, apiEx.ErrorCode);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_Status400WithEmptyLabel_ReturnsApiException()
    {
        var rawContent = @"{""label"":"""",""message"":""Some error""}";
        var response = new ApiResponse<string>(HttpStatusCode.BadRequest, "error", rawContent);

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNotNull(exception);
        Assert.IsInstanceOfType(exception, typeof(ApiException));
        Assert.IsNotInstanceOfType(exception, typeof(GateApiException));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_SuccessWithErrorText_ReturnsApiException()
    {
        var response = new ApiResponse<string>(HttpStatusCode.OK, "data")
        {
            ErrorText = "Connection timed out"
        };

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNotNull(exception);
        Assert.IsInstanceOfType(exception, typeof(ApiException));
        Assert.IsTrue(exception.Message.Contains("Connection timed out"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_SuccessWithNullErrorText_ReturnsNull()
    {
        var response = new ApiResponse<string>(HttpStatusCode.OK, "data")
        {
            ErrorText = null
        };

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNull(exception);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultExceptionFactory_Status500_ReturnsApiException()
    {
        var rawContent = "Internal Server Error";
        var response = new ApiResponse<string>(HttpStatusCode.InternalServerError, "error", rawContent);

        var exception = Configuration.DefaultExceptionFactory("TestMethod", response);

        Assert.IsNotNull(exception);
        Assert.IsInstanceOfType(exception, typeof(ApiException));
        var apiEx = (ApiException)exception;
        Assert.AreEqual(500, apiEx.ErrorCode);
    }

    #endregion DefaultExceptionFactory

    #region ToDebugReport

    [TestMethod]
    [TestCategory("Unit")]
    public void ToDebugReport_ContainsSdkVersion()
    {
        var report = Configuration.ToDebugReport();

        Assert.IsTrue(report.Contains("7.105.8"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToDebugReport_ContainsOsInfo()
    {
        var report = Configuration.ToDebugReport();

        Assert.IsTrue(report.Contains("OS:"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToDebugReport_ContainsSdkName()
    {
        var report = Configuration.ToDebugReport();

        Assert.IsTrue(report.Contains("Io.Gate.GateApi"));
    }

    #endregion ToDebugReport

    #region ISO8601_DATETIME_FORMAT

    [TestMethod]
    [TestCategory("Unit")]
    public void Iso8601DateTimeFormat_IsRoundTripFormat()
    {
        Assert.AreEqual("o", Configuration.ISO8601_DATETIME_FORMAT);
    }

    #endregion ISO8601_DATETIME_FORMAT
}
