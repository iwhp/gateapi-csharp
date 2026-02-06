using System.Globalization;
using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class ClientUtilsTests
{
    #region SanitizeFilename

    [TestMethod]
    [TestCategory("Unit")]
    public void SanitizeFilename_WithForwardSlashPath_ReturnsFilenameOnly()
    {
        var result = ClientUtils.SanitizeFilename("/path/to/file.txt");

        Assert.AreEqual("file.txt", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SanitizeFilename_WithBackslashPath_ReturnsFilenameOnly()
    {
        var result = ClientUtils.SanitizeFilename(@"C:\Users\test\file.txt");

        Assert.AreEqual("file.txt", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SanitizeFilename_WithFilenameOnly_ReturnsUnchanged()
    {
        var result = ClientUtils.SanitizeFilename("file.txt");

        Assert.AreEqual("file.txt", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SanitizeFilename_WithNestedPath_ReturnsLastSegment()
    {
        var result = ClientUtils.SanitizeFilename("/a/b/c/d/document.pdf");

        Assert.AreEqual("document.pdf", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SanitizeFilename_EmptyString_ReturnsEmptyString()
    {
        var result = ClientUtils.SanitizeFilename("");

        Assert.AreEqual("", result);
    }

    #endregion SanitizeFilename

    #region ParameterToString

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_DateTime_ReturnsFormattedString()
    {
        var dateTime = new DateTime(2024, 1, 15, 10, 30, 0, DateTimeKind.Utc);

        var result = ClientUtils.ParameterToString(dateTime);

        // Default format is "o" (round-trip)
        Assert.IsTrue(result.Contains("2024-01-15"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_DateTimeOffset_ReturnsFormattedString()
    {
        var dateTimeOffset = new DateTimeOffset(2024, 1, 15, 10, 30, 0, TimeSpan.Zero);

        var result = ClientUtils.ParameterToString(dateTimeOffset);

        Assert.IsTrue(result.Contains("2024-01-15"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_BoolTrue_ReturnsLowercaseTrue()
    {
        var result = ClientUtils.ParameterToString(true);

        Assert.AreEqual("true", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_BoolFalse_ReturnsLowercaseFalse()
    {
        var result = ClientUtils.ParameterToString(false);

        Assert.AreEqual("false", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_Collection_ReturnsCommaJoined()
    {
        var list = new List<string> { "a", "b", "c" };

        var result = ClientUtils.ParameterToString(list);

        Assert.AreEqual("a,b,c", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_Integer_ReturnsStringRepresentation()
    {
        var result = ClientUtils.ParameterToString(42);

        Assert.AreEqual("42", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_String_ReturnsUnchanged()
    {
        var result = ClientUtils.ParameterToString("hello");

        Assert.AreEqual("hello", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_WithCustomConfiguration_UsesConfigDateTimeFormat()
    {
        var config = new Configuration { DateTimeFormat = "yyyy-MM-dd" };
        var dateTime = new DateTime(2024, 3, 15, 10, 30, 0, DateTimeKind.Utc);

        var result = ClientUtils.ParameterToString(dateTime, config);

        Assert.AreEqual("2024-03-15", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToString_EmptyCollection_ReturnsEmptyString()
    {
        var list = new List<string>();

        var result = ClientUtils.ParameterToString(list);

        Assert.AreEqual("", result);
    }

    #endregion ParameterToString

    #region UrlEncode

    [TestMethod]
    [TestCategory("Unit")]
    public void UrlEncode_SimpleString_ReturnsEncoded()
    {
        var result = ClientUtils.UrlEncode("hello world");

        Assert.AreEqual("hello%20world", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void UrlEncode_SpecialCharacters_ReturnsEncoded()
    {
        var result = ClientUtils.UrlEncode("a=b&c=d");

        Assert.AreEqual("a%3Db%26c%3Dd", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void UrlEncode_EmptyString_ReturnsEmpty()
    {
        var result = ClientUtils.UrlEncode("");

        Assert.AreEqual("", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentNullException))]
    public void UrlEncode_NullInput_ThrowsArgumentNullException()
    {
        ClientUtils.UrlEncode(null!);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void UrlEncode_AlphanumericString_ReturnsUnchanged()
    {
        var result = ClientUtils.UrlEncode("abc123");

        Assert.AreEqual("abc123", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void UrlEncode_LongString_HandlesChunking()
    {
        // Create a string longer than 32766 to trigger chunking
        var longString = new string('a', 40000);

        var result = ClientUtils.UrlEncode(longString);

        Assert.AreEqual(longString, result); // alphanumeric should not be encoded
    }

    #endregion UrlEncode

    #region Base64Encode

    [TestMethod]
    [TestCategory("Unit")]
    public void Base64Encode_SimpleString_ReturnsBase64()
    {
        var result = ClientUtils.Base64Encode("hello");

        Assert.AreEqual("aGVsbG8=", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Base64Encode_EmptyString_ReturnsEmptyBase64()
    {
        var result = ClientUtils.Base64Encode("");

        Assert.AreEqual("", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Base64Encode_CanBeDecodedBack()
    {
        var original = "test string with special chars: !@#$%";

        var encoded = ClientUtils.Base64Encode(original);
        var decoded = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encoded));

        Assert.AreEqual(original, decoded);
    }

    #endregion Base64Encode

    #region SelectHeaderContentType

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderContentType_EmptyArray_ReturnsNull()
    {
        var result = ClientUtils.SelectHeaderContentType(Array.Empty<string>());

        Assert.IsNull(result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderContentType_WithJsonMime_ReturnsJson()
    {
        var result = ClientUtils.SelectHeaderContentType(new[] { "text/plain", "application/json" });

        Assert.AreEqual("application/json", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderContentType_WithoutJsonMime_ReturnsFirst()
    {
        var result = ClientUtils.SelectHeaderContentType(new[] { "text/plain", "text/html" });

        Assert.AreEqual("text/plain", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderContentType_WithVendorJsonMime_ReturnsVendorJson()
    {
        var result = ClientUtils.SelectHeaderContentType(new[] { "text/plain", "application/vnd.company+json" });

        Assert.AreEqual("application/vnd.company+json", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderContentType_PrefersFirstJsonMime()
    {
        var result = ClientUtils.SelectHeaderContentType(new[] { "application/json", "application/vnd.api+json" });

        Assert.AreEqual("application/json", result);
    }

    #endregion SelectHeaderContentType

    #region SelectHeaderAccept

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderAccept_EmptyArray_ReturnsNull()
    {
        var result = ClientUtils.SelectHeaderAccept(Array.Empty<string>());

        Assert.IsNull(result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderAccept_ContainsApplicationJson_ReturnsApplicationJson()
    {
        var result = ClientUtils.SelectHeaderAccept(new[] { "text/plain", "application/json" });

        Assert.AreEqual("application/json", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderAccept_NoJson_JoinsAll()
    {
        var result = ClientUtils.SelectHeaderAccept(new[] { "text/plain", "text/html" });

        Assert.AreEqual("text/plain,text/html", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderAccept_CaseInsensitiveJsonCheck()
    {
        var result = ClientUtils.SelectHeaderAccept(new[] { "text/plain", "APPLICATION/JSON" });

        Assert.AreEqual("application/json", result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void SelectHeaderAccept_SingleNonJsonMime_ReturnsThatMime()
    {
        var result = ClientUtils.SelectHeaderAccept(new[] { "text/xml" });

        Assert.AreEqual("text/xml", result);
    }

    #endregion SelectHeaderAccept

    #region IsJsonMime

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_ApplicationJson_ReturnsTrue()
    {
        Assert.IsTrue(ClientUtils.IsJsonMime("application/json"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_ApplicationJsonWithCharset_ReturnsTrue()
    {
        Assert.IsTrue(ClientUtils.IsJsonMime("application/json; charset=UTF8"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_ApplicationJsonUpperCase_ReturnsTrue()
    {
        Assert.IsTrue(ClientUtils.IsJsonMime("APPLICATION/JSON"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_VendorJson_ReturnsTrue()
    {
        Assert.IsTrue(ClientUtils.IsJsonMime("application/vnd.company+json"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_JsonPatch_ReturnsTrue()
    {
        Assert.IsTrue(ClientUtils.IsJsonMime("application/json-patch+json"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_TextPlain_ReturnsFalse()
    {
        Assert.IsFalse(ClientUtils.IsJsonMime("text/plain"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_Null_ReturnsFalse()
    {
        Assert.IsFalse(ClientUtils.IsJsonMime(null!));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_EmptyString_ReturnsFalse()
    {
        Assert.IsFalse(ClientUtils.IsJsonMime(""));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void IsJsonMime_Whitespace_ReturnsFalse()
    {
        Assert.IsFalse(ClientUtils.IsJsonMime("   "));
    }

    #endregion IsJsonMime

    #region ParameterToMultiMap

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToMultiMap_MultiFormat_Collection_ProducesMultipleEntries()
    {
        var values = new List<string> { "open", "closed" };

        var result = ClientUtils.ParameterToMultiMap("multi", "status", values);

        Assert.IsTrue(result.ContainsKey("status"));
        Assert.AreEqual(2, result["status"].Count);
        Assert.AreEqual("open", result["status"][0]);
        Assert.AreEqual("closed", result["status"][1]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToMultiMap_NonMultiFormat_Collection_ProducesSingleCommaJoinedEntry()
    {
        var values = new List<string> { "open", "closed" };

        var result = ClientUtils.ParameterToMultiMap("csv", "status", values);

        Assert.IsTrue(result.ContainsKey("status"));
        Assert.AreEqual(1, result["status"].Count);
        Assert.AreEqual("open,closed", result["status"][0]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ParameterToMultiMap_SimpleValue_ProducesSingleEntry()
    {
        var result = ClientUtils.ParameterToMultiMap("", "name", "test");

        Assert.IsTrue(result.ContainsKey("name"));
        Assert.AreEqual(1, result["name"].Count);
        Assert.AreEqual("test", result["name"][0]);
    }

    #endregion ParameterToMultiMap

    #region ReadAsBytes

    [TestMethod]
    [TestCategory("Unit")]
    public void ReadAsBytes_MemoryStream_ReturnsByteArray()
    {
        var data = new byte[] { 1, 2, 3, 4, 5 };
        using var stream = new MemoryStream(data);

        var result = ClientUtils.ReadAsBytes(stream);

        CollectionAssert.AreEqual(data, result);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ReadAsBytes_EmptyStream_ReturnsEmptyArray()
    {
        using var stream = new MemoryStream();

        var result = ClientUtils.ReadAsBytes(stream);

        Assert.AreEqual(0, result.Length);
    }

    #endregion ReadAsBytes
}
