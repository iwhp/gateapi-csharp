# Io.Gate.GateApi.Api.MultiCollateralLoanApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListMultiCollateralOrders**](MultiCollateralLoanApi.md#listmulticollateralorders) | **GET** /loan/multi_collateral/orders | Query multi-currency collateral order list
[**CreateMultiCollateral**](MultiCollateralLoanApi.md#createmulticollateral) | **POST** /loan/multi_collateral/orders | Place multi-currency collateral order
[**GetMultiCollateralOrderDetail**](MultiCollateralLoanApi.md#getmulticollateralorderdetail) | **GET** /loan/multi_collateral/orders/{order_id} | Query order details
[**ListMultiRepayRecords**](MultiCollateralLoanApi.md#listmultirepayrecords) | **GET** /loan/multi_collateral/repay | Query multi-currency collateral repayment records
[**RepayMultiCollateralLoan**](MultiCollateralLoanApi.md#repaymulticollateralloan) | **POST** /loan/multi_collateral/repay | Multi-currency collateral repayment
[**ListMultiCollateralRecords**](MultiCollateralLoanApi.md#listmulticollateralrecords) | **GET** /loan/multi_collateral/mortgage | Query collateral adjustment records
[**OperateMultiCollateral**](MultiCollateralLoanApi.md#operatemulticollateral) | **POST** /loan/multi_collateral/mortgage | Add or withdraw collateral
[**ListUserCurrencyQuota**](MultiCollateralLoanApi.md#listusercurrencyquota) | **GET** /loan/multi_collateral/currency_quota | Query user&#39;s collateral and borrowing currency quota information
[**ListMultiCollateralCurrencies**](MultiCollateralLoanApi.md#listmulticollateralcurrencies) | **GET** /loan/multi_collateral/currencies | Query supported borrowing and collateral currencies for multi-currency collateral
[**GetMultiCollateralLtv**](MultiCollateralLoanApi.md#getmulticollateralltv) | **GET** /loan/multi_collateral/ltv | Query collateralization ratio information
[**GetMultiCollateralFixRate**](MultiCollateralLoanApi.md#getmulticollateralfixrate) | **GET** /loan/multi_collateral/fixed_rate | Query currency&#39;s 7-day and 30-day fixed interest rates
[**GetMultiCollateralCurrentRate**](MultiCollateralLoanApi.md#getmulticollateralcurrentrate) | **GET** /loan/multi_collateral/current_rate | Query currency&#39;s current interest rate


<a name="listmulticollateralorders"></a>
# **ListMultiCollateralOrders**
> List&lt;MultiCollateralOrder&gt; ListMultiCollateralOrders (int? page = null, int? limit = null, string sort = null, string orderType = null)

Query multi-currency collateral order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records returned in a single list (optional)  (default to 10)
            var sort = "ltv_asc";  // string | Sort type: `time_desc` - Created time descending (default), `ltv_asc` - Collateral ratio ascending, `ltv_desc` - Collateral ratio descending. (optional) 
            var orderType = "current";  // string | Order type: current - Query current orders, fixed - Query fixed orders, defaults to current orders if not specified (optional) 

            try
            {
                // Query multi-currency collateral order list
                List<MultiCollateralOrder> result = apiInstance.ListMultiCollateralOrders(page, limit, sort, orderType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralOrders: " + e.Message);
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
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 10]
 **sort** | **string**| Sort type: &#x60;time_desc&#x60; - Created time descending (default), &#x60;ltv_asc&#x60; - Collateral ratio ascending, &#x60;ltv_desc&#x60; - Collateral ratio descending. | [optional] 
 **orderType** | **string**| Order type: current - Query current orders, fixed - Query fixed orders, defaults to current orders if not specified | [optional] 

### Return type

[**List&lt;MultiCollateralOrder&gt;**](MultiCollateralOrder.md)

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

<a name="createmulticollateral"></a>
# **CreateMultiCollateral**
> OrderResp CreateMultiCollateral (CreateMultiCollateralOrder createMultiCollateralOrder)

Place multi-currency collateral order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateMultiCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var createMultiCollateralOrder = new CreateMultiCollateralOrder(); // CreateMultiCollateralOrder | 

            try
            {
                // Place multi-currency collateral order
                OrderResp result = apiInstance.CreateMultiCollateral(createMultiCollateralOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.CreateMultiCollateral: " + e.Message);
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
 **createMultiCollateralOrder** | [**CreateMultiCollateralOrder**](CreateMultiCollateralOrder.md)|  | 

### Return type

[**OrderResp**](OrderResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order placed successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmulticollateralorderdetail"></a>
# **GetMultiCollateralOrderDetail**
> MultiCollateralOrder GetMultiCollateralOrderDetail (string orderId)

Query order details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var orderId = "12345";  // string | Order ID returned when order is successfully created

            try
            {
                // Query order details
                MultiCollateralOrder result = apiInstance.GetMultiCollateralOrderDetail(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralOrderDetail: " + e.Message);
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
 **orderId** | **string**| Order ID returned when order is successfully created | 

### Return type

[**MultiCollateralOrder**](MultiCollateralOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details queried successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmultirepayrecords"></a>
# **ListMultiRepayRecords**
> List&lt;MultiRepayRecord&gt; ListMultiRepayRecords (string type, string borrowCurrency = null, int? page = null, int? limit = null, long? from = null, long? to = null)

Query multi-currency collateral repayment records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiRepayRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var type = "repay";  // string | Operation type: repay - Regular repayment, liquidate - Liquidation
            var borrowCurrency = "USDT";  // string | Borrowed currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records returned in a single list (optional)  (default to 10)
            var from = 1609459200;  // long? | Start timestamp for the query (optional) 
            var to = 1609459200;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 

            try
            {
                // Query multi-currency collateral repayment records
                List<MultiRepayRecord> result = apiInstance.ListMultiRepayRecords(type, borrowCurrency, page, limit, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiRepayRecords: " + e.Message);
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
 **type** | **string**| Operation type: repay - Regular repayment, liquidate - Liquidation | 
 **borrowCurrency** | **string**| Borrowed currency | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 10]
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 

### Return type

[**List&lt;MultiRepayRecord&gt;**](MultiRepayRecord.md)

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

<a name="repaymulticollateralloan"></a>
# **RepayMultiCollateralLoan**
> MultiRepayResp RepayMultiCollateralLoan (RepayMultiLoan repayMultiLoan)

Multi-currency collateral repayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RepayMultiCollateralLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var repayMultiLoan = new RepayMultiLoan(); // RepayMultiLoan | 

            try
            {
                // Multi-currency collateral repayment
                MultiRepayResp result = apiInstance.RepayMultiCollateralLoan(repayMultiLoan);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.RepayMultiCollateralLoan: " + e.Message);
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
 **repayMultiLoan** | [**RepayMultiLoan**](RepayMultiLoan.md)|  | 

### Return type

[**MultiRepayResp**](MultiRepayResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmulticollateralrecords"></a>
# **ListMultiCollateralRecords**
> List&lt;MultiCollateralRecord&gt; ListMultiCollateralRecords (int? page = null, int? limit = null, long? from = null, long? to = null, string collateralCurrency = null)

Query collateral adjustment records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records returned in a single list (optional)  (default to 10)
            var from = 1609459200;  // long? | Start timestamp for the query (optional) 
            var to = 1609459200;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var collateralCurrency = "BTC";  // string | Collateral currency (optional) 

            try
            {
                // Query collateral adjustment records
                List<MultiCollateralRecord> result = apiInstance.ListMultiCollateralRecords(page, limit, from, to, collateralCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralRecords: " + e.Message);
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
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 10]
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **collateralCurrency** | **string**| Collateral currency | [optional] 

### Return type

[**List&lt;MultiCollateralRecord&gt;**](MultiCollateralRecord.md)

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

<a name="operatemulticollateral"></a>
# **OperateMultiCollateral**
> CollateralAdjustRes OperateMultiCollateral (CollateralAdjust collateralAdjust)

Add or withdraw collateral

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class OperateMultiCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var collateralAdjust = new CollateralAdjust(); // CollateralAdjust | 

            try
            {
                // Add or withdraw collateral
                CollateralAdjustRes result = apiInstance.OperateMultiCollateral(collateralAdjust);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.OperateMultiCollateral: " + e.Message);
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
 **collateralAdjust** | [**CollateralAdjust**](CollateralAdjust.md)|  | 

### Return type

[**CollateralAdjustRes**](CollateralAdjustRes.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusercurrencyquota"></a>
# **ListUserCurrencyQuota**
> List&lt;CurrencyQuota&gt; ListUserCurrencyQuota (string type, string currency)

Query user's collateral and borrowing currency quota information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUserCurrencyQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var type = "collateral";  // string | Currency type: collateral - Collateral currency, borrow - Borrowing currency
            var currency = "BTC";  // string | When it is a collateral currency, multiple currencies can be provided separated by commas; when it is a borrowing currency, only one currency can be provided.

            try
            {
                // Query user's collateral and borrowing currency quota information
                List<CurrencyQuota> result = apiInstance.ListUserCurrencyQuota(type, currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListUserCurrencyQuota: " + e.Message);
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
 **type** | **string**| Currency type: collateral - Collateral currency, borrow - Borrowing currency | 
 **currency** | **string**| When it is a collateral currency, multiple currencies can be provided separated by commas; when it is a borrowing currency, only one currency can be provided. | 

### Return type

[**List&lt;CurrencyQuota&gt;**](CurrencyQuota.md)

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

<a name="listmulticollateralcurrencies"></a>
# **ListMultiCollateralCurrencies**
> MultiCollateralCurrency ListMultiCollateralCurrencies ()

Query supported borrowing and collateral currencies for multi-currency collateral

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Query supported borrowing and collateral currencies for multi-currency collateral
                MultiCollateralCurrency result = apiInstance.ListMultiCollateralCurrencies();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralCurrencies: " + e.Message);
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

[**MultiCollateralCurrency**](MultiCollateralCurrency.md)

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

<a name="getmulticollateralltv"></a>
# **GetMultiCollateralLtv**
> CollateralLtv GetMultiCollateralLtv ()

Query collateralization ratio information

Multi-currency collateral ratio is fixed, independent of currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralLtvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Query collateralization ratio information
                CollateralLtv result = apiInstance.GetMultiCollateralLtv();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralLtv: " + e.Message);
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

[**CollateralLtv**](CollateralLtv.md)

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

<a name="getmulticollateralfixrate"></a>
# **GetMultiCollateralFixRate**
> List&lt;CollateralFixRate&gt; GetMultiCollateralFixRate ()

Query currency's 7-day and 30-day fixed interest rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralFixRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Query currency's 7-day and 30-day fixed interest rates
                List<CollateralFixRate> result = apiInstance.GetMultiCollateralFixRate();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralFixRate: " + e.Message);
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

[**List&lt;CollateralFixRate&gt;**](CollateralFixRate.md)

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

<a name="getmulticollateralcurrentrate"></a>
# **GetMultiCollateralCurrentRate**
> List&lt;CollateralCurrentRate&gt; GetMultiCollateralCurrentRate (List<string> currencies, string vipLevel = null)

Query currency's current interest rate

Query currency's current interest rate for the previous hour, current interest rate updates hourly

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralCurrentRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);
            var currencies = new List<string>(); // List<string> | Specify currency name query array, separated by commas, maximum 100 items
            var vipLevel = "\"0\"";  // string | VIP level, defaults to 0 if not specified (optional)  (default to "0")

            try
            {
                // Query currency's current interest rate
                List<CollateralCurrentRate> result = apiInstance.GetMultiCollateralCurrentRate(currencies, vipLevel);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralCurrentRate: " + e.Message);
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
 **currencies** | [**List&lt;string&gt;**](string.md)| Specify currency name query array, separated by commas, maximum 100 items | 
 **vipLevel** | **string**| VIP level, defaults to 0 if not specified | [optional] [default to &quot;0&quot;]

### Return type

[**List&lt;CollateralCurrentRate&gt;**](CollateralCurrentRate.md)

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

