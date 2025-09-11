# Io.Gate.GateApi.Api.UnifiedApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUnifiedAccounts**](UnifiedApi.md#listunifiedaccounts) | **GET** /unified/accounts | Get unified account information
[**GetUnifiedBorrowable**](UnifiedApi.md#getunifiedborrowable) | **GET** /unified/borrowable | Query maximum borrowable amount for unified account
[**GetUnifiedTransferable**](UnifiedApi.md#getunifiedtransferable) | **GET** /unified/transferable | Query maximum transferable amount for unified account
[**GetUnifiedTransferables**](UnifiedApi.md#getunifiedtransferables) | **GET** /unified/transferables | Batch query maximum transferable amount for unified accounts. Each currency shows the maximum value. After user withdrawal, the transferable amount for all currencies will change
[**GetUnifiedBorrowableList**](UnifiedApi.md#getunifiedborrowablelist) | **GET** /unified/batch_borrowable | Batch query unified account maximum borrowable amount
[**ListUnifiedLoans**](UnifiedApi.md#listunifiedloans) | **GET** /unified/loans | Query loans
[**CreateUnifiedLoan**](UnifiedApi.md#createunifiedloan) | **POST** /unified/loans | Borrow or repay
[**ListUnifiedLoanRecords**](UnifiedApi.md#listunifiedloanrecords) | **GET** /unified/loan_records | Query loan records
[**ListUnifiedLoanInterestRecords**](UnifiedApi.md#listunifiedloaninterestrecords) | **GET** /unified/interest_records | Query interest deduction records
[**GetUnifiedRiskUnits**](UnifiedApi.md#getunifiedriskunits) | **GET** /unified/risk_units | Get user risk unit details
[**GetUnifiedMode**](UnifiedApi.md#getunifiedmode) | **GET** /unified/unified_mode | Query mode of the unified account
[**SetUnifiedMode**](UnifiedApi.md#setunifiedmode) | **PUT** /unified/unified_mode | Set unified account mode
[**GetUnifiedEstimateRate**](UnifiedApi.md#getunifiedestimaterate) | **GET** /unified/estimate_rate | Query unified account estimated interest rate
[**ListCurrencyDiscountTiers**](UnifiedApi.md#listcurrencydiscounttiers) | **GET** /unified/currency_discount_tiers | Query unified account tiered
[**ListLoanMarginTiers**](UnifiedApi.md#listloanmargintiers) | **GET** /unified/loan_margin_tiers | Query unified account tiered loan margin
[**CalculatePortfolioMargin**](UnifiedApi.md#calculateportfoliomargin) | **POST** /unified/portfolio_calculator | Portfolio margin calculator
[**GetUserLeverageCurrencyConfig**](UnifiedApi.md#getuserleveragecurrencyconfig) | **GET** /unified/leverage/user_currency_config | Maximum and minimum currency leverage that can be set
[**GetUserLeverageCurrencySetting**](UnifiedApi.md#getuserleveragecurrencysetting) | **GET** /unified/leverage/user_currency_setting | Get user currency leverage
[**SetUserLeverageCurrencySetting**](UnifiedApi.md#setuserleveragecurrencysetting) | **POST** /unified/leverage/user_currency_setting | Set loan currency leverage
[**ListUnifiedCurrencies**](UnifiedApi.md#listunifiedcurrencies) | **GET** /unified/currencies | List of loan currencies supported by unified account
[**GetHistoryLoanRate**](UnifiedApi.md#gethistoryloanrate) | **GET** /unified/history_loan_rate | Get historical lending rates
[**SetUnifiedCollateral**](UnifiedApi.md#setunifiedcollateral) | **POST** /unified/collateral_currencies | Set collateral currency


<a name="listunifiedaccounts"></a>
# **ListUnifiedAccounts**
> UnifiedAccount ListUnifiedAccounts (string currency = null, string subUid = null)

Get unified account information

The assets of each currency in the account will be adjusted according to their liquidity, defined by corresponding adjustment coefficients, and then uniformly converted to USD to calculate the total asset value and position value of the account.  For specific formulas, please refer to [Margin Formula](#margin-formula)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var subUid = "10001";  // string | Sub account user ID (optional) 

            try
            {
                // Get unified account information
                UnifiedAccount result = apiInstance.ListUnifiedAccounts(currency, subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedAccounts: " + e.Message);
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
 **subUid** | **string**| Sub account user ID | [optional] 

### Return type

[**UnifiedAccount**](UnifiedAccount.md)

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

<a name="getunifiedborrowable"></a>
# **GetUnifiedBorrowable**
> UnifiedBorrowable GetUnifiedBorrowable (string currency)

Query maximum borrowable amount for unified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedBorrowableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Query by specified currency name

            try
            {
                // Query maximum borrowable amount for unified account
                UnifiedBorrowable result = apiInstance.GetUnifiedBorrowable(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedBorrowable: " + e.Message);
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
 **currency** | **string**| Query by specified currency name | 

### Return type

[**UnifiedBorrowable**](UnifiedBorrowable.md)

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

<a name="getunifiedtransferable"></a>
# **GetUnifiedTransferable**
> UnifiedTransferable GetUnifiedTransferable (string currency)

Query maximum transferable amount for unified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedTransferableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Query by specified currency name

            try
            {
                // Query maximum transferable amount for unified account
                UnifiedTransferable result = apiInstance.GetUnifiedTransferable(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedTransferable: " + e.Message);
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
 **currency** | **string**| Query by specified currency name | 

### Return type

[**UnifiedTransferable**](UnifiedTransferable.md)

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

<a name="getunifiedtransferables"></a>
# **GetUnifiedTransferables**
> List&lt;TransferablesResult&gt; GetUnifiedTransferables (string currencies)

Batch query maximum transferable amount for unified accounts. Each currency shows the maximum value. After user withdrawal, the transferable amount for all currencies will change

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedTransferablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currencies = "BTC,ETH";  // string | Specify the currency name to query in batches, and support up to 100 pass parameters at a time

            try
            {
                // Batch query maximum transferable amount for unified accounts. Each currency shows the maximum value. After user withdrawal, the transferable amount for all currencies will change
                List<TransferablesResult> result = apiInstance.GetUnifiedTransferables(currencies);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedTransferables: " + e.Message);
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
 **currencies** | **string**| Specify the currency name to query in batches, and support up to 100 pass parameters at a time | 

### Return type

[**List&lt;TransferablesResult&gt;**](TransferablesResult.md)

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

<a name="getunifiedborrowablelist"></a>
# **GetUnifiedBorrowableList**
> List&lt;UnifiedBorrowable1&gt; GetUnifiedBorrowableList (List<string> currencies)

Batch query unified account maximum borrowable amount

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedBorrowableListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currencies = new List<string>(); // List<string> | Specify currency names for querying in an array, separated by commas, maximum 10 currencies

            try
            {
                // Batch query unified account maximum borrowable amount
                List<UnifiedBorrowable1> result = apiInstance.GetUnifiedBorrowableList(currencies);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedBorrowableList: " + e.Message);
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
 **currencies** | [**List&lt;string&gt;**](string.md)| Specify currency names for querying in an array, separated by commas, maximum 10 currencies | 

### Return type

[**List&lt;UnifiedBorrowable1&gt;**](UnifiedBorrowable1.md)

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

<a name="listunifiedloans"></a>
# **ListUnifiedLoans**
> List&lt;UniLoan&gt; ListUnifiedLoans (string currency = null, int? page = null, int? limit = null, string type = null)

Query loans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedLoansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)
            var type = "platform";  // string | Loan type: platform borrowing - platform, margin borrowing - margin (optional) 

            try
            {
                // Query loans
                List<UniLoan> result = apiInstance.ListUnifiedLoans(currency, page, limit, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoans: " + e.Message);
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
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]
 **type** | **string**| Loan type: platform borrowing - platform, margin borrowing - margin | [optional] 

### Return type

[**List&lt;UniLoan&gt;**](UniLoan.md)

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

<a name="createunifiedloan"></a>
# **CreateUnifiedLoan**
> UnifiedLoanResult CreateUnifiedLoan (UnifiedLoan unifiedLoan)

Borrow or repay

When borrowing, ensure the borrowed amount is not below the minimum borrowing threshold for the specific cryptocurrency and does not exceed the maximum borrowing limit set by the platform and user.  Loan interest will be automatically deducted from the account at regular intervals. Users are responsible for managing repayment of borrowed amounts.  For repayment, use `repaid_all=true` to repay all available amounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateUnifiedLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedLoan = new UnifiedLoan(); // UnifiedLoan | 

            try
            {
                // Borrow or repay
                UnifiedLoanResult result = apiInstance.CreateUnifiedLoan(unifiedLoan);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.CreateUnifiedLoan: " + e.Message);
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
 **unifiedLoan** | [**UnifiedLoan**](UnifiedLoan.md)|  | 

### Return type

[**UnifiedLoanResult**](UnifiedLoanResult.md)

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

<a name="listunifiedloanrecords"></a>
# **ListUnifiedLoanRecords**
> List&lt;UnifiedLoanRecord&gt; ListUnifiedLoanRecords (string type = null, string currency = null, int? page = null, int? limit = null)

Query loan records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedLoanRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var type = "type_example";  // string | Loan record type: borrow - borrowing, repay - repayment (optional) 
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)

            try
            {
                // Query loan records
                List<UnifiedLoanRecord> result = apiInstance.ListUnifiedLoanRecords(type, currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoanRecords: " + e.Message);
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
 **type** | **string**| Loan record type: borrow - borrowing, repay - repayment | [optional] 
 **currency** | **string**| Query by specified currency name | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;UnifiedLoanRecord&gt;**](UnifiedLoanRecord.md)

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

<a name="listunifiedloaninterestrecords"></a>
# **ListUnifiedLoanInterestRecords**
> List&lt;UniLoanInterestRecord&gt; ListUnifiedLoanInterestRecords (string currency = null, int? page = null, int? limit = null, long? from = null, long? to = null, string type = null)

Query interest deduction records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedLoanInterestRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)
            var from = 1627706330;  // long? | Start timestamp for the query (optional) 
            var to = 1635329650;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var type = "platform";  // string | Loan type: platform borrowing - platform, margin borrowing - margin. Defaults to margin if not specified (optional) 

            try
            {
                // Query interest deduction records
                List<UniLoanInterestRecord> result = apiInstance.ListUnifiedLoanInterestRecords(currency, page, limit, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoanInterestRecords: " + e.Message);
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
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]
 **from** | **long?**| Start timestamp for the query | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **type** | **string**| Loan type: platform borrowing - platform, margin borrowing - margin. Defaults to margin if not specified | [optional] 

### Return type

[**List&lt;UniLoanInterestRecord&gt;**](UniLoanInterestRecord.md)

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

<a name="getunifiedriskunits"></a>
# **GetUnifiedRiskUnits**
> UnifiedRiskUnits GetUnifiedRiskUnits ()

Get user risk unit details

Get user risk unit details, only valid in portfolio margin mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedRiskUnitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);

            try
            {
                // Get user risk unit details
                UnifiedRiskUnits result = apiInstance.GetUnifiedRiskUnits();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedRiskUnits: " + e.Message);
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

[**UnifiedRiskUnits**](UnifiedRiskUnits.md)

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

<a name="getunifiedmode"></a>
# **GetUnifiedMode**
> UnifiedModeSet GetUnifiedMode ()

Query mode of the unified account

Unified account mode: - `classic`: Classic account mode - `multi_currency`: Cross-currency margin mode - `portfolio`: Portfolio margin mode - `single_currency`: Single-currency margin mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);

            try
            {
                // Query mode of the unified account
                UnifiedModeSet result = apiInstance.GetUnifiedMode();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedMode: " + e.Message);
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

[**UnifiedModeSet**](UnifiedModeSet.md)

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

<a name="setunifiedmode"></a>
# **SetUnifiedMode**
> void SetUnifiedMode (UnifiedModeSet unifiedModeSet)

Set unified account mode

Each account mode switch only requires passing the corresponding account mode parameter, and also supports turning on or off the configuration switches under the corresponding account mode during the switch. - When enabling the classic account mode, mode=classic ```  PUT /unified/unified_mode  {  \"mode\": \"classic\"  } ``` - When enabling the cross-currency margin \"multi_currency\",  \"settings\": {  \"usdt_futures\": true  }  } ``` - When enabling the portfolio margin mode, mode=portfolio ```  PUT /unified/unified_mode  {  \"mode\": \"portfolio\",  \"settings\": {  \"spot_hedge\": true  }  } ``` - When enabling the single-currency margin mode, mode=single_currency ```  PUT /unified/unified_mode  {  \"mode\": \"single_currency\"  } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUnifiedModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedModeSet = new UnifiedModeSet(); // UnifiedModeSet | 

            try
            {
                // Set unified account mode
                apiInstance.SetUnifiedMode(unifiedModeSet);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.SetUnifiedMode: " + e.Message);
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
 **unifiedModeSet** | [**UnifiedModeSet**](UnifiedModeSet.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Set successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunifiedestimaterate"></a>
# **GetUnifiedEstimateRate**
> Dictionary&lt;string, string&gt; GetUnifiedEstimateRate (List<string> currencies)

Query unified account estimated interest rate

Interest rates fluctuate hourly based on lending depth, so exact rates cannot be provided. When a currency is not supported, the interest rate returned will be an empty string

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedEstimateRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currencies = new List<string>(); // List<string> | Specify currency names for querying in an array, separated by commas, maximum 10 currencies

            try
            {
                // Query unified account estimated interest rate
                Dictionary<string, string> result = apiInstance.GetUnifiedEstimateRate(currencies);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedEstimateRate: " + e.Message);
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
 **currencies** | [**List&lt;string&gt;**](string.md)| Specify currency names for querying in an array, separated by commas, maximum 10 currencies | 

### Return type

**Dictionary<string, string>**

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

<a name="listcurrencydiscounttiers"></a>
# **ListCurrencyDiscountTiers**
> List&lt;UnifiedDiscount&gt; ListCurrencyDiscountTiers ()

Query unified account tiered

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyDiscountTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);

            try
            {
                // Query unified account tiered
                List<UnifiedDiscount> result = apiInstance.ListCurrencyDiscountTiers();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListCurrencyDiscountTiers: " + e.Message);
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

[**List&lt;UnifiedDiscount&gt;**](UnifiedDiscount.md)

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

<a name="listloanmargintiers"></a>
# **ListLoanMarginTiers**
> List&lt;UnifiedMarginTiers&gt; ListLoanMarginTiers ()

Query unified account tiered loan margin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLoanMarginTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);

            try
            {
                // Query unified account tiered loan margin
                List<UnifiedMarginTiers> result = apiInstance.ListLoanMarginTiers();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListLoanMarginTiers: " + e.Message);
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

[**List&lt;UnifiedMarginTiers&gt;**](UnifiedMarginTiers.md)

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

<a name="calculateportfoliomargin"></a>
# **CalculatePortfolioMargin**
> UnifiedPortfolioOutput CalculatePortfolioMargin (UnifiedPortfolioInput unifiedPortfolioInput)

Portfolio margin calculator

Portfolio Margin Calculator  When inputting simulated position portfolios, each position includes the position name and quantity held, supporting markets within the range of BTC and ETH perpetual contracts, options, and spot markets. When inputting simulated orders, each order includes the market identifier, order price, and order quantity, supporting markets within the range of BTC and ETH perpetual contracts, options, and spot markets. Market orders are not included.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CalculatePortfolioMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);
            var unifiedPortfolioInput = new UnifiedPortfolioInput(); // UnifiedPortfolioInput | 

            try
            {
                // Portfolio margin calculator
                UnifiedPortfolioOutput result = apiInstance.CalculatePortfolioMargin(unifiedPortfolioInput);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.CalculatePortfolioMargin: " + e.Message);
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
 **unifiedPortfolioInput** | [**UnifiedPortfolioInput**](UnifiedPortfolioInput.md)|  | 

### Return type

[**UnifiedPortfolioOutput**](UnifiedPortfolioOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserleveragecurrencyconfig"></a>
# **GetUserLeverageCurrencyConfig**
> UnifiedLeverageConfig GetUserLeverageCurrencyConfig (string currency)

Maximum and minimum currency leverage that can be set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserLeverageCurrencyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Currency

            try
            {
                // Maximum and minimum currency leverage that can be set
                UnifiedLeverageConfig result = apiInstance.GetUserLeverageCurrencyConfig(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUserLeverageCurrencyConfig: " + e.Message);
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
 **currency** | **string**| Currency | 

### Return type

[**UnifiedLeverageConfig**](UnifiedLeverageConfig.md)

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

<a name="getuserleveragecurrencysetting"></a>
# **GetUserLeverageCurrencySetting**
> List&lt;UnifiedLeverageSetting&gt; GetUserLeverageCurrencySetting (string currency = null)

Get user currency leverage

Get user currency leverage. If currency is not specified, query all currencies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserLeverageCurrencySettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Currency (optional) 

            try
            {
                // Get user currency leverage
                List<UnifiedLeverageSetting> result = apiInstance.GetUserLeverageCurrencySetting(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUserLeverageCurrencySetting: " + e.Message);
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
 **currency** | **string**| Currency | [optional] 

### Return type

[**List&lt;UnifiedLeverageSetting&gt;**](UnifiedLeverageSetting.md)

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

<a name="setuserleveragecurrencysetting"></a>
# **SetUserLeverageCurrencySetting**
> void SetUserLeverageCurrencySetting (UnifiedLeverageSetting unifiedLeverageSetting)

Set loan currency leverage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUserLeverageCurrencySettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedLeverageSetting = new UnifiedLeverageSetting(); // UnifiedLeverageSetting | 

            try
            {
                // Set loan currency leverage
                apiInstance.SetUserLeverageCurrencySetting(unifiedLeverageSetting);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.SetUserLeverageCurrencySetting: " + e.Message);
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
 **unifiedLeverageSetting** | [**UnifiedLeverageSetting**](UnifiedLeverageSetting.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Set successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listunifiedcurrencies"></a>
# **ListUnifiedCurrencies**
> List&lt;UnifiedCurrency&gt; ListUnifiedCurrencies (string currency = null)

List of loan currencies supported by unified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Currency (optional) 

            try
            {
                // List of loan currencies supported by unified account
                List<UnifiedCurrency> result = apiInstance.ListUnifiedCurrencies(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedCurrencies: " + e.Message);
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
 **currency** | **string**| Currency | [optional] 

### Return type

[**List&lt;UnifiedCurrency&gt;**](UnifiedCurrency.md)

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

<a name="gethistoryloanrate"></a>
# **GetHistoryLoanRate**
> UnifiedHistoryLoanRate GetHistoryLoanRate (string currency, string tier = null, int? page = null, int? limit = null)

Get historical lending rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetHistoryLoanRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);
            var currency = "USDT";  // string | Currency
            var tier = "1";  // string | VIP level for the floating rate to be queried (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)

            try
            {
                // Get historical lending rates
                UnifiedHistoryLoanRate result = apiInstance.GetHistoryLoanRate(currency, tier, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetHistoryLoanRate: " + e.Message);
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
 **currency** | **string**| Currency | 
 **tier** | **string**| VIP level for the floating rate to be queried | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]

### Return type

[**UnifiedHistoryLoanRate**](UnifiedHistoryLoanRate.md)

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

<a name="setunifiedcollateral"></a>
# **SetUnifiedCollateral**
> UnifiedCollateralRes SetUnifiedCollateral (UnifiedCollateralReq unifiedCollateralReq)

Set collateral currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUnifiedCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedCollateralReq = new UnifiedCollateralReq(); // UnifiedCollateralReq | 

            try
            {
                // Set collateral currency
                UnifiedCollateralRes result = apiInstance.SetUnifiedCollateral(unifiedCollateralReq);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.SetUnifiedCollateral: " + e.Message);
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
 **unifiedCollateralReq** | [**UnifiedCollateralReq**](UnifiedCollateralReq.md)|  | 

### Return type

[**UnifiedCollateralRes**](UnifiedCollateralRes.md)

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

