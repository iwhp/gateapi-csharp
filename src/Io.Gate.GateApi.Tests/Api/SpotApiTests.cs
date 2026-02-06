using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Io.Gate.GateApi.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Io.Gate.GateApi.Tests.Api;

[TestClass]
public class SpotApiTests
{
    private Mock<ISynchronousClient> _mockSyncClient = null!;
    private Mock<IAsynchronousClient> _mockAsyncClient = null!;
    private Configuration _config = null!;
    private SpotApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        _mockSyncClient = new Mock<ISynchronousClient>();
        _mockAsyncClient = new Mock<IAsynchronousClient>();
        _config = new Configuration { BasePath = "https://api.gateio.ws/api/v4" };
        _api = new SpotApi(_mockSyncClient.Object, _mockAsyncClient.Object, _config);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_Default_UsesGlobalConfiguration()
    {
        var api = new SpotApi();

        Assert.IsNotNull(api.Configuration);
        Assert.IsNotNull(api.Client);
        Assert.IsNotNull(api.AsynchronousClient);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithBasePath_SetsConfiguration()
    {
        var basePath = "https://custom-api.example.com/v4";

        var api = new SpotApi(basePath);

        Assert.IsNotNull(api.Configuration);
        Assert.IsTrue(api.Configuration.BasePath.Contains("custom-api.example.com"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithConfiguration_UsesProvidedConfig()
    {
        var config = new Configuration
        {
            BasePath = "https://api.gateio.ws/api/v4"
        };

        var api = new SpotApi(config);

        Assert.IsNotNull(api.Configuration);
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
    public void GetBasePath_ReturnsConfigurationBasePath()
    {
        var basePath = _api.GetBasePath();

        Assert.AreEqual("https://api.gateio.ws/api/v4", basePath);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ListCurrencies_CallsClientGet_WithCorrectPath()
    {
        // Arrange
        var expectedResponse = new ApiResponse<List<Currency>>(
            System.Net.HttpStatusCode.OK,
            new List<Currency> { new Currency() });

        _mockSyncClient
            .Setup(c => c.Get<List<Currency>>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Returns(expectedResponse);

        // Act
        var result = _api.ListCurrencies();

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);

        _mockSyncClient.Verify(c => c.Get<List<Currency>>(
            It.Is<string>(path => path.Contains("/spot/currencies")),
            It.IsAny<RequestOptions>(),
            It.IsAny<IReadableConfiguration>()),
            Times.Once);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ListTickers_IncludesQueryParameters()
    {
        // Arrange
        var expectedResponse = new ApiResponse<List<Ticker>>(
            System.Net.HttpStatusCode.OK,
            new List<Ticker> { TestDataFactory.CreateSampleTicker() });

        RequestOptions? capturedOptions = null;

        _mockSyncClient
            .Setup(c => c.Get<List<Ticker>>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedOptions = options;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.ListTickers(currencyPair: "BTC_USDT");

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(capturedOptions);
        Assert.IsTrue(
            capturedOptions.QueryParameters.Any(q => q.Key == "currency_pair"),
            "Expected query parameter 'currency_pair' to be present in RequestOptions.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void CreateOrder_SetsRequireApiV4Auth()
    {
        // Arrange
        var order = TestDataFactory.CreateSampleOrder();

        var expectedResponse = new ApiResponse<Order>(
            System.Net.HttpStatusCode.OK,
            order);

        RequestOptions? capturedOptions = null;

        _mockSyncClient
            .Setup(c => c.Post<Order>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedOptions = options;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.CreateOrder(order);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(capturedOptions);
        Assert.IsTrue(
            capturedOptions.RequireApiV4Auth,
            "CreateOrder must set RequireApiV4Auth to true for authenticated requests.");

        _mockSyncClient.Verify(c => c.Post<Order>(
            It.Is<string>(path => path.Contains("/spot/orders")),
            It.IsAny<RequestOptions>(),
            It.IsAny<IReadableConfiguration>()),
            Times.Once);
    }
}
