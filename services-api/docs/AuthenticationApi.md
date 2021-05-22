# Tradovate.Services.Api.AuthenticationApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccessTokenRequest**](AuthenticationApi.md#accesstokenrequest) | **POST** /auth/accesstokenrequest | 
[**Me**](AuthenticationApi.md#me) | **GET** /auth/me | 
[**OAuthToken**](AuthenticationApi.md#oauthtoken) | **POST** /auth/oauthtoken | 
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
<a name="me"></a>
# **Me**
> OAuthMeResponse Me ()



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MeExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();

            try
            {
                OAuthMeResponse result = apiInstance.Me();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Me: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OAuthMeResponse**](OAuthMeResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="oauthtoken"></a>
# **OAuthToken**
> OAuthTokenResponse OAuthToken (OAuthToken body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OAuthTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new OAuthToken(); // OAuthToken | 

            try
            {
                OAuthTokenResponse result = apiInstance.OAuthToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.OAuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuthToken**](OAuthToken.md)|  | 

### Return type

[**OAuthTokenResponse**](OAuthTokenResponse.md)

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
