# Tradovate.MarketData.Services.Api.PricesApi

All URIs are relative to *https://md-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelChart**](PricesApi.md#cancelchart) | **POST** /md/cancelchart | 
[**GetChart**](PricesApi.md#getchart) | **POST** /md/getchart | 
[**SubscribeDOM**](PricesApi.md#subscribedom) | **POST** /md/subscribedom | 
[**SubscribeHistogram**](PricesApi.md#subscribehistogram) | **POST** /md/subscribehistogram | 
[**SubscribeQuote**](PricesApi.md#subscribequote) | **POST** /md/subscribequote | 
[**UnsubscribeDOM**](PricesApi.md#unsubscribedom) | **POST** /md/unsubscribedom | 
[**UnsubscribeHistogram**](PricesApi.md#unsubscribehistogram) | **POST** /md/unsubscribehistogram | 
[**UnsubscribeQuote**](PricesApi.md#unsubscribequote) | **POST** /md/unsubscribequote | 

<a name="cancelchart"></a>
# **CancelChart**
> MarketDataSubscriptionResult CancelChart (CancelChart body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class CancelChartExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new CancelChart(); // CancelChart | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.CancelChart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.CancelChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CancelChart**](CancelChart.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getchart"></a>
# **GetChart**
> ChartSubscriptionResult GetChart (GetChart body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class GetChartExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new GetChart(); // GetChart | 

            try
            {
                ChartSubscriptionResult result = apiInstance.GetChart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetChart**](GetChart.md)|  | 

### Return type

[**ChartSubscriptionResult**](ChartSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="subscribedom"></a>
# **SubscribeDOM**
> MarketDataSubscriptionResult SubscribeDOM (SubscribeDOM body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class SubscribeDOMExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new SubscribeDOM(); // SubscribeDOM | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.SubscribeDOM(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.SubscribeDOM: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscribeDOM**](SubscribeDOM.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="subscribehistogram"></a>
# **SubscribeHistogram**
> MarketDataSubscriptionResult SubscribeHistogram (SubscribeHistogram body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class SubscribeHistogramExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new SubscribeHistogram(); // SubscribeHistogram | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.SubscribeHistogram(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.SubscribeHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscribeHistogram**](SubscribeHistogram.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="subscribequote"></a>
# **SubscribeQuote**
> MarketDataSubscriptionResult SubscribeQuote (SubscribeQuote body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class SubscribeQuoteExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new SubscribeQuote(); // SubscribeQuote | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.SubscribeQuote(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.SubscribeQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscribeQuote**](SubscribeQuote.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unsubscribedom"></a>
# **UnsubscribeDOM**
> MarketDataSubscriptionResult UnsubscribeDOM (UnsubscribeDOM body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class UnsubscribeDOMExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new UnsubscribeDOM(); // UnsubscribeDOM | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.UnsubscribeDOM(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.UnsubscribeDOM: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsubscribeDOM**](UnsubscribeDOM.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unsubscribehistogram"></a>
# **UnsubscribeHistogram**
> MarketDataSubscriptionResult UnsubscribeHistogram (UnsubscribeHistogram body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class UnsubscribeHistogramExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new UnsubscribeHistogram(); // UnsubscribeHistogram | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.UnsubscribeHistogram(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.UnsubscribeHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsubscribeHistogram**](UnsubscribeHistogram.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unsubscribequote"></a>
# **UnsubscribeQuote**
> MarketDataSubscriptionResult UnsubscribeQuote (UnsubscribeQuote body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;

namespace Example
{
    public class UnsubscribeQuoteExample
    {
        public void main()
        {

            var apiInstance = new PricesApi();
            var body = new UnsubscribeQuote(); // UnsubscribeQuote | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.UnsubscribeQuote(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.UnsubscribeQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsubscribeQuote**](UnsubscribeQuote.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
