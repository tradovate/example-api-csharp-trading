# Tradovate.Services.Api.AuthenticationApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccessTokenRequest**](AuthenticationApi.md#accesstokenrequest) | **POST** /auth/accesstokenrequest | 
[**RenewAccessToken**](AuthenticationApi.md#renewaccesstoken) | **GET** /auth/renewaccesstoken | 

<a name="accesstokenrequest"></a>
# **AccessTokenRequest**
> AccessTokenResponse AccessTokenRequest (AccessTokenRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccessTokenRequestExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new AccessTokenRequest(); // AccessTokenRequest | 

            try
            {
                AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AccessTokenRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccessTokenRequest**](AccessTokenRequest.md)|  | 

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renewaccesstoken"></a>
# **RenewAccessToken**
> AccessTokenResponse RenewAccessToken ()



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class RenewAccessTokenExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();

            try
            {
                AccessTokenResponse result = apiInstance.RenewAccessToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.RenewAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
