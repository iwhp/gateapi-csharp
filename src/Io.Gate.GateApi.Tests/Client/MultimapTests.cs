using Io.Gate.GateApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.Gate.GateApi.Tests.Client;

[TestClass]
public class MultimapTests
{
    #region Constructor

    [TestMethod]
    [TestCategory("Unit")]
    public void DefaultConstructor_CreatesEmptyMultimap()
    {
        var multimap = new Multimap<string, string>();

        Assert.AreEqual(0, multimap.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithComparer_CreatesEmptyMultimap()
    {
        var multimap = new Multimap<string, string>(StringComparer.OrdinalIgnoreCase);

        Assert.AreEqual(0, multimap.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_WithComparer_UsesCaseInsensitiveKeys()
    {
        var multimap = new Multimap<string, string>(StringComparer.OrdinalIgnoreCase);
        multimap.Add("Key", "value1");

        Assert.IsTrue(multimap.ContainsKey("key"));
        Assert.IsTrue(multimap.ContainsKey("KEY"));
    }

    #endregion Constructor

    #region Add Single Value

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_SingleValue_CreatesNewEntry()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", "value");

        Assert.IsTrue(multimap.ContainsKey("key"));
        Assert.AreEqual(1, multimap["key"].Count);
        Assert.AreEqual("value", multimap["key"][0]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_MultipleValuesToSameKey_AppendsToList()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", "value1");
        multimap.Add("key", "value2");

        Assert.AreEqual(1, multimap.Count); // Still one key
        Assert.AreEqual(2, multimap["key"].Count);
        Assert.AreEqual("value1", multimap["key"][0]);
        Assert.AreEqual("value2", multimap["key"][1]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_NullValue_IsIgnored()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", (string)null!);

        Assert.IsFalse(multimap.ContainsKey("key"));
    }

    #endregion Add Single Value

    #region Add List of Values

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_ListOfValues_CreatesNewEntry()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", new List<string> { "a", "b", "c" });

        Assert.IsTrue(multimap.ContainsKey("key"));
        Assert.AreEqual(3, multimap["key"].Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_ListOfValues_AppendsToExistingKey()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key", "existing");

        multimap.Add("key", new List<string> { "new1", "new2" });

        Assert.AreEqual(3, multimap["key"].Count);
        Assert.AreEqual("existing", multimap["key"][0]);
        Assert.AreEqual("new1", multimap["key"][1]);
        Assert.AreEqual("new2", multimap["key"][2]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_NullList_IsIgnored()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", (IList<string>)null!);

        Assert.IsFalse(multimap.ContainsKey("key"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_EmptyList_IsIgnored()
    {
        var multimap = new Multimap<string, string>();

        multimap.Add("key", new List<string>());

        Assert.IsFalse(multimap.ContainsKey("key"));
    }

    #endregion Add List of Values

    #region Add KeyValuePair

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_KeyValuePair_CreatesEntry()
    {
        var multimap = new Multimap<string, string>();
        var kvp = new KeyValuePair<string, IList<string>>("key", new List<string> { "value" });

        multimap.Add(kvp);

        Assert.IsTrue(multimap.ContainsKey("key"));
        Assert.AreEqual("value", multimap["key"][0]);
    }

    #endregion Add KeyValuePair

    #region Add Multimap

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_Multimap_MergesEntries()
    {
        var multimap1 = new Multimap<string, string>();
        multimap1.Add("key1", "value1");

        var multimap2 = new Multimap<string, string>();
        multimap2.Add("key2", "value2");

        multimap1.Add(multimap2);

        Assert.IsTrue(multimap1.ContainsKey("key1"));
        Assert.IsTrue(multimap1.ContainsKey("key2"));
    }

    #endregion Add Multimap

    #region ContainsKey

    [TestMethod]
    [TestCategory("Unit")]
    public void ContainsKey_ExistingKey_ReturnsTrue()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("exists", "value");

        Assert.IsTrue(multimap.ContainsKey("exists"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void ContainsKey_NonExistingKey_ReturnsFalse()
    {
        var multimap = new Multimap<string, string>();

        Assert.IsFalse(multimap.ContainsKey("missing"));
    }

    #endregion ContainsKey

    #region Remove

    [TestMethod]
    [TestCategory("Unit")]
    public void Remove_ExistingKey_RemovesEntry()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key", "value");

        var removed = multimap.Remove("key");

        Assert.IsTrue(removed);
        Assert.IsFalse(multimap.ContainsKey("key"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Remove_NonExistingKey_ReturnsFalse()
    {
        var multimap = new Multimap<string, string>();

        var removed = multimap.Remove("nonexistent");

        Assert.IsFalse(removed);
    }

    #endregion Remove

    #region TryGetValue

    [TestMethod]
    [TestCategory("Unit")]
    public void TryGetValue_ExistingKey_ReturnsTrue()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key", "value");

        var found = multimap.TryGetValue("key", out var values);

        Assert.IsTrue(found);
        Assert.IsNotNull(values);
        Assert.AreEqual("value", values[0]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void TryGetValue_NonExistingKey_ReturnsFalse()
    {
        var multimap = new Multimap<string, string>();

        var found = multimap.TryGetValue("missing", out var values);

        Assert.IsFalse(found);
        Assert.IsNull(values);
    }

    #endregion TryGetValue

    #region Indexer

    [TestMethod]
    [TestCategory("Unit")]
    public void Indexer_Get_ReturnsValues()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key", "value1");
        multimap.Add("key", "value2");

        var values = multimap["key"];

        Assert.AreEqual(2, values.Count);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Indexer_Set_ReplacesValues()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key", "old");

        multimap["key"] = new List<string> { "new1", "new2" };

        Assert.AreEqual(2, multimap["key"].Count);
        Assert.AreEqual("new1", multimap["key"][0]);
        Assert.AreEqual("new2", multimap["key"][1]);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void Indexer_Get_NonExistingKey_ThrowsKeyNotFoundException()
    {
        var multimap = new Multimap<string, string>();

        _ = multimap["nonexistent"];
    }

    #endregion Indexer

    #region Count

    [TestMethod]
    [TestCategory("Unit")]
    public void Count_ReturnsNumberOfKeys()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key1", "value1");
        multimap.Add("key2", "value2");
        multimap.Add("key1", "value3"); // Same key, different value

        Assert.AreEqual(2, multimap.Count);
    }

    #endregion Count

    #region Clear

    [TestMethod]
    [TestCategory("Unit")]
    public void Clear_RemovesAllEntries()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key1", "value1");
        multimap.Add("key2", "value2");

        multimap.Clear();

        Assert.AreEqual(0, multimap.Count);
        Assert.IsFalse(multimap.ContainsKey("key1"));
        Assert.IsFalse(multimap.ContainsKey("key2"));
    }

    #endregion Clear

    #region IsReadOnly

    [TestMethod]
    [TestCategory("Unit")]
    public void IsReadOnly_ReturnsFalse()
    {
        var multimap = new Multimap<string, string>();

        Assert.IsFalse(multimap.IsReadOnly);
    }

    #endregion IsReadOnly

    #region Keys and Values

    [TestMethod]
    [TestCategory("Unit")]
    public void Keys_ReturnsAllKeys()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("alpha", "1");
        multimap.Add("beta", "2");

        var keys = multimap.Keys;

        Assert.AreEqual(2, keys.Count);
        Assert.IsTrue(keys.Contains("alpha"));
        Assert.IsTrue(keys.Contains("beta"));
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Values_ReturnsAllValueLists()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key1", "a");
        multimap.Add("key2", "b");

        var values = multimap.Values;

        Assert.AreEqual(2, values.Count);
    }

    #endregion Keys and Values

    #region NotImplemented Methods

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(NotImplementedException))]
    public void Contains_ThrowsNotImplementedException()
    {
        var multimap = new Multimap<string, string>();
        var kvp = new KeyValuePair<string, IList<string>>("key", new List<string> { "value" });

        multimap.Contains(kvp);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(NotImplementedException))]
    public void Remove_KeyValuePair_ThrowsNotImplementedException()
    {
        var multimap = new Multimap<string, string>();
        var kvp = new KeyValuePair<string, IList<string>>("key", new List<string> { "value" });

        multimap.Remove(kvp);
    }

    [TestMethod]
    [TestCategory("Unit")]
    [ExpectedException(typeof(NotImplementedException))]
    public void CopyTo_KeyValuePairArray_ThrowsNotImplementedException()
    {
        var multimap = new Multimap<string, string>();
        var array = new KeyValuePair<string, IList<string>>[1];

        multimap.CopyTo(array, 0);
    }

    #endregion NotImplemented Methods

    #region Enumeration

    [TestMethod]
    [TestCategory("Unit")]
    public void GetEnumerator_IteratesAllKeys()
    {
        var multimap = new Multimap<string, string>();
        multimap.Add("key1", "value1");
        multimap.Add("key2", "value2");

        var count = 0;
        foreach (var kvp in multimap)
        {
            count++;
        }

        Assert.AreEqual(2, count);
    }

    #endregion Enumeration
}
