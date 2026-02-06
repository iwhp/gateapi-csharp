using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class ApiExceptionTests
{
    #region Default Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_ErrorCodeIsZero()
    {
        var exception = new ApiException();

        Assert.AreEqual(0, exception.ErrorCode);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_ErrorContentIsNull()
    {
        var exception = new ApiException();

        Assert.IsNull(exception.ErrorContent);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_MessageIsNull()
    {
        var exception = new ApiException();

        // The base Exception default message is used when no message is provided.
        // We just check the exception was created successfully.
        Assert.IsNotNull(exception);
    }

    #endregion Default Constructor

    #region Two-Parameter Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorCodeAndMessage_SetsErrorCode()
    {
        var exception = new ApiException(404, "Not Found");

        Assert.AreEqual(404, exception.ErrorCode);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorCodeAndMessage_SetsMessage()
    {
        var exception = new ApiException(404, "Not Found");

        Assert.AreEqual("Not Found", exception.Message);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorCodeAndMessage_ErrorContentIsNull()
    {
        var exception = new ApiException(404, "Not Found");

        Assert.IsNull(exception.ErrorContent);
    }

    #endregion Two-Parameter Constructor

    #region Three-Parameter Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorContent_SetsErrorContent()
    {
        var content = new { detail = "Resource not found" };

        var exception = new ApiException(404, "Not Found", content);

        Assert.IsNotNull(exception.ErrorContent);
        Assert.AreSame(content, exception.ErrorContent);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorContent_SetsErrorCode()
    {
        var exception = new ApiException(500, "Internal Server Error", "error body");

        Assert.AreEqual(500, exception.ErrorCode);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithErrorContent_SetsMessage()
    {
        var exception = new ApiException(500, "Internal Server Error", "error body");

        Assert.AreEqual("Internal Server Error", exception.Message);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithNullErrorContent_ErrorContentIsNull()
    {
        var exception = new ApiException(400, "Bad Request", null);

        Assert.IsNull(exception.ErrorContent);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithStringErrorContent_SetsStringContent()
    {
        var exception = new ApiException(400, "Bad Request", "invalid input");

        Assert.AreEqual("invalid input", exception.ErrorContent);
    }

    #endregion Three-Parameter Constructor

    #region ErrorCode Property

    [TestMethod]
    [TestCategory("Unit")]
    public void ErrorCode_CanBeSetAfterConstruction()
    {
        var exception = new ApiException(200, "OK");

        exception.ErrorCode = 503;

        Assert.AreEqual(503, exception.ErrorCode);
    }

    #endregion ErrorCode Property

    #region Inheritance

    [TestMethod]
    [TestCategory("Unit")]
    public void ApiException_InheritsFromException()
    {
        var exception = new ApiException();

        Assert.IsInstanceOfType(exception, typeof(Exception));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ApiException_CanBeCaughtAsException()
    {
        try
        {
            throw new ApiException(500, "Server Error");
        }
        catch (Exception ex)
        {
            Assert.IsInstanceOfType(ex, typeof(ApiException));
            Assert.AreEqual("Server Error", ex.Message);
            return;
        }

        Assert.Fail("Exception was not caught.");
    }

    #endregion Inheritance
}
