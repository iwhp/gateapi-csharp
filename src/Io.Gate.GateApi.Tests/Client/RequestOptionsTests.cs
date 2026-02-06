using System.Net;
using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class RequestOptionsTests
{
    #region Constructor Defaults

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_PathParametersIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.PathParameters);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_PathParametersIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.PathParameters.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_QueryParametersIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.QueryParameters);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_QueryParametersIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.QueryParameters.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_HeaderParametersIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.HeaderParameters);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_HeaderParametersIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.HeaderParameters.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_FormParametersIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.FormParameters);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_FormParametersIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.FormParameters.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_FileParametersIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.FileParameters);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_FileParametersIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.FileParameters.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_CookiesIsNotNull()
    {
        var options = new RequestOptions();

        Assert.IsNotNull(options.Cookies);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_CookiesIsEmpty()
    {
        var options = new RequestOptions();

        Assert.AreEqual(0, options.Cookies.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_DataIsNull()
    {
        var options = new RequestOptions();

        Assert.IsNull(options.Data);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_RequireApiV4AuthIsFalse()
    {
        var options = new RequestOptions();

        Assert.IsFalse(options.RequireApiV4Auth);
    }

    #endregion Constructor Defaults

    #region Property Types

    [TestMethod]
    [TestCategory("Unit")]
    public void PathParameters_IsDictionaryOfStringString()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.PathParameters, typeof(Dictionary<string, string>));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void QueryParameters_IsMultimapOfStringString()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.QueryParameters, typeof(Multimap<string, string>));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void HeaderParameters_IsMultimapOfStringString()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.HeaderParameters, typeof(Multimap<string, string>));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void FormParameters_IsDictionaryOfStringString()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.FormParameters, typeof(Dictionary<string, string>));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void FileParameters_IsDictionaryOfStringStream()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.FileParameters, typeof(Dictionary<string, Stream>));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Cookies_IsListOfCookie()
    {
        var options = new RequestOptions();

        Assert.IsInstanceOfType(options.Cookies, typeof(List<Cookie>));
    }

    #endregion Property Types

    #region Mutable Properties

    [TestMethod]
    [TestCategory("Unit")]
    public void RequireApiV4Auth_CanBeSetToTrue()
    {
        var options = new RequestOptions();

        options.RequireApiV4Auth = true;

        Assert.IsTrue(options.RequireApiV4Auth);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Data_CanBeSet()
    {
        var options = new RequestOptions();
        var data = new { currency_pair = "BTC_USDT" };

        options.Data = data;

        Assert.IsNotNull(options.Data);
        Assert.AreSame(data, options.Data);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void PathParameters_CanAddValues()
    {
        var options = new RequestOptions();

        options.PathParameters["order_id"] = "12345";

        Assert.AreEqual(1, options.PathParameters.Count);
        Assert.AreEqual("12345", options.PathParameters["order_id"]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void QueryParameters_CanAddValues()
    {
        var options = new RequestOptions();

        options.QueryParameters.Add("currency_pair", "BTC_USDT");

        Assert.AreEqual(1, options.QueryParameters.Count);
    }

    #endregion Mutable Properties
}
