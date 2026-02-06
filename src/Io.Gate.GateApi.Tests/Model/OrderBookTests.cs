using Io.Gate.GateApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Io.Gate.GateApi.Tests.Model;

[TestClass]
public class OrderBookTests
{
    private static readonly JsonSerializerSettings JsonSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy { OverrideSpecifiedNames = true }
        }
    };

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithAllParams_SetsProperties()
    {
        var asks = new List<List<string>>
        {
            new() { "50001.00", "0.1" },
            new() { "50002.00", "0.2" }
        };
        var bids = new List<List<string>>
        {
            new() { "49999.00", "0.3" },
            new() { "49998.00", "0.4" }
        };

        var orderBook = new OrderBook(
            id: 12345L,
            current: 1710000000000L,
            update: 1710000000100L,
            asks: asks,
            bids: bids
        );

        Assert.AreEqual(12345L, orderBook.Id);
        Assert.AreEqual(1710000000000L, orderBook.Current);
        Assert.AreEqual(1710000000100L, orderBook.Update);
        Assert.AreEqual(2, orderBook.Asks.Count);
        Assert.AreEqual(2, orderBook.Bids.Count);
        Assert.AreEqual("50001.00", orderBook.Asks[0][0]);
        Assert.AreEqual("0.1", orderBook.Asks[0][1]);
        Assert.AreEqual("49999.00", orderBook.Bids[0][0]);
        Assert.AreEqual("0.3", orderBook.Bids[0][1]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Constructor_WithoutAsks_ThrowsArgumentNullException()
    {
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };

        _ = new OrderBook(
            asks: null!,
            bids: bids
        );
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Constructor_WithoutBids_ThrowsArgumentNullException()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };

        _ = new OrderBook(
            asks: asks,
            bids: null!
        );
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_FromApiSample_SetsAllProperties()
    {
        var json = @"{
            ""id"": 98765,
            ""current"": 1710000000000,
            ""update"": 1710000000100,
            ""asks"": [[""50001.00"", ""0.1""], [""50002.00"", ""0.2""]],
            ""bids"": [[""49999.00"", ""0.3""], [""49998.00"", ""0.4""]]
        }";
        var orderBook = JsonConvert.DeserializeObject<OrderBook>(json, JsonSettings);

        Assert.IsNotNull(orderBook);
        Assert.AreEqual(98765L, orderBook.Id);
        Assert.AreEqual(1710000000000L, orderBook.Current);
        Assert.AreEqual(1710000000100L, orderBook.Update);
        Assert.AreEqual(2, orderBook.Asks.Count);
        Assert.AreEqual(2, orderBook.Bids.Count);
        Assert.AreEqual("50001.00", orderBook.Asks[0][0]);
        Assert.AreEqual("0.1", orderBook.Asks[0][1]);
        Assert.AreEqual("49999.00", orderBook.Bids[0][0]);
        Assert.AreEqual("0.3", orderBook.Bids[0][1]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonRoundTrip_PreservesValues()
    {
        var asks = new List<List<string>>
        {
            new() { "50001.00", "0.1" }
        };
        var bids = new List<List<string>>
        {
            new() { "49999.00", "0.3" }
        };
        var original = new OrderBook(
            id: 111L,
            current: 1710000000000L,
            update: 1710000000100L,
            asks: asks,
            bids: bids
        );

        var json = original.ToJson();
        var deserialized = JsonConvert.DeserializeObject<OrderBook>(json, JsonSettings);

        Assert.IsNotNull(deserialized);
        Assert.AreEqual(original.Id, deserialized.Id);
        Assert.AreEqual(original.Current, deserialized.Current);
        Assert.AreEqual(original.Update, deserialized.Update);
        Assert.AreEqual(original.Asks.Count, deserialized.Asks.Count);
        Assert.AreEqual(original.Bids.Count, deserialized.Bids.Count);
        Assert.AreEqual(original.Asks[0][0], deserialized.Asks[0][0]);
        Assert.AreEqual(original.Bids[0][0], deserialized.Bids[0][0]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void JsonDeserialization_EmptyOrderBook_SetsEmptyLists()
    {
        var json = @"{
            ""id"": 0,
            ""current"": 0,
            ""update"": 0,
            ""asks"": [],
            ""bids"": []
        }";
        var orderBook = JsonConvert.DeserializeObject<OrderBook>(json, JsonSettings);

        Assert.IsNotNull(orderBook);
        Assert.AreEqual(0, orderBook.Asks.Count);
        Assert.AreEqual(0, orderBook.Bids.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_SameValues_ReturnsTrue()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };

        var book1 = new OrderBook(id: 1L, current: 100L, update: 200L, asks: asks, bids: bids);
        var book2 = new OrderBook(id: 1L, current: 100L, update: 200L, asks: asks, bids: bids);

        Assert.IsTrue(book1.Equals(book2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_DifferentValues_ReturnsFalse()
    {
        var asks1 = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids1 = new List<List<string>> { new() { "49999.00", "0.3" } };
        var asks2 = new List<List<string>> { new() { "60001.00", "0.5" } };
        var bids2 = new List<List<string>> { new() { "59999.00", "0.6" } };

        var book1 = new OrderBook(id: 1L, asks: asks1, bids: bids1);
        var book2 = new OrderBook(id: 2L, asks: asks2, bids: bids2);

        Assert.IsFalse(book1.Equals(book2));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Equals_Null_ReturnsFalse()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };
        var book = new OrderBook(asks: asks, bids: bids);

        Assert.IsFalse(book.Equals((OrderBook?)null));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void GetHashCode_SameReference_ReturnsSameHash()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };
        var book = new OrderBook(id: 1L, current: 100L, update: 200L, asks: asks, bids: bids);

        var hash1 = book.GetHashCode();
        var hash2 = book.GetHashCode();

        Assert.AreEqual(hash1, hash2);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToJson_ReturnsValidJsonString()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };
        var book = new OrderBook(id: 1L, asks: asks, bids: bids);

        var json = book.ToJson();

        Assert.IsNotNull(json);
        Assert.IsFalse(string.IsNullOrWhiteSpace(json));

        var parsed = JsonConvert.DeserializeObject<OrderBook>(json, JsonSettings);
        Assert.IsNotNull(parsed);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ToString_ContainsClassName()
    {
        var asks = new List<List<string>> { new() { "50001.00", "0.1" } };
        var bids = new List<List<string>> { new() { "49999.00", "0.3" } };
        var book = new OrderBook(asks: asks, bids: bids);

        var result = book.ToString();

        Assert.IsTrue(result.Contains("class OrderBook"));
    }
}
