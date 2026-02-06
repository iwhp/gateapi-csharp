using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Io.Gate.GateApi.Tests.Api;

[TestClass]
public class AccountApiTests
{
    private Mock<ISynchronousClient> _mockSyncClient = null!;
    private Mock<IAsynchronousClient> _mockAsyncClient = null!;
    private Configuration _config = null!;
    private AccountApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        _mockSyncClient = new Mock<ISynchronousClient>();
        _mockAsyncClient = new Mock<IAsynchronousClient>();
        _config = new Configuration { BasePath = "https://api.gateio.ws/api/v4" };
        _api = new AccountApi(_mockSyncClient.Object, _mockAsyncClient.Object, _config);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithClients_SetsClientsAndConfig()
    {
        Assert.AreSame(_mockSyncClient.Object, _api.Client);
        Assert.AreSame(_mockAsyncClient.Object, _api.AsynchronousClient);
        Assert.AreSame(_config, _api.Configuration);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_Default_UsesGlobalConfiguration()
    {
        var api = new AccountApi();

        Assert.IsNotNull(api.Configuration);
        Assert.IsNotNull(api.Client);
        Assert.IsNotNull(api.AsynchronousClient);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetBasePath_ReturnsConfigurationBasePath()
    {
        var basePath = _api.GetBasePath();

        Assert.AreEqual("https://api.gateio.ws/api/v4", basePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetAccountDetail_SetsRequireApiV4Auth()
    {
        // Arrange
        var expectedResponse = new ApiResponse<AccountDetail>(
            System.Net.HttpStatusCode.OK,
            new AccountDetail());

        RequestOptions? capturedOptions = null;

        _mockSyncClient
            .Setup(c => c.Get<AccountDetail>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedOptions = options;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.GetAccountDetail();

        // Assert
        Assert.IsNotNull(capturedOptions);
        Assert.IsTrue(
            capturedOptions.RequireApiV4Auth,
            "GetAccountDetail must set RequireApiV4Auth to true for authenticated requests.");

        _mockSyncClient.Verify(c => c.Get<AccountDetail>(
            It.Is<string>(path => path.Contains("/account/detail")),
            It.IsAny<RequestOptions>(),
            It.IsAny<IReadableConfiguration>()),
            Times.Once);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetAccountRateLimit_SetsRequireApiV4Auth()
    {
        // Arrange
        var expectedResponse = new ApiResponse<List<AccountRateLimit>>(
            System.Net.HttpStatusCode.OK,
            new List<AccountRateLimit>());

        RequestOptions? capturedOptions = null;

        _mockSyncClient
            .Setup(c => c.Get<List<AccountRateLimit>>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedOptions = options;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.GetAccountRateLimit();

        // Assert
        Assert.IsNotNull(capturedOptions);
        Assert.IsTrue(
            capturedOptions.RequireApiV4Auth,
            "GetAccountRateLimit must set RequireApiV4Auth to true for authenticated requests.");

        _mockSyncClient.Verify(c => c.Get<List<AccountRateLimit>>(
            It.Is<string>(path => path.Contains("/account/rate_limit")),
            It.IsAny<RequestOptions>(),
            It.IsAny<IReadableConfiguration>()),
            Times.Once);
    }
}
