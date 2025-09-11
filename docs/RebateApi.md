# Io.Gate.GateApi.Api.RebateApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AgencyTransactionHistory**](RebateApi.md#agencytransactionhistory) | **GET** /rebate/agency/transaction_history | Broker obtains transaction history of recommended users
[**AgencyCommissionsHistory**](RebateApi.md#agencycommissionshistory) | **GET** /rebate/agency/commission_history | Broker obtains rebate history of recommended users
[**PartnerTransactionHistory**](RebateApi.md#partnertransactionhistory) | **GET** /rebate/partner/transaction_history | Partner obtains transaction history of recommended users
[**PartnerCommissionsHistory**](RebateApi.md#partnercommissionshistory) | **GET** /rebate/partner/commission_history | Partner obtains rebate records of recommended users
[**PartnerSubList**](RebateApi.md#partnersublist) | **GET** /rebate/partner/sub_list | Partner subordinate list
[**RebateBrokerCommissionHistory**](RebateApi.md#rebatebrokercommissionhistory) | **GET** /rebate/broker/commission_history | Broker obtains user&#39;s rebate records
[**RebateBrokerTransactionHistory**](RebateApi.md#rebatebrokertransactionhistory) | **GET** /rebate/broker/transaction_history | Broker obtains user&#39;s trading history
[**RebateUserInfo**](RebateApi.md#rebateuserinfo) | **GET** /rebate/user/info | User obtains rebate information
[**UserSubRelation**](RebateApi.md#usersubrelation) | **GET** /rebate/user/sub_relation | User subordinate relationship


<a name="agencytransactionhistory"></a>
# **AgencyTransactionHistory**
> List&lt;AgencyTransactionHistory&gt; AgencyTransactionHistory (string currencyPair = null, long? userId = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Broker obtains transaction history of recommended users

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AgencyTransactionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify the trading pair. If not specified, returns all trading pairs (optional) 
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1602120000;  // long? | Start time for querying records, defaults to 7 days before current time if not specified (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Broker obtains transaction history of recommended users
                List<AgencyTransactionHistory> result = apiInstance.AgencyTransactionHistory(currencyPair, userId, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.AgencyTransactionHistory: " + e.Message);
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
 **currencyPair** | **string**| Specify the trading pair. If not specified, returns all trading pairs | [optional] 
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time for querying records, defaults to 7 days before current time if not specified | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;AgencyTransactionHistory&gt;**](AgencyTransactionHistory.md)

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

<a name="agencycommissionshistory"></a>
# **AgencyCommissionsHistory**
> List&lt;AgencyCommissionHistory&gt; AgencyCommissionsHistory (string currency = null, int? commissionType = null, long? userId = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Broker obtains rebate history of recommended users

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AgencyCommissionsHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var currency = "BTC";  // string | Specify the currency. If not specified, returns all currencies (optional) 
            var commissionType = 1;  // int? | Rebate type: 1 - Direct rebate, 2 - Indirect rebate, 3 - Self rebate (optional) 
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1602120000;  // long? | Start time for querying records, defaults to 7 days before current time if not specified (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Broker obtains rebate history of recommended users
                List<AgencyCommissionHistory> result = apiInstance.AgencyCommissionsHistory(currency, commissionType, userId, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.AgencyCommissionsHistory: " + e.Message);
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
 **currency** | **string**| Specify the currency. If not specified, returns all currencies | [optional] 
 **commissionType** | **int?**| Rebate type: 1 - Direct rebate, 2 - Indirect rebate, 3 - Self rebate | [optional] 
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time for querying records, defaults to 7 days before current time if not specified | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;AgencyCommissionHistory&gt;**](AgencyCommissionHistory.md)

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

<a name="partnertransactionhistory"></a>
# **PartnerTransactionHistory**
> PartnerTransactionHistory PartnerTransactionHistory (string currencyPair = null, long? userId = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Partner obtains transaction history of recommended users

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PartnerTransactionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify the trading pair. If not specified, returns all trading pairs (optional) 
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1602120000;  // long? | Start time for querying records, defaults to 7 days before current time if not specified (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Partner obtains transaction history of recommended users
                PartnerTransactionHistory result = apiInstance.PartnerTransactionHistory(currencyPair, userId, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.PartnerTransactionHistory: " + e.Message);
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
 **currencyPair** | **string**| Specify the trading pair. If not specified, returns all trading pairs | [optional] 
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time for querying records, defaults to 7 days before current time if not specified | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**PartnerTransactionHistory**](PartnerTransactionHistory.md)

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

<a name="partnercommissionshistory"></a>
# **PartnerCommissionsHistory**
> PartnerCommissionHistory PartnerCommissionsHistory (string currency = null, long? userId = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Partner obtains rebate records of recommended users

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PartnerCommissionsHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var currency = "BTC";  // string | Specify the currency. If not specified, returns all currencies (optional) 
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1602120000;  // long? | Start time for querying records, defaults to 7 days before current time if not specified (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Partner obtains rebate records of recommended users
                PartnerCommissionHistory result = apiInstance.PartnerCommissionsHistory(currency, userId, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.PartnerCommissionsHistory: " + e.Message);
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
 **currency** | **string**| Specify the currency. If not specified, returns all currencies | [optional] 
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time for querying records, defaults to 7 days before current time if not specified | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**PartnerCommissionHistory**](PartnerCommissionHistory.md)

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

<a name="partnersublist"></a>
# **PartnerSubList**
> PartnerSubList PartnerSubList (long? userId = null, int? limit = null, int? offset = null)

Partner subordinate list

Including sub-agents, direct customers, and indirect customers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PartnerSubListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Partner subordinate list
                PartnerSubList result = apiInstance.PartnerSubList(userId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.PartnerSubList: " + e.Message);
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
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**PartnerSubList**](PartnerSubList.md)

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

<a name="rebatebrokercommissionhistory"></a>
# **RebateBrokerCommissionHistory**
> List&lt;BrokerCommission&gt; RebateBrokerCommissionHistory (int? limit = null, int? offset = null, long? userId = null, long? from = null, long? to = null)

Broker obtains user's rebate records

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RebateBrokerCommissionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1711929600;  // long? | Start time of the query record. If not specified, defaults to 30 days before the current time (optional) 
            var to = 1714521600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 

            try
            {
                // Broker obtains user's rebate records
                List<BrokerCommission> result = apiInstance.RebateBrokerCommissionHistory(limit, offset, userId, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.RebateBrokerCommissionHistory: " + e.Message);
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
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time of the query record. If not specified, defaults to 30 days before the current time | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 

### Return type

[**List&lt;BrokerCommission&gt;**](BrokerCommission.md)

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

<a name="rebatebrokertransactionhistory"></a>
# **RebateBrokerTransactionHistory**
> List&lt;BrokerTransaction&gt; RebateBrokerTransactionHistory (int? limit = null, int? offset = null, long? userId = null, long? from = null, long? to = null)

Broker obtains user's trading history

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RebateBrokerTransactionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var userId = 10003;  // long? | User ID. If not specified, all user records will be returned (optional) 
            var from = 1711929600;  // long? | Start time of the query record. If not specified, defaults to 30 days before the current time (optional) 
            var to = 1714521600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 

            try
            {
                // Broker obtains user's trading history
                List<BrokerTransaction> result = apiInstance.RebateBrokerTransactionHistory(limit, offset, userId, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.RebateBrokerTransactionHistory: " + e.Message);
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
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **userId** | **long?**| User ID. If not specified, all user records will be returned | [optional] 
 **from** | **long?**| Start time of the query record. If not specified, defaults to 30 days before the current time | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 

### Return type

[**List&lt;BrokerTransaction&gt;**](BrokerTransaction.md)

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

<a name="rebateuserinfo"></a>
# **RebateUserInfo**
> List&lt;RebateUserInfo&gt; RebateUserInfo ()

User obtains rebate information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RebateUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);

            try
            {
                // User obtains rebate information
                List<RebateUserInfo> result = apiInstance.RebateUserInfo();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.RebateUserInfo: " + e.Message);
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

[**List&lt;RebateUserInfo&gt;**](RebateUserInfo.md)

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

<a name="usersubrelation"></a>
# **UserSubRelation**
> UserSubRelation UserSubRelation (string userIdList)

User subordinate relationship

Query whether the specified user is within the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UserSubRelationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new RebateApi(config);
            var userIdList = "1, 2, 3";  // string | Query user ID list, separated by commas. If more than 100, only 100 will be returned

            try
            {
                // User subordinate relationship
                UserSubRelation result = apiInstance.UserSubRelation(userIdList);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling RebateApi.UserSubRelation: " + e.Message);
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
 **userIdList** | **string**| Query user ID list, separated by commas. If more than 100, only 100 will be returned | 

### Return type

[**UserSubRelation**](UserSubRelation.md)

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

