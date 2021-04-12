# Tradovate.Services.Api.PricesApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeSpeed**](PricesApi.md#changespeed) | **POST** /replay/changespeed | 
[**CheckReplaySession**](PricesApi.md#checkreplaysession) | **POST** /replay/checkreplaysession | 
[**InitializeClock**](PricesApi.md#initializeclock) | **POST** /replay/initializeclock | 

<a name="changespeed"></a>
# **ChangeSpeed**
> SimpleResponse ChangeSpeed (ChangeSpeed body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChangeSpeedExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new ChangeSpeed(); // ChangeSpeed | 

            try
            {
                SimpleResponse result = apiInstance.ChangeSpeed(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.ChangeSpeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeSpeed**](ChangeSpeed.md)|  | 

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="checkreplaysession"></a>
# **CheckReplaySession**
> CheckReplaySessionResponse CheckReplaySession (CheckReplaySession body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CheckReplaySessionExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new CheckReplaySession(); // CheckReplaySession | 

            try
            {
                CheckReplaySessionResponse result = apiInstance.CheckReplaySession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.CheckReplaySession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CheckReplaySession**](CheckReplaySession.md)|  | 

### Return type

[**CheckReplaySessionResponse**](CheckReplaySessionResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="initializeclock"></a>
# **InitializeClock**
> SimpleResponse InitializeClock (InitializeClock body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class InitializeClockExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new InitializeClock(); // InitializeClock | 

            try
            {
                SimpleResponse result = apiInstance.InitializeClock(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.InitializeClock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitializeClock**](InitializeClock.md)|  | 

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
