
# Io.Gate.GateApi.Model.SubAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Remark** | **string** | Remark | [optional] 
**LoginName** | **string** | Sub-account login name: Only letters, numbers and underscores are supported, cannot contain other invalid characters | 
**Password** | **string** | The sub-account&#39;s password. (Default: the same as main account&#39;s password) | [optional] 
**Email** | **string** | The sub-account&#39;s email address. (Default: the same as main account&#39;s email address) | [optional] 
**State** | **int** | Sub-account status: 1-normal, 2-locked | [optional] [readonly] 
**Type** | **int** | Sub-account type: 1-Regular sub-account, 3-Cross margin sub-account | [optional] [readonly] 
**UserId** | **long** | Sub-account user ID | [optional] [readonly] 
**CreateTime** | **long** | Created time | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
