# Io.Gate.GateApi.Api.FuturesApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListFuturesContracts**](FuturesApi.md#listfuturescontracts) | **GET** /futures/{settle}/contracts | Query all futures contracts
[**GetFuturesContract**](FuturesApi.md#getfuturescontract) | **GET** /futures/{settle}/contracts/{contract} | Query single contract information
[**ListFuturesOrderBook**](FuturesApi.md#listfuturesorderbook) | **GET** /futures/{settle}/order_book | Query futures market depth information
[**ListFuturesTrades**](FuturesApi.md#listfuturestrades) | **GET** /futures/{settle}/trades | Futures market transaction records
[**ListFuturesCandlesticks**](FuturesApi.md#listfuturescandlesticks) | **GET** /futures/{settle}/candlesticks | Futures market K-line chart
[**ListFuturesPremiumIndex**](FuturesApi.md#listfuturespremiumindex) | **GET** /futures/{settle}/premium_index | Premium Index K-line chart
[**ListFuturesTickers**](FuturesApi.md#listfuturestickers) | **GET** /futures/{settle}/tickers | Get all futures trading statistics
[**ListFuturesFundingRateHistory**](FuturesApi.md#listfuturesfundingratehistory) | **GET** /futures/{settle}/funding_rate | Futures market historical funding rate
[**ListFuturesInsuranceLedger**](FuturesApi.md#listfuturesinsuranceledger) | **GET** /futures/{settle}/insurance | Futures market insurance fund history
[**ListContractStats**](FuturesApi.md#listcontractstats) | **GET** /futures/{settle}/contract_stats | Futures statistics
[**GetIndexConstituents**](FuturesApi.md#getindexconstituents) | **GET** /futures/{settle}/index_constituents/{index} | Query index constituents
[**ListLiquidatedOrders**](FuturesApi.md#listliquidatedorders) | **GET** /futures/{settle}/liq_orders | Query liquidation order history
[**ListFuturesRiskLimitTiers**](FuturesApi.md#listfuturesrisklimittiers) | **GET** /futures/{settle}/risk_limit_tiers | Query risk limit tiers
[**ListFuturesAccounts**](FuturesApi.md#listfuturesaccounts) | **GET** /futures/{settle}/accounts | Get futures account
[**ListFuturesAccountBook**](FuturesApi.md#listfuturesaccountbook) | **GET** /futures/{settle}/account_book | Query futures account change history
[**ListPositions**](FuturesApi.md#listpositions) | **GET** /futures/{settle}/positions | Get user position list
[**GetPosition**](FuturesApi.md#getposition) | **GET** /futures/{settle}/positions/{contract} | Get single position information
[**UpdatePositionMargin**](FuturesApi.md#updatepositionmargin) | **POST** /futures/{settle}/positions/{contract}/margin | Update position margin
[**UpdatePositionLeverage**](FuturesApi.md#updatepositionleverage) | **POST** /futures/{settle}/positions/{contract}/leverage | Update position leverage
[**UpdatePositionCrossMode**](FuturesApi.md#updatepositioncrossmode) | **POST** /futures/{settle}/positions/cross_mode | Switch Position Margin Mode
[**UpdateDualCompPositionCrossMode**](FuturesApi.md#updatedualcomppositioncrossmode) | **POST** /futures/{settle}/dual_comp/positions/cross_mode | Switch Between Cross and Isolated Margin Modes Under Hedge Mode
[**UpdatePositionRiskLimit**](FuturesApi.md#updatepositionrisklimit) | **POST** /futures/{settle}/positions/{contract}/risk_limit | Update position risk limit
[**SetDualMode**](FuturesApi.md#setdualmode) | **POST** /futures/{settle}/dual_mode | Set position mode
[**GetDualModePosition**](FuturesApi.md#getdualmodeposition) | **GET** /futures/{settle}/dual_comp/positions/{contract} | Get position information in dual mode
[**UpdateDualModePositionMargin**](FuturesApi.md#updatedualmodepositionmargin) | **POST** /futures/{settle}/dual_comp/positions/{contract}/margin | Update position margin in dual mode
[**UpdateDualModePositionLeverage**](FuturesApi.md#updatedualmodepositionleverage) | **POST** /futures/{settle}/dual_comp/positions/{contract}/leverage | Update position leverage in dual mode
[**UpdateDualModePositionRiskLimit**](FuturesApi.md#updatedualmodepositionrisklimit) | **POST** /futures/{settle}/dual_comp/positions/{contract}/risk_limit | Update position risk limit in dual mode
[**ListFuturesOrders**](FuturesApi.md#listfuturesorders) | **GET** /futures/{settle}/orders | Query futures order list
[**CreateFuturesOrder**](FuturesApi.md#createfuturesorder) | **POST** /futures/{settle}/orders | Place futures order
[**CancelFuturesOrders**](FuturesApi.md#cancelfuturesorders) | **DELETE** /futures/{settle}/orders | Cancel all orders with &#39;open&#39; status
[**GetOrdersWithTimeRange**](FuturesApi.md#getorderswithtimerange) | **GET** /futures/{settle}/orders_timerange | Query futures order list by time range
[**CreateBatchFuturesOrder**](FuturesApi.md#createbatchfuturesorder) | **POST** /futures/{settle}/batch_orders | Place batch futures orders
[**GetFuturesOrder**](FuturesApi.md#getfuturesorder) | **GET** /futures/{settle}/orders/{order_id} | Query single order details
[**AmendFuturesOrder**](FuturesApi.md#amendfuturesorder) | **PUT** /futures/{settle}/orders/{order_id} | Amend single order
[**CancelFuturesOrder**](FuturesApi.md#cancelfuturesorder) | **DELETE** /futures/{settle}/orders/{order_id} | Cancel single order
[**GetMyTrades**](FuturesApi.md#getmytrades) | **GET** /futures/{settle}/my_trades | Query personal trading records
[**GetMyTradesWithTimeRange**](FuturesApi.md#getmytradeswithtimerange) | **GET** /futures/{settle}/my_trades_timerange | Query personal trading records by time range
[**ListPositionClose**](FuturesApi.md#listpositionclose) | **GET** /futures/{settle}/position_close | Query position close history
[**ListLiquidates**](FuturesApi.md#listliquidates) | **GET** /futures/{settle}/liquidates | Query liquidation history
[**ListAutoDeleverages**](FuturesApi.md#listautodeleverages) | **GET** /futures/{settle}/auto_deleverages | Query ADL auto-deleveraging order information
[**CountdownCancelAllFutures**](FuturesApi.md#countdowncancelallfutures) | **POST** /futures/{settle}/countdown_cancel_all | Countdown cancel orders
[**GetFuturesFee**](FuturesApi.md#getfuturesfee) | **GET** /futures/{settle}/fee | Query futures market trading fee rates
[**CancelBatchFutureOrders**](FuturesApi.md#cancelbatchfutureorders) | **POST** /futures/{settle}/batch_cancel_orders | Cancel batch orders by specified ID list
[**AmendBatchFutureOrders**](FuturesApi.md#amendbatchfutureorders) | **POST** /futures/{settle}/batch_amend_orders | Batch modify orders by specified IDs
[**GetFuturesRiskLimitTable**](FuturesApi.md#getfuturesrisklimittable) | **GET** /futures/{settle}/risk_limit_table | Query risk limit table by table_id
[**ListPriceTriggeredOrders**](FuturesApi.md#listpricetriggeredorders) | **GET** /futures/{settle}/price_orders | Query auto order list
[**CreatePriceTriggeredOrder**](FuturesApi.md#createpricetriggeredorder) | **POST** /futures/{settle}/price_orders | Create price-triggered order
[**CancelPriceTriggeredOrderList**](FuturesApi.md#cancelpricetriggeredorderlist) | **DELETE** /futures/{settle}/price_orders | Cancel all auto orders
[**GetPriceTriggeredOrder**](FuturesApi.md#getpricetriggeredorder) | **GET** /futures/{settle}/price_orders/{order_id} | Query single auto order details
[**CancelPriceTriggeredOrder**](FuturesApi.md#cancelpricetriggeredorder) | **DELETE** /futures/{settle}/price_orders/{order_id} | Cancel single auto order


<a name="listfuturescontracts"></a>
# **ListFuturesContracts**
> List&lt;Contract&gt; ListFuturesContracts (string settle, int? limit = null, int? offset = null)

Query all futures contracts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Query all futures contracts
                List<Contract> result = apiInstance.ListFuturesContracts(settle, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesContracts: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;Contract&gt;**](Contract.md)

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

<a name="getfuturescontract"></a>
# **GetFuturesContract**
> Contract GetFuturesContract (string settle, string contract)

Query single contract information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Query single contract information
                Contract result = apiInstance.GetFuturesContract(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesContract: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contract information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesorderbook"></a>
# **ListFuturesOrderBook**
> FuturesOrderBook ListFuturesOrderBook (string settle, string contract, string interval = null, int? limit = null, bool? withId = null)

Query futures market depth information

Bids will be sorted by price from high to low, while asks sorted reversely

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var interval = "\"0\"";  // string | Price precision for depth aggregation, 0 means no aggregation, defaults to 0 if not specified (optional)  (default to "0")
            var limit = 10;  // int? | Number of depth levels (optional)  (default to 10)
            var withId = false;  // bool? | Whether to return depth update ID. This ID increments by 1 each time depth changes (optional)  (default to false)

            try
            {
                // Query futures market depth information
                FuturesOrderBook result = apiInstance.ListFuturesOrderBook(settle, contract, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesOrderBook: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **interval** | **string**| Price precision for depth aggregation, 0 means no aggregation, defaults to 0 if not specified | [optional] [default to &quot;0&quot;]
 **limit** | **int?**| Number of depth levels | [optional] [default to 10]
 **withId** | **bool?**| Whether to return depth update ID. This ID increments by 1 each time depth changes | [optional] [default to false]

### Return type

[**FuturesOrderBook**](FuturesOrderBook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Depth query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturestrades"></a>
# **ListFuturesTrades**
> List&lt;FuturesTrade&gt; ListFuturesTrades (string settle, string contract, int? limit = null, int? offset = null, string lastId = null, long? from = null, long? to = null)

Futures market transaction records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use `from` and `to` instead to limit time range (optional) 
            var from = 1546905600;  // long? | Specify starting time in Unix seconds. If not specified, `to` and `limit` will be used to limit response items. If items between `from` and `to` are more than `limit`, only `limit` number will be returned.  (optional) 
            var to = 1546935600;  // long? | Specify end time in Unix seconds, default to current time. (optional) 

            try
            {
                // Futures market transaction records
                List<FuturesTrade> result = apiInstance.ListFuturesTrades(settle, contract, limit, offset, lastId, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesTrades: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use &#x60;from&#x60; and &#x60;to&#x60; instead to limit time range | [optional] 
 **from** | **long?**| Specify starting time in Unix seconds. If not specified, &#x60;to&#x60; and &#x60;limit&#x60; will be used to limit response items. If items between &#x60;from&#x60; and &#x60;to&#x60; are more than &#x60;limit&#x60;, only &#x60;limit&#x60; number will be returned.  | [optional] 
 **to** | **long?**| Specify end time in Unix seconds, default to current time. | [optional] 

### Return type

[**List&lt;FuturesTrade&gt;**](FuturesTrade.md)

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

<a name="listfuturescandlesticks"></a>
# **ListFuturesCandlesticks**
> List&lt;FuturesCandlestick&gt; ListFuturesCandlesticks (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null, string timezone = null)

Futures market K-line chart

Return specified contract candlesticks. If prefix `contract` with `mark_`, the contract's mark price candlesticks are returned; if prefix with `index_`, index price candlesticks will be returned.  Maximum of 2000 points are returned in one query. Be sure not to exceed the limit when specifying `from`, `to` and `interval`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision (optional) 
            var limit = 100;  // int? | Maximum number of recent data points to return. `limit` conflicts with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points. Note that `1w` means natural week(Mon-Sun), while `7d` means every 7d since unix 0. 30d represents a natural month, not 30 days (optional)  (default to 5m)
            var timezone = "\"utc0\"";  // string | Time zone: all/utc0/utc8, default utc0 (optional)  (default to "utc0")

            try
            {
                // Futures market K-line chart
                List<FuturesCandlestick> result = apiInstance.ListFuturesCandlesticks(settle, contract, from, to, limit, interval, timezone);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesCandlesticks: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision | [optional] 
 **limit** | **int?**| Maximum number of recent data points to return. &#x60;limit&#x60; conflicts with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Interval time between data points. Note that &#x60;1w&#x60; means natural week(Mon-Sun), while &#x60;7d&#x60; means every 7d since unix 0. 30d represents a natural month, not 30 days | [optional] [default to 5m]
 **timezone** | **string**| Time zone: all/utc0/utc8, default utc0 | [optional] [default to &quot;utc0&quot;]

### Return type

[**List&lt;FuturesCandlestick&gt;**](FuturesCandlestick.md)

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

<a name="listfuturespremiumindex"></a>
# **ListFuturesPremiumIndex**
> List&lt;FuturesPremiumIndex&gt; ListFuturesPremiumIndex (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

Premium Index K-line chart

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
    public class ListFuturesPremiumIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision (optional) 
            var limit = 100;  // int? | Maximum number of recent data points to return. `limit` conflicts with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Time interval between data points (optional)  (default to 5m)

            try
            {
                // Premium Index K-line chart
                List<FuturesPremiumIndex> result = apiInstance.ListFuturesPremiumIndex(settle, contract, from, to, limit, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesPremiumIndex: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision | [optional] 
 **limit** | **int?**| Maximum number of recent data points to return. &#x60;limit&#x60; conflicts with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Time interval between data points | [optional] [default to 5m]

### Return type

[**List&lt;FuturesPremiumIndex&gt;**](FuturesPremiumIndex.md)

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

<a name="listfuturestickers"></a>
# **ListFuturesTickers**
> List&lt;FuturesTicker&gt; ListFuturesTickers (string settle, string contract = null)

Get all futures trading statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 

            try
            {
                // Get all futures trading statistics
                List<FuturesTicker> result = apiInstance.ListFuturesTickers(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesTickers: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 

### Return type

[**List&lt;FuturesTicker&gt;**](FuturesTicker.md)

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

<a name="listfuturesfundingratehistory"></a>
# **ListFuturesFundingRateHistory**
> List&lt;FundingRateRecord&gt; ListFuturesFundingRateHistory (string settle, string contract, int? limit = null, long? from = null, long? to = null)

Futures market historical funding rate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesFundingRateHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 

            try
            {
                // Futures market historical funding rate
                List<FundingRateRecord> result = apiInstance.ListFuturesFundingRateHistory(settle, contract, limit, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesFundingRateHistory: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 

### Return type

[**List&lt;FundingRateRecord&gt;**](FundingRateRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | History query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesinsuranceledger"></a>
# **ListFuturesInsuranceLedger**
> List&lt;InsuranceRecord&gt; ListFuturesInsuranceLedger (string settle, int? limit = null)

Futures market insurance fund history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesInsuranceLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)

            try
            {
                // Futures market insurance fund history
                List<InsuranceRecord> result = apiInstance.ListFuturesInsuranceLedger(settle, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesInsuranceLedger: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]

### Return type

[**List&lt;InsuranceRecord&gt;**](InsuranceRecord.md)

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

<a name="listcontractstats"></a>
# **ListContractStats**
> List&lt;ContractStat&gt; ListContractStats (string settle, string contract, long? from = null, string interval = null, int? limit = null)

Futures statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListContractStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1604561000;  // long? | Start timestamp (optional) 
            var interval = "\"5m\"";  // string |  (optional)  (default to "5m")
            var limit = 30;  // int? |  (optional)  (default to 30)

            try
            {
                // Futures statistics
                List<ContractStat> result = apiInstance.ListContractStats(settle, contract, from, interval, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListContractStats: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start timestamp | [optional] 
 **interval** | **string**|  | [optional] [default to &quot;5m&quot;]
 **limit** | **int?**|  | [optional] [default to 30]

### Return type

[**List&lt;ContractStat&gt;**](ContractStat.md)

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

<a name="getindexconstituents"></a>
# **GetIndexConstituents**
> FuturesIndexConstituents GetIndexConstituents (string settle, string index)

Query index constituents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetIndexConstituentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var index = "BTC_USDT";  // string | Index name

            try
            {
                // Query index constituents
                FuturesIndexConstituents result = apiInstance.GetIndexConstituents(settle, index);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetIndexConstituents: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **index** | **string**| Index name | 

### Return type

[**FuturesIndexConstituents**](FuturesIndexConstituents.md)

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

<a name="listliquidatedorders"></a>
# **ListLiquidatedOrders**
> List&lt;FuturesLiqOrder&gt; ListLiquidatedOrders (string settle, string contract = null, long? from = null, long? to = null, int? limit = null)

Query liquidation order history

The time interval between from and to is maximum 3600. Some private fields are not returned by public interfaces, refer to field descriptions for details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLiquidatedOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)

            try
            {
                // Query liquidation order history
                List<FuturesLiqOrder> result = apiInstance.ListLiquidatedOrders(settle, contract, from, to, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListLiquidatedOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]

### Return type

[**List&lt;FuturesLiqOrder&gt;**](FuturesLiqOrder.md)

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

<a name="listfuturesrisklimittiers"></a>
# **ListFuturesRiskLimitTiers**
> List&lt;FuturesLimitRiskTiers&gt; ListFuturesRiskLimitTiers (string settle, string contract = null, int? limit = null, int? offset = null)

Query risk limit tiers

When the 'contract' parameter is not passed, the default is to query the risk limits for the top 100 markets. 'Limit' and 'offset' correspond to pagination queries at the market level, not to the length of the returned array. This only takes effect when the contract parameter is empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesRiskLimitTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Query risk limit tiers
                List<FuturesLimitRiskTiers> result = apiInstance.ListFuturesRiskLimitTiers(settle, contract, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesRiskLimitTiers: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;FuturesLimitRiskTiers&gt;**](FuturesLimitRiskTiers.md)

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

<a name="listfuturesaccounts"></a>
# **ListFuturesAccounts**
> FuturesAccount ListFuturesAccounts (string settle)

Get futures account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency

            try
            {
                // Get futures account
                FuturesAccount result = apiInstance.ListFuturesAccounts(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesAccounts: " + e.Message);
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
 **settle** | **string**| Settle currency | 

### Return type

[**FuturesAccount**](FuturesAccount.md)

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

<a name="listfuturesaccountbook"></a>
# **ListFuturesAccountBook**
> List&lt;FuturesAccountBook&gt; ListFuturesAccountBook (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, string type = null)

Query futures account change history

If the contract field is passed, only records containing this field after 2023-10-30 can be filtered.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var type = "dnw";  // string | Change types:  - dnw: Deposit and withdrawal - pnl: Profit and loss from position reduction - fee: Trading fees - refr: Referrer rebates - fund: Funding fees - point_dnw: Point card deposit and withdrawal - point_fee: Point card trading fees - point_refr: Point card referrer rebates - bonus_offset: Trial fund deduction (optional) 

            try
            {
                // Query futures account change history
                List<FuturesAccountBook> result = apiInstance.ListFuturesAccountBook(settle, contract, limit, offset, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesAccountBook: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **type** | **string**| Change types:  - dnw: Deposit and withdrawal - pnl: Profit and loss from position reduction - fee: Trading fees - refr: Referrer rebates - fund: Funding fees - point_dnw: Point card deposit and withdrawal - point_fee: Point card trading fees - point_refr: Point card referrer rebates - bonus_offset: Trial fund deduction | [optional] 

### Return type

[**List&lt;FuturesAccountBook&gt;**](FuturesAccountBook.md)

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

<a name="listpositions"></a>
# **ListPositions**
> List&lt;Position&gt; ListPositions (string settle, bool? holding = null, int? limit = null, int? offset = null)

Get user position list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var holding = true;  // bool? | Return only real positions - true, return all - false (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Get user position list
                List<Position> result = apiInstance.ListPositions(settle, holding, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPositions: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **holding** | **bool?**| Return only real positions - true, return all - false | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="getposition"></a>
# **GetPosition**
> Position GetPosition (string settle, string contract)

Get single position information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Get single position information
                Position result = apiInstance.GetPosition(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetPosition: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionmargin"></a>
# **UpdatePositionMargin**
> Position UpdatePositionMargin (string settle, string contract, string change)

Update position margin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var change = "0.01";  // string | Margin change amount, positive number increases, negative number decreases

            try
            {
                // Update position margin
                Position result = apiInstance.UpdatePositionMargin(settle, contract, change);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionMargin: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **change** | **string**| Margin change amount, positive number increases, negative number decreases | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionleverage"></a>
# **UpdatePositionLeverage**
> Position UpdatePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null, int? pid = null)

Update position leverage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var leverage = "10";  // string | New position leverage
            var crossLeverageLimit = "10";  // string | Cross margin leverage (valid only when `leverage` is 0) (optional) 
            var pid = 1;  // int? | Product ID (optional) 

            try
            {
                // Update position leverage
                Position result = apiInstance.UpdatePositionLeverage(settle, contract, leverage, crossLeverageLimit, pid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionLeverage: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **leverage** | **string**| New position leverage | 
 **crossLeverageLimit** | **string**| Cross margin leverage (valid only when &#x60;leverage&#x60; is 0) | [optional] 
 **pid** | **int?**| Product ID | [optional] 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositioncrossmode"></a>
# **UpdatePositionCrossMode**
> Position UpdatePositionCrossMode (string settle, FuturesPositionCrossMode futuresPositionCrossMode)

Switch Position Margin Mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionCrossModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresPositionCrossMode = new FuturesPositionCrossMode(); // FuturesPositionCrossMode | 

            try
            {
                // Switch Position Margin Mode
                Position result = apiInstance.UpdatePositionCrossMode(settle, futuresPositionCrossMode);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionCrossMode: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **futuresPositionCrossMode** | [**FuturesPositionCrossMode**](FuturesPositionCrossMode.md)|  | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualcomppositioncrossmode"></a>
# **UpdateDualCompPositionCrossMode**
> List&lt;Position&gt; UpdateDualCompPositionCrossMode (string settle, InlineObject inlineObject)

Switch Between Cross and Isolated Margin Modes Under Hedge Mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualCompPositionCrossModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // Switch Between Cross and Isolated Margin Modes Under Hedge Mode
                List<Position> result = apiInstance.UpdateDualCompPositionCrossMode(settle, inlineObject);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualCompPositionCrossMode: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionrisklimit"></a>
# **UpdatePositionRiskLimit**
> Position UpdatePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionRiskLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var riskLimit = "1000000";  // string | New risk limit value

            try
            {
                // Update position risk limit
                Position result = apiInstance.UpdatePositionRiskLimit(settle, contract, riskLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionRiskLimit: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **riskLimit** | **string**| New risk limit value | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdualmode"></a>
# **SetDualMode**
> FuturesAccount SetDualMode (string settle, bool dualMode)

Set position mode

The prerequisite for changing mode is that all positions have no holdings and no pending orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetDualModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var dualMode = true;  // bool | Whether to enable dual mode

            try
            {
                // Set position mode
                FuturesAccount result = apiInstance.SetDualMode(settle, dualMode);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.SetDualMode: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **dualMode** | **bool**| Whether to enable dual mode | 

### Return type

[**FuturesAccount**](FuturesAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdualmodeposition"></a>
# **GetDualModePosition**
> List&lt;Position&gt; GetDualModePosition (string settle, string contract)

Get position information in dual mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetDualModePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Get position information in dual mode
                List<Position> result = apiInstance.GetDualModePosition(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetDualModePosition: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="updatedualmodepositionmargin"></a>
# **UpdateDualModePositionMargin**
> List&lt;Position&gt; UpdateDualModePositionMargin (string settle, string contract, string change, string dualSide)

Update position margin in dual mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var change = "0.01";  // string | Margin change amount, positive number increases, negative number decreases
            var dualSide = "dual_long";  // string | Long or short position

            try
            {
                // Update position margin in dual mode
                List<Position> result = apiInstance.UpdateDualModePositionMargin(settle, contract, change, dualSide);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionMargin: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **change** | **string**| Margin change amount, positive number increases, negative number decreases | 
 **dualSide** | **string**| Long or short position | 

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="updatedualmodepositionleverage"></a>
# **UpdateDualModePositionLeverage**
> List&lt;Position&gt; UpdateDualModePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null)

Update position leverage in dual mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var leverage = "10";  // string | New position leverage
            var crossLeverageLimit = "10";  // string | Cross margin leverage (valid only when `leverage` is 0) (optional) 

            try
            {
                // Update position leverage in dual mode
                List<Position> result = apiInstance.UpdateDualModePositionLeverage(settle, contract, leverage, crossLeverageLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionLeverage: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **leverage** | **string**| New position leverage | 
 **crossLeverageLimit** | **string**| Cross margin leverage (valid only when &#x60;leverage&#x60; is 0) | [optional] 

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="updatedualmodepositionrisklimit"></a>
# **UpdateDualModePositionRiskLimit**
> List&lt;Position&gt; UpdateDualModePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit in dual mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionRiskLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var riskLimit = "1000000";  // string | New risk limit value

            try
            {
                // Update position risk limit in dual mode
                List<Position> result = apiInstance.UpdateDualModePositionRiskLimit(settle, contract, riskLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionRiskLimit: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **riskLimit** | **string**| New risk limit value | 

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="listfuturesorders"></a>
# **ListFuturesOrders**
> List&lt;FuturesOrder&gt; ListFuturesOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null, string lastId = null)

Query futures order list

- Zero-fill order cannot be retrieved for 10 minutes after cancellation - Historical orders, by default, only data within the past 6 months is supported.  If you need to query data for a longer period, please use `GET /futures/{settle}/orders_timerange`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var status = "open";  // string | Query order list based on status
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Use the ID of the last record in the previous list as the starting point for the next list  Operations based on custom IDs can only be checked when orders are pending. After orders are completed (filled/cancelled), they can be checked within 1 hour after completion. After expiration, only order IDs can be used (optional) 

            try
            {
                // Query futures order list
                List<FuturesOrder> result = apiInstance.ListFuturesOrders(settle, status, contract, limit, offset, lastId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **status** | **string**| Query order list based on status | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Use the ID of the last record in the previous list as the starting point for the next list  Operations based on custom IDs can only be checked when orders are pending. After orders are completed (filled/cancelled), they can be checked within 1 hour after completion. After expiration, only order IDs can be used | [optional] 

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  * X-Pagination-Limit - Limit specified for pagination <br>  * X-Pagination-Offset - Offset specified for pagination <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfuturesorder"></a>
# **CreateFuturesOrder**
> FuturesOrder CreateFuturesOrder (string settle, FuturesOrder futuresOrder, string xGateExptime = null)

Place futures order

- When placing an order, the number of contracts is specified `size`, not the number of coins. The number of coins corresponding to each contract is returned in the contract details interface `quanto_multiplier` - 0 The order that was completed cannot be obtained after 10 minutes of withdrawal, and the order will be mentioned that the order does not exist - Setting `reduce_only` to `true` can prevent the position from being penetrated when reducing the position - In single-position mode, if you need to close the position, you need to set `size` to 0 and `close` to `true` - In dual warehouse mode,   - Reduce position: reduce_only=true, size is a positive number that indicates short position, negative number that indicates long position  - Add number that indicates adding long positions, and negative numbers indicate adding short positions  - Close position: size=0, set the direction of closing position according to auto_size, and set `reduce_only` to true  at the same time - reduce_only: Make sure to only perform position reduction operations to prevent increased positions - Set `stp_act` to determine the use of a strategy that restricts user transactions. For detailed usage, refer to the body parameter `stp_act`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresOrder = new FuturesOrder(); // FuturesOrder | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Place futures order
                FuturesOrder result = apiInstance.CreateFuturesOrder(settle, futuresOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreateFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **futuresOrder** | [**FuturesOrder**](FuturesOrder.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorders"></a>
# **CancelFuturesOrders**
> List&lt;FuturesOrder&gt; CancelFuturesOrders (string settle, string contract, string xGateExptime = null, string side = null, bool? excludeReduceOnly = null, string text = null)

Cancel all orders with 'open' status

Zero-fill orders cannot be retrieved 10 minutes after order cancellation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelFuturesOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 
            var side = "ask";  // string | Specify all buy orders or all sell orders, both are included if not specified. Set to bid to cancel all buy orders, set to ask to cancel all sell orders (optional) 
            var excludeReduceOnly = false;  // bool? | Whether to exclude reduce-only orders (optional)  (default to false)
            var text = "cancel by user";  // string | Remark for order cancellation (optional) 

            try
            {
                // Cancel all orders with 'open' status
                List<FuturesOrder> result = apiInstance.CancelFuturesOrders(settle, contract, xGateExptime, side, excludeReduceOnly, text);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelFuturesOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 
 **side** | **string**| Specify all buy orders or all sell orders, both are included if not specified. Set to bid to cancel all buy orders, set to ask to cancel all sell orders | [optional] 
 **excludeReduceOnly** | **bool?**| Whether to exclude reduce-only orders | [optional] [default to false]
 **text** | **string**| Remark for order cancellation | [optional] 

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderswithtimerange"></a>
# **GetOrdersWithTimeRange**
> List&lt;FuturesOrder&gt; GetOrdersWithTimeRange (string settle, string contract = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Query futures order list by time range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOrdersWithTimeRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Query futures order list by time range
                List<FuturesOrder> result = apiInstance.GetOrdersWithTimeRange(settle, contract, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetOrdersWithTimeRange: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  * X-Pagination-Limit - Limit specified for pagination <br>  * X-Pagination-Offset - Offset specified for pagination <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbatchfuturesorder"></a>
# **CreateBatchFuturesOrder**
> List&lt;BatchFuturesOrder&gt; CreateBatchFuturesOrder (string settle, List<FuturesOrder> futuresOrder, string xGateExptime = null)

Place batch futures orders

- Up to 10 orders per request - If any of the order's parameters are missing or in the wrong format, all of them will not be executed, and a http status 400 error will be returned directly - If the parameters are checked and passed, all are executed. Even if there is a business logic error in the middle (such as insufficient funds), it will not affect other execution orders - The returned result is in array format, and the order corresponds to the orders in the request body - In the returned result, the `succeeded` field of type bool indicates whether the execution was successful or not - If the execution is successful, the normal order content is included; if the execution fails, the `label` field is included to indicate the cause of the error - In the rate limiting, each order is counted individually

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateBatchFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresOrder = new List<FuturesOrder>(); // List<FuturesOrder> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Place batch futures orders
                List<BatchFuturesOrder> result = apiInstance.CreateBatchFuturesOrder(settle, futuresOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreateBatchFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **futuresOrder** | [**List&lt;FuturesOrder&gt;**](FuturesOrder.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchFuturesOrder&gt;**](BatchFuturesOrder.md)

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

<a name="getfuturesorder"></a>
# **GetFuturesOrder**
> FuturesOrder GetFuturesOrder (string settle, string orderId)

Query single order details

- Zero-fill order cannot be retrieved for 10 minutes after cancellation - Historical orders, by default, only data within the past 6 months is supported.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.

            try
            {
                // Query single order details
                FuturesOrder result = apiInstance.GetFuturesOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendfuturesorder"></a>
# **AmendFuturesOrder**
> FuturesOrder AmendFuturesOrder (string settle, string orderId, FuturesOrderAmendment futuresOrderAmendment, string xGateExptime = null)

Amend single order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.
            var futuresOrderAmendment = new FuturesOrderAmendment(); // FuturesOrderAmendment | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Amend single order
                FuturesOrder result = apiInstance.AmendFuturesOrder(settle, orderId, futuresOrderAmendment, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.AmendFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 
 **futuresOrderAmendment** | [**FuturesOrderAmendment**](FuturesOrderAmendment.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorder"></a>
# **CancelFuturesOrder**
> FuturesOrder CancelFuturesOrder (string settle, string orderId, string xGateExptime = null)

Cancel single order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel single order
                FuturesOrder result = apiInstance.CancelFuturesOrder(settle, orderId, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytrades"></a>
# **GetMyTrades**
> List&lt;MyFuturesTrade&gt; GetMyTrades (string settle, string contract = null, long? order = null, int? limit = null, int? offset = null, string lastId = null)

Query personal trading records

By default, only data within the past 6 months is supported.  If you need to query data for a longer period, please use `GET /futures/{settle}/my_trades_timerange`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMyTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var order = 12345;  // long? | Futures order ID, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. If you need to iterate through and retrieve more records, we recommend using 'GET /futures/{settle}/my_trades_timerange'. (optional) 

            try
            {
                // Query personal trading records
                List<MyFuturesTrade> result = apiInstance.GetMyTrades(settle, contract, order, limit, offset, lastId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetMyTrades: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **order** | **long?**| Futures order ID, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. If you need to iterate through and retrieve more records, we recommend using &#39;GET /futures/{settle}/my_trades_timerange&#39;. | [optional] 

### Return type

[**List&lt;MyFuturesTrade&gt;**](MyFuturesTrade.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  * X-Pagination-Limit - Limit specified for pagination <br>  * X-Pagination-Offset - Offset specified for pagination <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytradeswithtimerange"></a>
# **GetMyTradesWithTimeRange**
> List&lt;MyFuturesTradeTimeRange&gt; GetMyTradesWithTimeRange (string settle, string contract = null, long? from = null, long? to = null, int? limit = null, int? offset = null, string role = null)

Query personal trading records by time range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMyTradesWithTimeRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var role = "maker";  // string | Query role, maker or taker (optional) 

            try
            {
                // Query personal trading records by time range
                List<MyFuturesTradeTimeRange> result = apiInstance.GetMyTradesWithTimeRange(settle, contract, from, to, limit, offset, role);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetMyTradesWithTimeRange: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **role** | **string**| Query role, maker or taker | [optional] 

### Return type

[**List&lt;MyFuturesTradeTimeRange&gt;**](MyFuturesTradeTimeRange.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  * X-Pagination-Limit - Limit specified for pagination <br>  * X-Pagination-Offset - Offset specified for pagination <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpositionclose"></a>
# **ListPositionClose**
> List&lt;PositionClose&gt; ListPositionClose (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, string side = null, string pnl = null)

Query position close history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPositionCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var side = "short";  // string | Query side. long or shot (optional) 
            var pnl = "profit";  // string | Query profit or loss (optional) 

            try
            {
                // Query position close history
                List<PositionClose> result = apiInstance.ListPositionClose(settle, contract, limit, offset, from, to, side, pnl);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPositionClose: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **side** | **string**| Query side. long or shot | [optional] 
 **pnl** | **string**| Query profit or loss | [optional] 

### Return type

[**List&lt;PositionClose&gt;**](PositionClose.md)

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

<a name="listliquidates"></a>
# **ListLiquidates**
> List&lt;FuturesLiquidate&gt; ListLiquidates (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, int? at = null)

Query liquidation history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLiquidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var at = 0;  // int? | Specify liquidation timestamp (optional)  (default to 0)

            try
            {
                // Query liquidation history
                List<FuturesLiquidate> result = apiInstance.ListLiquidates(settle, contract, limit, offset, from, to, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListLiquidates: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **at** | **int?**| Specify liquidation timestamp | [optional] [default to 0]

### Return type

[**List&lt;FuturesLiquidate&gt;**](FuturesLiquidate.md)

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

<a name="listautodeleverages"></a>
# **ListAutoDeleverages**
> List&lt;FuturesAutoDeleverage&gt; ListAutoDeleverages (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, int? at = null)

Query ADL auto-deleveraging order information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoDeleveragesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var at = 0;  // int? | Specify auto-deleveraging timestamp (optional)  (default to 0)

            try
            {
                // Query ADL auto-deleveraging order information
                List<FuturesAutoDeleverage> result = apiInstance.ListAutoDeleverages(settle, contract, limit, offset, from, to, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListAutoDeleverages: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **at** | **int?**| Specify auto-deleveraging timestamp | [optional] [default to 0]

### Return type

[**List&lt;FuturesAutoDeleverage&gt;**](FuturesAutoDeleverage.md)

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

<a name="countdowncancelallfutures"></a>
# **CountdownCancelAllFutures**
> TriggerTime CountdownCancelAllFutures (string settle, CountdownCancelAllFuturesTask countdownCancelAllFuturesTask)

Countdown cancel orders

Heartbeat detection for contract orders: When the user-set `timeout` time is reached, if neither the existing countdown is canceled nor a new countdown is set, the relevant contract orders will be automatically canceled. This API can be called repeatedly to or cancel the countdown. Usage example: Repeatedly call this API at 30-second intervals, setting the `timeout` to 30 (seconds) each time. If this API is not called again within 30 seconds, all open orders on your specified `market` will be automatically canceled. If the `timeout` is set to 0 within 30 seconds, the countdown timer will terminate, and the automatic order cancellation function will be disabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CountdownCancelAllFuturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var countdownCancelAllFuturesTask = new CountdownCancelAllFuturesTask(); // CountdownCancelAllFuturesTask | 

            try
            {
                // Countdown cancel orders
                TriggerTime result = apiInstance.CountdownCancelAllFutures(settle, countdownCancelAllFuturesTask);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CountdownCancelAllFutures: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **countdownCancelAllFuturesTask** | [**CountdownCancelAllFuturesTask**](CountdownCancelAllFuturesTask.md)|  | 

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

<a name="getfuturesfee"></a>
# **GetFuturesFee**
> Dictionary&lt;string, FuturesFee&gt; GetFuturesFee (string settle, string contract = null)

Query futures market trading fee rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 

            try
            {
                // Query futures market trading fee rates
                Dictionary<string, FuturesFee> result = apiInstance.GetFuturesFee(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesFee: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 

### Return type

[**Dictionary&lt;string, FuturesFee&gt;**](FuturesFee.md)

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

<a name="cancelbatchfutureorders"></a>
# **CancelBatchFutureOrders**
> List&lt;FutureCancelOrderResult&gt; CancelBatchFutureOrders (string settle, List<string> requestBody, string xGateExptime = null)

Cancel batch orders by specified ID list

Multiple different order IDs can be specified, maximum 20 records per request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelBatchFutureOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var requestBody = new List<string>(); // List<string> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel batch orders by specified ID list
                List<FutureCancelOrderResult> result = apiInstance.CancelBatchFutureOrders(settle, requestBody, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelBatchFutureOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **requestBody** | [**List&lt;string&gt;**](string.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;FutureCancelOrderResult&gt;**](FutureCancelOrderResult.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancellation operation completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendbatchfutureorders"></a>
# **AmendBatchFutureOrders**
> List&lt;BatchFuturesOrder&gt; AmendBatchFutureOrders (string settle, List<BatchAmendOrderReq> batchAmendOrderReq, string xGateExptime = null)

Batch modify orders by specified IDs

Multiple different order IDs can be specified, maximum 10 orders per request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendBatchFutureOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var batchAmendOrderReq = new List<BatchAmendOrderReq>(); // List<BatchAmendOrderReq> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Batch modify orders by specified IDs
                List<BatchFuturesOrder> result = apiInstance.AmendBatchFutureOrders(settle, batchAmendOrderReq, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.AmendBatchFutureOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **batchAmendOrderReq** | [**List&lt;BatchAmendOrderReq&gt;**](BatchAmendOrderReq.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchFuturesOrder&gt;**](BatchFuturesOrder.md)

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

<a name="getfuturesrisklimittable"></a>
# **GetFuturesRiskLimitTable**
> List&lt;FuturesRiskLimitTier&gt; GetFuturesRiskLimitTable (string settle, string tableId)

Query risk limit table by table_id

Just pass table_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesRiskLimitTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var tableId = "CYBER_USDT_20241122";  // string | Risk limit table ID

            try
            {
                // Query risk limit table by table_id
                List<FuturesRiskLimitTier> result = apiInstance.GetFuturesRiskLimitTable(settle, tableId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesRiskLimitTable: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **tableId** | **string**| Risk limit table ID | 

### Return type

[**List&lt;FuturesRiskLimitTier&gt;**](FuturesRiskLimitTier.md)

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

<a name="listpricetriggeredorders"></a>
# **ListPriceTriggeredOrders**
> List&lt;FuturesPriceTriggeredOrder&gt; ListPriceTriggeredOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null)

Query auto order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPriceTriggeredOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var status = "status_example";  // string | Query order list based on status
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Query auto order list
                List<FuturesPriceTriggeredOrder> result = apiInstance.ListPriceTriggeredOrders(settle, status, contract, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPriceTriggeredOrders: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **status** | **string**| Query order list based on status | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;FuturesPriceTriggeredOrder&gt;**](FuturesPriceTriggeredOrder.md)

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

<a name="createpricetriggeredorder"></a>
# **CreatePriceTriggeredOrder**
> TriggerOrderResponse CreatePriceTriggeredOrder (string settle, FuturesPriceTriggeredOrder futuresPriceTriggeredOrder)

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
    public class CreatePriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresPriceTriggeredOrder = new FuturesPriceTriggeredOrder(); // FuturesPriceTriggeredOrder | 

            try
            {
                // Create price-triggered order
                TriggerOrderResponse result = apiInstance.CreatePriceTriggeredOrder(settle, futuresPriceTriggeredOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreatePriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **futuresPriceTriggeredOrder** | [**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)|  | 

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

<a name="cancelpricetriggeredorderlist"></a>
# **CancelPriceTriggeredOrderList**
> List&lt;FuturesPriceTriggeredOrder&gt; CancelPriceTriggeredOrderList (string settle, string contract = null)

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
    public class CancelPriceTriggeredOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 

            try
            {
                // Cancel all auto orders
                List<FuturesPriceTriggeredOrder> result = apiInstance.CancelPriceTriggeredOrderList(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelPriceTriggeredOrderList: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 

### Return type

[**List&lt;FuturesPriceTriggeredOrder&gt;**](FuturesPriceTriggeredOrder.md)

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

<a name="getpricetriggeredorder"></a>
# **GetPriceTriggeredOrder**
> FuturesPriceTriggeredOrder GetPriceTriggeredOrder (string settle, string orderId)

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
    public class GetPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | ID returned when order is successfully created

            try
            {
                // Query single auto order details
                FuturesPriceTriggeredOrder result = apiInstance.GetPriceTriggeredOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetPriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| ID returned when order is successfully created | 

### Return type

[**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)

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

<a name="cancelpricetriggeredorder"></a>
# **CancelPriceTriggeredOrder**
> FuturesPriceTriggeredOrder CancelPriceTriggeredOrder (string settle, string orderId)

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
    public class CancelPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | ID returned when order is successfully created

            try
            {
                // Cancel single auto order
                FuturesPriceTriggeredOrder result = apiInstance.CancelPriceTriggeredOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelPriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| ID returned when order is successfully created | 

### Return type

[**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)

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

