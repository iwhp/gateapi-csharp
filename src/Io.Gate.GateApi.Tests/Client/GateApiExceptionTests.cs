using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class GateApiExceptionTests
{
    #region Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_SetsErrorLabel()
    {
        var exception = new GateApiException("INVALID_PARAM_VALUE", "Invalid parameter", "currency_pair is required");

        Assert.AreEqual("INVALID_PARAM_VALUE", exception.ErrorLabel);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithAllParameters_SetsAllProperties()
    {
        var exception = new GateApiException("ORDER_NOT_FOUND", "Order not found", "Order 12345 does not exist");

        Assert.AreEqual("ORDER_NOT_FOUND", exception.ErrorLabel);
        Assert.AreEqual("Order 12345 does not exist", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithNullMessageAndDetail_ErrorMessageIsNull()
    {
        var exception = new GateApiException("SOME_LABEL");

        Assert.AreEqual("SOME_LABEL", exception.ErrorLabel);
        Assert.IsNull(exception.ErrorMessage);
    }

    #endregion Constructor

    #region ErrorMessage Property

    [TestMethod]
    [TestCategory("Unit")]
    public void ErrorMessage_PrefersDetailOverMessage()
    {
        var exception = new GateApiException("LABEL", "generic message", "specific detail");

        Assert.AreEqual("specific detail", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ErrorMessage_ReturnsMessageWhenDetailIsNull()
    {
        var exception = new GateApiException("LABEL", "generic message", null);

        Assert.AreEqual("generic message", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ErrorMessage_ReturnsMessageWhenDetailIsEmpty()
    {
        var exception = new GateApiException("LABEL", "generic message", "");

        Assert.AreEqual("generic message", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ErrorMessage_ReturnsMessageWhenDetailIsWhitespace()
    {
        var exception = new GateApiException("LABEL", "generic message", "   ");

        Assert.AreEqual("generic message", exception.ErrorMessage);
    }

    #endregion ErrorMessage Property

    #region Message Property (JSON Serialized)

    [TestMethod]
    [TestCategory("Unit")]
    public void Message_ReturnsJsonSerializedString()
    {
        var exception = new GateApiException("INVALID_PARAM_VALUE", "Invalid parameter", null);

        var message = exception.Message;

        Assert.IsNotNull(message);
        Assert.IsTrue(message.Contains("INVALID_PARAM_VALUE"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Message_IsValidJson()
    {
        var exception = new GateApiException("TEST_LABEL", "test message", "test detail");

        var message = exception.Message;

        // Should not throw
        var parsed = JsonConvert.DeserializeObject<Dictionary<string, object>>(message);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Message_ContainsLabelField()
    {
        var exception = new GateApiException("MY_LABEL", "my message", null);

        var message = exception.Message;
        var parsed = JsonConvert.DeserializeObject<Dictionary<string, object>>(message)!;

        Assert.IsTrue(parsed.ContainsKey("label"));
        Assert.AreEqual("MY_LABEL", parsed["label"]?.ToString());
    }

    #endregion Message Property (JSON Serialized)

    #region JSON Deserialization

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_WithAllFields_DeserializesCorrectly()
    {
        var json = @"{""label"":""INVALID_PARAM_VALUE"",""message"":""Invalid parameter"",""detail"":""currency_pair is required""}";

        var exception = JsonConvert.DeserializeObject<GateApiException>(json);

        Assert.IsNotNull(exception);
        Assert.AreEqual("INVALID_PARAM_VALUE", exception.ErrorLabel);
        Assert.AreEqual("currency_pair is required", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_WithoutDetail_UsesMessage()
    {
        var json = @"{""label"":""ORDER_NOT_FOUND"",""message"":""Order not found""}";

        var exception = JsonConvert.DeserializeObject<GateApiException>(json);

        Assert.IsNotNull(exception);
        Assert.AreEqual("ORDER_NOT_FOUND", exception.ErrorLabel);
        Assert.AreEqual("Order not found", exception.ErrorMessage);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_LabelOnly_DeserializesCorrectly()
    {
        var json = @"{""label"":""UNKNOWN_ERROR""}";

        var exception = JsonConvert.DeserializeObject<GateApiException>(json);

        Assert.IsNotNull(exception);
        Assert.AreEqual("UNKNOWN_ERROR", exception.ErrorLabel);
    }

    #endregion JSON Deserialization

    #region Inheritance

    [TestMethod]
    [TestCategory("Unit")]
    public void GateApiException_InheritsFromApiException()
    {
        var exception = new GateApiException("LABEL", "message", null);

        Assert.IsInstanceOfType(exception, typeof(ApiException));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GateApiException_InheritsFromException()
    {
        var exception = new GateApiException("LABEL", "message", null);

        Assert.IsInstanceOfType(exception, typeof(Exception));
    }

    #endregion Inheritance
}
