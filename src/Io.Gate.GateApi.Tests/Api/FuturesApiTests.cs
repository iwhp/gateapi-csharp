using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Io.Gate.GateApi.Tests.Api;

[TestClass]
public class FuturesApiTests
{
    private Mock<ISynchronousClient> _mockSyncClient = null!;
    private Mock<IAsynchronousClient> _mockAsyncClient = null!;
    private Configuration _config = null!;
    private FuturesApi _api = null!;

    [TestInitialize]
    public void Setup()
    {
        _mockSyncClient = new Mock<ISynchronousClient>();
        _mockAsyncClient = new Mock<IAsynchronousClient>();
        _config = new Configuration { BasePath = "https://api.gateio.ws/api/v4" };
        _api = new FuturesApi(_mockSyncClient.Object, _mockAsyncClient.Object, _config);
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
        var api = new FuturesApi();

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
    public void ListFuturesContracts_CallsClientGet_WithCorrectPath()
    {
        // Arrange
        var expectedResponse = new ApiResponse<List<Contract>>(
            System.Net.HttpStatusCode.OK,
            new List<Contract> { new Contract() });

        string? capturedPath = null;

        _mockSyncClient
            .Setup(c => c.Get<List<Contract>>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedPath = path;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.ListFuturesContracts("usdt");

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(capturedPath);
        Assert.IsTrue(
            capturedPath.Contains("/futures/") && capturedPath.Contains("/contracts"),
            $"Expected path to contain '/futures/.../contracts', but got '{capturedPath}'.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ListFuturesTickers_CallsClientGet_WithCorrectPath()
    {
        // Arrange
        var expectedResponse = new ApiResponse<List<FuturesTicker>>(
            System.Net.HttpStatusCode.OK,
            new List<FuturesTicker> { new FuturesTicker() });

        string? capturedPath = null;

        _mockSyncClient
            .Setup(c => c.Get<List<FuturesTicker>>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedPath = path;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.ListFuturesTickers("usdt");

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(capturedPath);
        Assert.IsTrue(
            capturedPath.Contains("/futures/") && capturedPath.Contains("/tickers"),
            $"Expected path to contain '/futures/.../tickers', but got '{capturedPath}'.");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ListFuturesOrderBook_CallsClientGet_WithSettleAndContract()
    {
        // Arrange
        var expectedResponse = new ApiResponse<FuturesOrderBook>(
            System.Net.HttpStatusCode.OK,
            new FuturesOrderBook(
                asks: new List<FuturesOrderBookItem>(),
                bids: new List<FuturesOrderBookItem>()));

        string? capturedPath = null;
        RequestOptions? capturedOptions = null;

        _mockSyncClient
            .Setup(c => c.Get<FuturesOrderBook>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<IReadableConfiguration>()))
            .Callback<string, RequestOptions, IReadableConfiguration>((path, options, config) =>
            {
                capturedPath = path;
                capturedOptions = options;
            })
            .Returns(expectedResponse);

        // Act
        var result = _api.ListFuturesOrderBook("usdt", "BTC_USDT");

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(capturedPath);
        Assert.IsTrue(
            capturedPath.Contains("/futures/") && capturedPath.Contains("/order_book"),
            $"Expected path to contain '/futures/.../order_book', but got '{capturedPath}'.");
    }
}
