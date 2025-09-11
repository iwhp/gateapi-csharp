# Io.Gate.GateApi.Api.SpotApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCurrencies**](SpotApi.md#listcurrencies) | **GET** /spot/currencies | Query all currency information
[**GetCurrency**](SpotApi.md#getcurrency) | **GET** /spot/currencies/{currency} | Query single currency information
[**ListCurrencyPairs**](SpotApi.md#listcurrencypairs) | **GET** /spot/currency_pairs | Query all supported currency pairs
[**GetCurrencyPair**](SpotApi.md#getcurrencypair) | **GET** /spot/currency_pairs/{currency_pair} | Query single currency pair details
[**ListTickers**](SpotApi.md#listtickers) | **GET** /spot/tickers | Get currency pair ticker information
[**ListOrderBook**](SpotApi.md#listorderbook) | **GET** /spot/order_book | Get market depth information
[**ListTrades**](SpotApi.md#listtrades) | **GET** /spot/trades | Query market transaction records
[**ListCandlesticks**](SpotApi.md#listcandlesticks) | **GET** /spot/candlesticks | Market K-line chart
[**GetFee**](SpotApi.md#getfee) | **GET** /spot/fee | Query account fee rates
[**GetBatchSpotFee**](SpotApi.md#getbatchspotfee) | **GET** /spot/batch_fee | Batch query account fee rates
[**ListSpotAccounts**](SpotApi.md#listspotaccounts) | **GET** /spot/accounts | List spot trading accounts
[**ListSpotAccountBook**](SpotApi.md#listspotaccountbook) | **GET** /spot/account_book | Query spot account transaction history
[**CreateBatchOrders**](SpotApi.md#createbatchorders) | **POST** /spot/batch_orders | Batch place orders
[**ListAllOpenOrders**](SpotApi.md#listallopenorders) | **GET** /spot/open_orders | List all open orders
[**CreateCrossLiquidateOrder**](SpotApi.md#createcrossliquidateorder) | **POST** /spot/cross_liquidate_orders | Close position when cross-currency is disabled
[**ListOrders**](SpotApi.md#listorders) | **GET** /spot/orders | List orders
[**CreateOrder**](SpotApi.md#createorder) | **POST** /spot/orders | Create an order
[**CancelOrders**](SpotApi.md#cancelorders) | **DELETE** /spot/orders | Cancel all &#x60;open&#x60; orders in specified currency pair
[**CancelBatchOrders**](SpotApi.md#cancelbatchorders) | **POST** /spot/cancel_batch_orders | Cancel batch orders by specified ID list
[**GetOrder**](SpotApi.md#getorder) | **GET** /spot/orders/{order_id} | Query single order details
[**CancelOrder**](SpotApi.md#cancelorder) | **DELETE** /spot/orders/{order_id} | Cancel single order
[**AmendOrder**](SpotApi.md#amendorder) | **PATCH** /spot/orders/{order_id} | Amend single order
[**ListMyTrades**](SpotApi.md#listmytrades) | **GET** /spot/my_trades | Query personal trading records
[**GetSystemTime**](SpotApi.md#getsystemtime) | **GET** /spot/time | Get server current time
[**CountdownCancelAllSpot**](SpotApi.md#countdowncancelallspot) | **POST** /spot/countdown_cancel_all | Countdown cancel orders
[**AmendBatchOrders**](SpotApi.md#amendbatchorders) | **POST** /spot/amend_batch_orders | Batch modification of orders
[**GetSpotInsuranceHistory**](SpotApi.md#getspotinsurancehistory) | **GET** /spot/insurance_history | Query spot insurance fund historical data
[**ListSpotPriceTriggeredOrders**](SpotApi.md#listspotpricetriggeredorders) | **GET** /spot/price_orders | Query running auto order list
[**CreateSpotPriceTriggeredOrder**](SpotApi.md#createspotpricetriggeredorder) | **POST** /spot/price_orders | Create price-triggered order
[**CancelSpotPriceTriggeredOrderList**](SpotApi.md#cancelspotpricetriggeredorderlist) | **DELETE** /spot/price_orders | Cancel all auto orders
[**GetSpotPriceTriggeredOrder**](SpotApi.md#getspotpricetriggeredorder) | **GET** /spot/price_orders/{order_id} | Query single auto order details
[**CancelSpotPriceTriggeredOrder**](SpotApi.md#cancelspotpricetriggeredorder) | **DELETE** /spot/price_orders/{order_id} | Cancel single auto order


<a name="listcurrencies"></a>
# **ListCurrencies**
> List&lt;Currency&gt; ListCurrencies ()

Query all currency information

When a currency corresponds to multiple chains, you can query the information of multiple chains through the `chains` field, such as the charging and recharge status, identification, etc. of the chain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // Query all currency information
                List<Currency> result = apiInstance.ListCurrencies();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCurrencies: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Currency&gt;**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrency"></a>
# **GetCurrency**
> Currency GetCurrency (string currency)

Query single currency information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCurrencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currency = "GT";  // string | Currency name

            try
            {
                // Query single currency information
                Currency result = apiInstance.GetCurrency(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetCurrency: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency name | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcurrencypairs"></a>
# **ListCurrencyPairs**
> List&lt;CurrencyPair&gt; ListCurrencyPairs ()

Query all supported currency pairs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyPairsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // Query all supported currency pairs
                List<CurrencyPair> result = apiInstance.ListCurrencyPairs();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCurrencyPairs: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;CurrencyPair&gt;**](CurrencyPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All currency pairs retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencypair"></a>
# **GetCurrencyPair**
> CurrencyPair GetCurrencyPair (string currencyPair)

Query single currency pair details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCurrencyPairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "ETH_BTC";  // string | Currency pair

            try
            {
                // Query single currency pair details
                CurrencyPair result = apiInstance.GetCurrencyPair(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetCurrencyPair: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | 

### Return type

[**CurrencyPair**](CurrencyPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtickers"></a>
# **ListTickers**
> List&lt;Ticker&gt; ListTickers (string currencyPair = null, string timezone = null)

Get currency pair ticker information

If `currency_pair` is specified, only query that currency pair; otherwise return all information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var timezone = "utc0";  // string | Timezone (optional) 

            try
            {
                // Get currency pair ticker information
                List<Ticker> result = apiInstance.ListTickers(currencyPair, timezone);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListTickers: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | [optional] 
 **timezone** | **string**| Timezone | [optional] 

### Return type

[**List&lt;Ticker&gt;**](Ticker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorderbook"></a>
# **ListOrderBook**
> OrderBook ListOrderBook (string currencyPair, string interval = null, int? limit = null, bool? withId = null)

Get market depth information

Market depth buy orders are sorted by price from high to low, sell orders are sorted from low to high

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var interval = "\"0\"";  // string | Price precision for depth aggregation, 0 means no aggregation, defaults to 0 if not specified (optional)  (default to "0")
            var limit = 10;  // int? | Number of depth levels (optional)  (default to 10)
            var withId = false;  // bool? | Return order book update ID (optional)  (default to false)

            try
            {
                // Get market depth information
                OrderBook result = apiInstance.ListOrderBook(currencyPair, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListOrderBook: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | 
 **interval** | **string**| Price precision for depth aggregation, 0 means no aggregation, defaults to 0 if not specified | [optional] [default to &quot;0&quot;]
 **limit** | **int?**| Number of depth levels | [optional] [default to 10]
 **withId** | **bool?**| Return order book update ID | [optional] [default to false]

### Return type

[**OrderBook**](OrderBook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtrades"></a>
# **ListTrades**
> List&lt;Trade&gt; ListTrades (string currencyPair, int? limit = null, string lastId = null, bool? reverse = null, long? from = null, long? to = null, int? page = null)

Query market transaction records

Supports querying by time range using `from` and `to` parameters or pagination based on `last_id`. By default, queries the last 30 days.  Pagination based on `last_id` is no longer recommended. If `last_id` is specified, the time range query parameters will be ignored.  When using limit&page pagination to retrieve data, the maximum number of pages is 100,000, that is, limit * (page - 1) <= 100,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var limit = 100;  // int? | Maximum number of items returned in list. Default: 100, minimum: 1, maximum: 1000 (optional)  (default to 100)
            var lastId = "12345";  // string | Use the ID of the last record in the previous list as the starting point for the next list  Operations based on custom IDs can only be checked when orders are pending. After orders are completed (filled/cancelled), they can be checked within 1 hour after completion. After expiration, only order IDs can be used (optional) 
            var reverse = false;  // bool? | Whether to retrieve data less than `last_id`. Default returns records greater than `last_id`.  Set to `true` to trace back market trade records, `false` to get latest trades.  No effect when `last_id` is not set. (optional)  (default to false)
            var from = 1627706330;  // long? | Start timestamp for the query (optional) 
            var to = 1635329650;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query market transaction records
                List<Trade> result = apiInstance.ListTrades(currencyPair, limit, lastId, reverse, from, to, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListTrades: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | 
 **limit** | **int?**| Maximum number of items returned in list. Default: 100, minimum: 1, maximum: 1000 | [optional] [default to 100]
 **lastId** | **string**| Use the ID of the last record in the previous list as the starting point for the next list  Operations based on custom IDs can only be checked when orders are pending. After orders are completed (filled/cancelled), they can be checked within 1 hour after completion. After expiration, only order IDs can be used | [optional] 
 **reverse** | **bool?**| Whether to retrieve data less than &#x60;last_id&#x60;. Default returns records greater than &#x60;last_id&#x60;.  Set to &#x60;true&#x60; to trace back market trade records, &#x60;false&#x60; to get latest trades.  No effect when &#x60;last_id&#x60; is not set. | [optional] [default to false]
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Trade&gt;**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcandlesticks"></a>
# **ListCandlesticks**
> List&lt;List&lt;string&gt;&gt; ListCandlesticks (string currencyPair, int? limit = null, long? from = null, long? to = null, string interval = null)

Market K-line chart

Maximum of 1000 points can be returned in a query. Be sure not to exceed the limit when specifying from, to and interval

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var limit = 100;  // int? | Maximum number of recent data points to return. `limit` conflicts with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision (optional) 
            var interval = "30m";  // string | Time interval between data points. Note that `30d` represents a calendar month, not aligned to 30 days (optional)  (default to 30m)

            try
            {
                // Market K-line chart
                List<List<string>> result = apiInstance.ListCandlesticks(currencyPair, limit, from, to, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCandlesticks: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | 
 **limit** | **int?**| Maximum number of recent data points to return. &#x60;limit&#x60; conflicts with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision | [optional] 
 **interval** | **string**| Time interval between data points. Note that &#x60;30d&#x60; represents a calendar month, not aligned to 30 days | [optional] [default to 30m]

### Return type

**List<List<string>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfee"></a>
# **GetFee**
> SpotFee GetFee (string currencyPair = null)

Query account fee rates

This API is deprecated. The new fee query API is `/wallet/fee`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify currency pair to get more accurate fee settings.  This field is optional. Usually fee settings are the same for all currency pairs. (optional) 

            try
            {
                // Query account fee rates
                SpotFee result = apiInstance.GetFee(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetFee: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Specify currency pair to get more accurate fee settings.  This field is optional. Usually fee settings are the same for all currency pairs. | [optional] 

### Return type

[**SpotFee**](SpotFee.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchspotfee"></a>
# **GetBatchSpotFee**
> Dictionary&lt;string, SpotFee&gt; GetBatchSpotFee (string currencyPairs)

Batch query account fee rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetBatchSpotFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPairs = "BTC_USDT,ETH_USDT";  // string | Maximum 50 currency pairs per request

            try
            {
                // Batch query account fee rates
                Dictionary<string, SpotFee> result = apiInstance.GetBatchSpotFee(currencyPairs);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetBatchSpotFee: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPairs** | **string**| Maximum 50 currency pairs per request | 

### Return type

[**Dictionary&lt;string, SpotFee&gt;**](SpotFee.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspotaccounts"></a>
# **ListSpotAccounts**
> List&lt;SpotAccount&gt; ListSpotAccounts (string currency = null)

List spot trading accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 

            try
            {
                // List spot trading accounts
                List<SpotAccount> result = apiInstance.ListSpotAccounts(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotAccounts: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Query by specified currency name | [optional] 

### Return type

[**List&lt;SpotAccount&gt;**](SpotAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspotaccountbook"></a>
# **ListSpotAccountBook**
> List&lt;SpotAccountBook&gt; ListSpotAccountBook (string currency = null, long? from = null, long? to = null, int? page = null, int? limit = null, string type = null, string code = null)

Query spot account transaction history

Record query time range cannot exceed 30 days.  When using limit&page pagination to retrieve data, the maximum number of pages is 100,000, that is, limit * (page - 1) <= 100,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var from = 1627706330;  // long? | Start timestamp for the query (optional) 
            var to = 1635329650;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var type = "lend";  // string | Query by specified account change type. If not specified, all change types will be included. (optional) 
            var code = "code_example";  // string | Specify account change code for query. If not specified, all change types are included. This parameter has higher priority than `type` (optional) 

            try
            {
                // Query spot account transaction history
                List<SpotAccountBook> result = apiInstance.ListSpotAccountBook(currency, from, to, page, limit, type, code);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotAccountBook: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Query by specified currency name | [optional] 
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **type** | **string**| Query by specified account change type. If not specified, all change types will be included. | [optional] 
 **code** | **string**| Specify account change code for query. If not specified, all change types are included. This parameter has higher priority than &#x60;type&#x60; | [optional] 

### Return type

[**List&lt;SpotAccountBook&gt;**](SpotAccountBook.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbatchorders"></a>
# **CreateBatchOrders**
> List&lt;BatchOrder&gt; CreateBatchOrders (List<Order> order, string xGateExptime = null)

Batch place orders

Batch order requirements:  1. Custom order field `text` must be specified 2. Up to 4 currency pairs per request, with up to 10 orders per currency pair 3. Spot orders and margin orders cannot be mixed; all `account` fields in the same request must be identical

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var order = new List<Order>(); // List<Order> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Batch place orders
                List<BatchOrder> result = apiInstance.CreateBatchOrders(order, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateBatchOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**List&lt;Order&gt;**](Order.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchOrder&gt;**](BatchOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request execution completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallopenorders"></a>
# **ListAllOpenOrders**
> List&lt;OpenOrders&gt; ListAllOpenOrders (int? page = null, int? limit = null, string account = null)

List all open orders

Query the current order list of all trading pairs. Please note that the paging parameter controls the number of pending orders in each trading pair. There is no paging control trading pairs. All trading pairs with pending orders will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAllOpenOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records returned in one page in each currency pair (optional)  (default to 100)
            var account = "spot";  // string | Specify query account (optional) 

            try
            {
                // List all open orders
                List<OpenOrders> result = apiInstance.ListAllOpenOrders(page, limit, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListAllOpenOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records returned in one page in each currency pair | [optional] [default to 100]
 **account** | **string**| Specify query account | [optional] 

### Return type

[**List&lt;OpenOrders&gt;**](OpenOrders.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcrossliquidateorder"></a>
# **CreateCrossLiquidateOrder**
> Order CreateCrossLiquidateOrder (LiquidateOrder liquidateOrder)

Close position when cross-currency is disabled

Currently, only cross-margin accounts are supported to place buy orders for disabled currencies. Maximum buy quantity = (unpaid principal and interest - currency balance - the amount of the currency in pending orders) / 0.998

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateCrossLiquidateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var liquidateOrder = new LiquidateOrder(); // LiquidateOrder | 

            try
            {
                // Close position when cross-currency is disabled
                Order result = apiInstance.CreateCrossLiquidateOrder(liquidateOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateCrossLiquidateOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liquidateOrder** | [**LiquidateOrder**](LiquidateOrder.md)|  | 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorders"></a>
# **ListOrders**
> List&lt;Order&gt; ListOrders (string currencyPair, string status, int? page = null, int? limit = null, string account = null, long? from = null, long? to = null, string side = null)

List orders

Note that query results default to spot order lists for spot, unified account, and isolated margin accounts.  When `status` is set to `open` (i.e., when querying pending order lists), only `page` and `limit` pagination controls are supported. `limit` can only be set to a maximum of 100. The `side` parameter and time range query parameters `from` and `to` are not supported.  When `status` is set to `finished` (i.e., when querying historical orders), in addition to pagination queries, `from` and `to` time range queries are also supported. Additionally, the `side` parameter can be set to filter one-sided history.  Time range filter parameters are processed according to the order end time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Query by specified currency pair. Required for open orders, optional for filled orders
            var status = "open";  // string | List orders based on status  `open` - order is waiting to be filled `finished` - order has been filled or cancelled 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned. If `status` is `open`, maximum of `limit` is 100 (optional)  (default to 100)
            var account = "spot";  // string | Specify query account (optional) 
            var from = 1627706330;  // long? | Start timestamp for the query (optional) 
            var to = 1635329650;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var side = "sell";  // string | Specify all bids or all asks, both included if not specified (optional) 

            try
            {
                // List orders
                List<Order> result = apiInstance.ListOrders(currencyPair, status, page, limit, account, from, to, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Query by specified currency pair. Required for open orders, optional for filled orders | 
 **status** | **string**| List orders based on status  &#x60;open&#x60; - order is waiting to be filled &#x60;finished&#x60; - order has been filled or cancelled  | 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned. If &#x60;status&#x60; is &#x60;open&#x60;, maximum of &#x60;limit&#x60; is 100 | [optional] [default to 100]
 **account** | **string**| Specify query account | [optional] 
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **side** | **string**| Specify all bids or all asks, both included if not specified | [optional] 

### Return type

[**List&lt;Order&gt;**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorder"></a>
# **CreateOrder**
> Order CreateOrder (Order order, string xGateExptime = null)

Create an order

Supports spot, margin, leverage, and cross-margin leverage orders. Use different accounts through the `account` field. Default is `spot`, which means using the spot account to place orders. If the user has a `unified` account, the default is to place orders with the unified account.  When using leveraged account trading (i.e., when `account` is set to `margin`), you can set `auto_borrow` to `true`. In case of insufficient account balance, the system will automatically execute `POST /margin/uni/loans` to borrow the insufficient amount. Whether assets obtained after leveraged order execution are automatically used to repay borrowing orders of the isolated margin account depends on the automatic repayment settings of the user's isolated margin account. Account automatic repayment settings can be queried and set through `/margin/auto_repay`.  When using unified account trading (i.e., when `account` is set to `unified`), `auto_borrow` can also be enabled to realize automatic borrowing of insufficient amounts. However, unlike the isolated margin account, whether unified account orders are automatically repaid depends on the `auto_repay` setting when placing the order. This setting only applies to the current order, meaning only assets obtained after order execution will be used to repay borrowing orders of the cross-margin account. Unified account ordering currently supports enabling both `auto_borrow` and `auto_repay` simultaneously.  Auto repayment will be triggered when the order ends, i.e., when `status` is `cancelled` or `closed`.  **Order Status**  The order status in pending orders is `open`, which remains `open` until all quantity is filled. If fully filled, the order ends and status becomes `closed`. If the order is cancelled before all transactions are completed, regardless of partial fills, the status will become `cancelled`.  **Iceberg Orders**  `iceberg` is used to set the displayed quantity of iceberg orders and does not support complete hiding. Note that hidden portions are charged according to the taker's fee rate.  **Self-Trade Prevention**  Set `stp_act` to determine the self-trade prevention strategy to use

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var order = new Order(); // Order | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Create an order
                Order result = apiInstance.CreateOrder(order, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorders"></a>
# **CancelOrders**
> List&lt;OrderCancel&gt; CancelOrders (string currencyPair = null, string side = null, string account = null, string actionMode = null, string xGateExptime = null)

Cancel all `open` orders in specified currency pair

When the `account` parameter is not specified, all pending orders including spot, unified account, and isolated margin will be cancelled. When `currency_pair` is not specified, all trading pair pending orders will be cancelled. You can specify a particular account to cancel all pending orders under that account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var side = "sell";  // string | Specify all bids or all asks, both included if not specified (optional) 
            var account = "spot";  // string | Specify account type  Classic account: All are included if not specified Unified account: Specify `unified` (optional) 
            var actionMode = "ACK";  // string | Processing Mode  When placing an order, different fields are returned based on the action_mode  - `ACK`: Asynchronous mode, returns only key order fields - `RESULT`: No clearing information - `FULL`: Full mode (default) (optional) 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel all `open` orders in specified currency pair
                List<OrderCancel> result = apiInstance.CancelOrders(currencyPair, side, account, actionMode, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Currency pair | [optional] 
 **side** | **string**| Specify all bids or all asks, both included if not specified | [optional] 
 **account** | **string**| Specify account type  Classic account: All are included if not specified Unified account: Specify &#x60;unified&#x60; | [optional] 
 **actionMode** | **string**| Processing Mode  When placing an order, different fields are returned based on the action_mode  - &#x60;ACK&#x60;: Asynchronous mode, returns only key order fields - &#x60;RESULT&#x60;: No clearing information - &#x60;FULL&#x60;: Full mode (default) | [optional] 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;OrderCancel&gt;**](OrderCancel.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation request accepted and processed, success determined by order list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbatchorders"></a>
# **CancelBatchOrders**
> List&lt;CancelOrderResult&gt; CancelBatchOrders (List<CancelBatchOrder> cancelBatchOrder, string xGateExptime = null)

Cancel batch orders by specified ID list

Multiple currency pairs can be specified, but maximum 20 orders are allowed per request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var cancelBatchOrder = new List<CancelBatchOrder>(); // List<CancelBatchOrder> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel batch orders by specified ID list
                List<CancelOrderResult> result = apiInstance.CancelBatchOrders(cancelBatchOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelBatchOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cancelBatchOrder** | [**List&lt;CancelBatchOrder&gt;**](CancelBatchOrder.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;CancelOrderResult&gt;**](CancelOrderResult.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string orderId, string currencyPair, string account = null)

Query single order details

By default, queries orders for spot, unified account, and isolated margin accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var currencyPair = "BTC_USDT";  // string | Specify the trading pair to query. This field is required when querying pending order records. This field can be omitted when querying filled order records.
            var account = "spot";  // string | Specify query account (optional) 

            try
            {
                // Query single order details
                Order result = apiInstance.GetOrder(orderId, currencyPair, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **currencyPair** | **string**| Specify the trading pair to query. This field is required when querying pending order records. This field can be omitted when querying filled order records. | 
 **account** | **string**| Specify query account | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detail retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorder"></a>
# **CancelOrder**
> Order CancelOrder (string orderId, string currencyPair, string account = null, string actionMode = null, string xGateExptime = null)

Cancel single order

By default, orders for spot, unified accounts and leveraged accounts are revoked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var account = "spot";  // string | Specify query account (optional) 
            var actionMode = "ACK";  // string | Processing Mode  When placing an order, different fields are returned based on the action_mode  - `ACK`: Asynchronous mode, returns only key order fields - `RESULT`: No clearing information - `FULL`: Full mode (default) (optional) 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel single order
                Order result = apiInstance.CancelOrder(orderId, currencyPair, account, actionMode, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **currencyPair** | **string**| Currency pair | 
 **account** | **string**| Specify query account | [optional] 
 **actionMode** | **string**| Processing Mode  When placing an order, different fields are returned based on the action_mode  - &#x60;ACK&#x60;: Asynchronous mode, returns only key order fields - &#x60;RESULT&#x60;: No clearing information - &#x60;FULL&#x60;: Full mode (default) | [optional] 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancelled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendorder"></a>
# **AmendOrder**
> Order AmendOrder (string orderId, OrderPatch orderPatch, string currencyPair = null, string account = null, string xGateExptime = null)

Amend single order

Modify orders in spot, unified account and isolated margin account by default.  Currently both request body and query support currency_pair and account parameters, but request body has higher priority.  currency_pair must be filled in one of the request body or query parameters.  About rate limit: Order modification and order creation share the same rate limit rules.  About matching priority: Only reducing the quantity does not affect the matching priority. Modifying the price or increasing the quantity will adjust the priority to the end of the new price level.  Note: Modifying the quantity to be less than the filled quantity will trigger a cancellation and isolated margin account by default.  Currently both request body and query support currency_pair and account parameters, but request body has higher priority.  currency_pair must be filled in one of the request body or query parameters.  About rate limit: Order modification and order creation share the same rate limit rules.  About matching priority: Only reducing the quantity does not affect the matching priority. Modifying the price or increasing the quantity will adjust the priority to the end of the new price level.  Note: Modifying the quantity to be less than the filled quantity will trigger a cancellation operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var orderPatch = new OrderPatch(); // OrderPatch | 
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var account = "spot";  // string | Specify query account (optional) 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Amend single order
                Order result = apiInstance.AmendOrder(orderId, orderPatch, currencyPair, account, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.AmendOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **orderPatch** | [**OrderPatch**](OrderPatch.md)|  | 
 **currencyPair** | **string**| Currency pair | [optional] 
 **account** | **string**| Specify query account | [optional] 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmytrades"></a>
# **ListMyTrades**
> List&lt;Trade&gt; ListMyTrades (string currencyPair = null, int? limit = null, int? page = null, string orderId = null, string account = null, long? from = null, long? to = null)

Query personal trading records

By default query of transaction records for spot, unified account and warehouse-by-site leverage accounts.  The history within a specified time range can be queried by specifying `from` or (and) `to`.  - If no time parameters are specified, only data for the last 7 days can be obtained. - If only any parameter of `from` or `to` is specified, only 7-day data from the start (or end) of the specified time is returned. - The range not allowed to exceed 30 days.  The parameters of the time range filter are processed according to the order end time.  The maximum number of pages when searching data using limit&page paging function is 100,0, that is, limit * (page - 1) <= 100,0.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMyTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Retrieve results with specified currency pair (optional) 
            var limit = 100;  // int? | Maximum number of items returned in list. Default: 100, minimum: 1, maximum: 1000 (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var orderId = "12345";  // string | Filter trades with specified order ID. `currency_pair` is also required if this field is present (optional) 
            var account = "spot";  // string | Specify query account (optional) 
            var from = 1627706330;  // long? | Start timestamp for the query (optional) 
            var to = 1635329650;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 

            try
            {
                // Query personal trading records
                List<Trade> result = apiInstance.ListMyTrades(currencyPair, limit, page, orderId, account, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListMyTrades: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Retrieve results with specified currency pair | [optional] 
 **limit** | **int?**| Maximum number of items returned in list. Default: 100, minimum: 1, maximum: 1000 | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]
 **orderId** | **string**| Filter trades with specified order ID. &#x60;currency_pair&#x60; is also required if this field is present | [optional] 
 **account** | **string**| Specify query account | [optional] 
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 

### Return type

[**List&lt;Trade&gt;**](Trade.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemtime"></a>
# **GetSystemTime**
> SystemTime GetSystemTime ()

Get server current time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSystemTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // Get server current time
                SystemTime result = apiInstance.GetSystemTime();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSystemTime: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SystemTime**](SystemTime.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countdowncancelallspot"></a>
# **CountdownCancelAllSpot**
> TriggerTime CountdownCancelAllSpot (CountdownCancelAllSpotTask countdownCancelAllSpotTask)

Countdown cancel orders

Spot order heartbeat detection. If there is no \"cancel existing countdown\" or \"set new countdown\" when the user-set `timeout` time is reached, the related `spot pending orders` will be automatically cancelled. This interface can be called repeatedly to set a new countdown or cancel the countdown. Usage example: Repeat this interface at 30s intervals, setting the countdown `timeout` to `30 (seconds)` each time. If this interface is not called again within 30 seconds, all pending orders on the `market` you specified will be automatically cancelled. If no `market` is specified, all market cancelled. If the `timeout` is set to 0 within 30 seconds, the countdown timer will be terminated and the automatic order cancellation function will be cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CountdownCancelAllSpotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var countdownCancelAllSpotTask = new CountdownCancelAllSpotTask(); // CountdownCancelAllSpotTask | 

            try
            {
                // Countdown cancel orders
                TriggerTime result = apiInstance.CountdownCancelAllSpot(countdownCancelAllSpotTask);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CountdownCancelAllSpot: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countdownCancelAllSpotTask** | [**CountdownCancelAllSpotTask**](CountdownCancelAllSpotTask.md)|  | 

### Return type

[**TriggerTime**](TriggerTime.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Countdown set successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendbatchorders"></a>
# **AmendBatchOrders**
> List&lt;BatchOrder&gt; AmendBatchOrders (List<BatchAmendItem> batchAmendItem, string xGateExptime = null)

Batch modification of orders

Modify orders in spot, unified account and isolated margin account by default. Modify uncompleted orders, up to 5 orders can be modified at a time. Request parameters should be passed in array format. If there are order modification failures during the batch modification process, the modification of the next order will continue to be executed, and the execution will return with the corresponding order failure information. The call order of batch modification orders is consistent with the order list order. The return content order of batch modification orders is consistent with the order list order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var batchAmendItem = new List<BatchAmendItem>(); // List<BatchAmendItem> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Batch modification of orders
                List<BatchOrder> result = apiInstance.AmendBatchOrders(batchAmendItem, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.AmendBatchOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchAmendItem** | [**List&lt;BatchAmendItem&gt;**](BatchAmendItem.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchOrder&gt;**](BatchOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order modification executed successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspotinsurancehistory"></a>
# **GetSpotInsuranceHistory**
> List&lt;SpotInsuranceHistory&gt; GetSpotInsuranceHistory (string business, string currency, long from, long to, int? page = null, int? limit = null)

Query spot insurance fund historical data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSpotInsuranceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var business = "margin";  // string | Leverage business, margin - position by position; unified - unified account
            var currency = "BTC";  // string | Currency
            var from = 1547706332;  // long | Start timestamp in seconds
            var to = 1547706332;  // long | End timestamp in seconds
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 30;  // int? | The maximum number of items returned in the list, the default value is 30 (optional)  (default to 30)

            try
            {
                // Query spot insurance fund historical data
                List<SpotInsuranceHistory> result = apiInstance.GetSpotInsuranceHistory(business, currency, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSpotInsuranceHistory: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **business** | **string**| Leverage business, margin - position by position; unified - unified account | 
 **currency** | **string**| Currency | 
 **from** | **long**| Start timestamp in seconds | 
 **to** | **long**| End timestamp in seconds | 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| The maximum number of items returned in the list, the default value is 30 | [optional] [default to 30]

### Return type

[**List&lt;SpotInsuranceHistory&gt;**](SpotInsuranceHistory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspotpricetriggeredorders"></a>
# **ListSpotPriceTriggeredOrders**
> List&lt;SpotPriceTriggeredOrder&gt; ListSpotPriceTriggeredOrders (string status, string market = null, string account = null, int? limit = null, int? offset = null)

Query running auto order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotPriceTriggeredOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var status = "status_example";  // string | Query order list based on status
            var market = "BTC_USDT";  // string | Trading market (optional) 
            var account = "account_example";  // string | Trading account type. Unified account must be set to `unified` (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Query running auto order list
                List<SpotPriceTriggeredOrder> result = apiInstance.ListSpotPriceTriggeredOrders(status, market, account, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotPriceTriggeredOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Query order list based on status | 
 **market** | **string**| Trading market | [optional] 
 **account** | **string**| Trading account type. Unified account must be set to &#x60;unified&#x60; | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;SpotPriceTriggeredOrder&gt;**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createspotpricetriggeredorder"></a>
# **CreateSpotPriceTriggeredOrder**
> TriggerOrderResponse CreateSpotPriceTriggeredOrder (SpotPriceTriggeredOrder spotPriceTriggeredOrder)

Create price-triggered order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var spotPriceTriggeredOrder = new SpotPriceTriggeredOrder(); // SpotPriceTriggeredOrder | 

            try
            {
                // Create price-triggered order
                TriggerOrderResponse result = apiInstance.CreateSpotPriceTriggeredOrder(spotPriceTriggeredOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateSpotPriceTriggeredOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spotPriceTriggeredOrder** | [**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)|  | 

### Return type

[**TriggerOrderResponse**](TriggerOrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelspotpricetriggeredorderlist"></a>
# **CancelSpotPriceTriggeredOrderList**
> List&lt;SpotPriceTriggeredOrder&gt; CancelSpotPriceTriggeredOrderList (string market = null, string account = null)

Cancel all auto orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelSpotPriceTriggeredOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var market = "BTC_USDT";  // string | Trading market (optional) 
            var account = "account_example";  // string | Trading account type. Unified account must be set to `unified` (optional) 

            try
            {
                // Cancel all auto orders
                List<SpotPriceTriggeredOrder> result = apiInstance.CancelSpotPriceTriggeredOrderList(market, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelSpotPriceTriggeredOrderList: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Trading market | [optional] 
 **account** | **string**| Trading account type. Unified account must be set to &#x60;unified&#x60; | [optional] 

### Return type

[**List&lt;SpotPriceTriggeredOrder&gt;**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation request accepted and processed, success determined by order list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspotpricetriggeredorder"></a>
# **GetSpotPriceTriggeredOrder**
> SpotPriceTriggeredOrder GetSpotPriceTriggeredOrder (string orderId)

Query single auto order details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "orderId_example";  // string | ID returned when order is successfully created

            try
            {
                // Query single auto order details
                SpotPriceTriggeredOrder result = apiInstance.GetSpotPriceTriggeredOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSpotPriceTriggeredOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID returned when order is successfully created | 

### Return type

[**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelspotpricetriggeredorder"></a>
# **CancelSpotPriceTriggeredOrder**
> SpotPriceTriggeredOrder CancelSpotPriceTriggeredOrder (string orderId)

Cancel single auto order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "orderId_example";  // string | ID returned when order is successfully created

            try
            {
                // Cancel single auto order
                SpotPriceTriggeredOrder result = apiInstance.CancelSpotPriceTriggeredOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelSpotPriceTriggeredOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID returned when order is successfully created | 

### Return type

[**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

