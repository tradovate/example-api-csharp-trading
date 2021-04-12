# Tradovate.Services.Api.FeesApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarketDataSubscriptionExchangeScopeFind**](FeesApi.md#marketdatasubscriptionexchangescopefind) | **GET** /marketDataSubscriptionExchangeScope/find | 
[**MarketDataSubscriptionExchangeScopeItem**](FeesApi.md#marketdatasubscriptionexchangescopeitem) | **GET** /marketDataSubscriptionExchangeScope/item | 
[**MarketDataSubscriptionExchangeScopeItems**](FeesApi.md#marketdatasubscriptionexchangescopeitems) | **GET** /marketDataSubscriptionExchangeScope/items | 
[**MarketDataSubscriptionExchangeScopeList**](FeesApi.md#marketdatasubscriptionexchangescopelist) | **GET** /marketDataSubscriptionExchangeScope/list | 
[**MarketDataSubscriptionExchangeScopeSuggest**](FeesApi.md#marketdatasubscriptionexchangescopesuggest) | **GET** /marketDataSubscriptionExchangeScope/suggest | 
[**MarketDataSubscriptionPlanFind**](FeesApi.md#marketdatasubscriptionplanfind) | **GET** /marketDataSubscriptionPlan/find | 
[**MarketDataSubscriptionPlanItem**](FeesApi.md#marketdatasubscriptionplanitem) | **GET** /marketDataSubscriptionPlan/item | 
[**MarketDataSubscriptionPlanItems**](FeesApi.md#marketdatasubscriptionplanitems) | **GET** /marketDataSubscriptionPlan/items | 
[**MarketDataSubscriptionPlanList**](FeesApi.md#marketdatasubscriptionplanlist) | **GET** /marketDataSubscriptionPlan/list | 
[**MarketDataSubscriptionPlanSuggest**](FeesApi.md#marketdatasubscriptionplansuggest) | **GET** /marketDataSubscriptionPlan/suggest | 
[**TradovateSubscriptionPlanFind**](FeesApi.md#tradovatesubscriptionplanfind) | **GET** /tradovateSubscriptionPlan/find | 
[**TradovateSubscriptionPlanItem**](FeesApi.md#tradovatesubscriptionplanitem) | **GET** /tradovateSubscriptionPlan/item | 
[**TradovateSubscriptionPlanItems**](FeesApi.md#tradovatesubscriptionplanitems) | **GET** /tradovateSubscriptionPlan/items | 
[**TradovateSubscriptionPlanList**](FeesApi.md#tradovatesubscriptionplanlist) | **GET** /tradovateSubscriptionPlan/list | 
[**TradovateSubscriptionPlanSuggest**](FeesApi.md#tradovatesubscriptionplansuggest) | **GET** /tradovateSubscriptionPlan/suggest | 

<a name="marketdatasubscriptionexchangescopefind"></a>
# **MarketDataSubscriptionExchangeScopeFind**
> MarketDataSubscriptionExchangeScope MarketDataSubscriptionExchangeScopeFind (string name)



Retrieves an entity of MarketDataSubscriptionExchangeScope type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionExchangeScopeFindExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                MarketDataSubscriptionExchangeScope result = apiInstance.MarketDataSubscriptionExchangeScopeFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionExchangeScopeFind: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**MarketDataSubscriptionExchangeScope**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionexchangescopeitem"></a>
# **MarketDataSubscriptionExchangeScopeItem**
> MarketDataSubscriptionExchangeScope MarketDataSubscriptionExchangeScopeItem (long? id)



Retrieves an entity of MarketDataSubscriptionExchangeScope type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionExchangeScopeItemExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var id = 789;  // long? | 

            try
            {
                MarketDataSubscriptionExchangeScope result = apiInstance.MarketDataSubscriptionExchangeScopeItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionExchangeScopeItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**MarketDataSubscriptionExchangeScope**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionexchangescopeitems"></a>
# **MarketDataSubscriptionExchangeScopeItems**
> List<MarketDataSubscriptionExchangeScope> MarketDataSubscriptionExchangeScopeItems (List<int?> ids)



Retrieves multiple entities of MarketDataSubscriptionExchangeScope type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionExchangeScopeItemsExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.MarketDataSubscriptionExchangeScopeItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionExchangeScopeItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionexchangescopelist"></a>
# **MarketDataSubscriptionExchangeScopeList**
> List<MarketDataSubscriptionExchangeScope> MarketDataSubscriptionExchangeScopeList ()



Retrieves all entities of MarketDataSubscriptionExchangeScope type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionExchangeScopeListExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.MarketDataSubscriptionExchangeScopeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionExchangeScopeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionexchangescopesuggest"></a>
# **MarketDataSubscriptionExchangeScopeSuggest**
> List<MarketDataSubscriptionExchangeScope> MarketDataSubscriptionExchangeScopeSuggest (string t, int? l)



Retrieves entities of MarketDataSubscriptionExchangeScope type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionExchangeScopeSuggestExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.MarketDataSubscriptionExchangeScopeSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionExchangeScopeSuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionplanfind"></a>
# **MarketDataSubscriptionPlanFind**
> MarketDataSubscriptionPlan MarketDataSubscriptionPlanFind (string name)



Retrieves an entity of MarketDataSubscriptionPlan type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionPlanFindExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                MarketDataSubscriptionPlan result = apiInstance.MarketDataSubscriptionPlanFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionPlanFind: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**MarketDataSubscriptionPlan**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionplanitem"></a>
# **MarketDataSubscriptionPlanItem**
> MarketDataSubscriptionPlan MarketDataSubscriptionPlanItem (long? id)



Retrieves an entity of MarketDataSubscriptionPlan type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionPlanItemExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var id = 789;  // long? | 

            try
            {
                MarketDataSubscriptionPlan result = apiInstance.MarketDataSubscriptionPlanItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionPlanItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**MarketDataSubscriptionPlan**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionplanitems"></a>
# **MarketDataSubscriptionPlanItems**
> List<MarketDataSubscriptionPlan> MarketDataSubscriptionPlanItems (List<int?> ids)



Retrieves multiple entities of MarketDataSubscriptionPlan type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionPlanItemsExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.MarketDataSubscriptionPlanItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionPlanItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionplanlist"></a>
# **MarketDataSubscriptionPlanList**
> List<MarketDataSubscriptionPlan> MarketDataSubscriptionPlanList ()



Retrieves all entities of MarketDataSubscriptionPlan type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionPlanListExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.MarketDataSubscriptionPlanList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionPlanList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marketdatasubscriptionplansuggest"></a>
# **MarketDataSubscriptionPlanSuggest**
> List<MarketDataSubscriptionPlan> MarketDataSubscriptionPlanSuggest (string t, int? l)



Retrieves entities of MarketDataSubscriptionPlan type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarketDataSubscriptionPlanSuggestExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.MarketDataSubscriptionPlanSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.MarketDataSubscriptionPlanSuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradovatesubscriptionplanfind"></a>
# **TradovateSubscriptionPlanFind**
> TradovateSubscriptionPlan TradovateSubscriptionPlanFind (string name)



Retrieves an entity of TradovateSubscriptionPlan type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradovateSubscriptionPlanFindExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                TradovateSubscriptionPlan result = apiInstance.TradovateSubscriptionPlanFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.TradovateSubscriptionPlanFind: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**TradovateSubscriptionPlan**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradovatesubscriptionplanitem"></a>
# **TradovateSubscriptionPlanItem**
> TradovateSubscriptionPlan TradovateSubscriptionPlanItem (long? id)



Retrieves an entity of TradovateSubscriptionPlan type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradovateSubscriptionPlanItemExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var id = 789;  // long? | 

            try
            {
                TradovateSubscriptionPlan result = apiInstance.TradovateSubscriptionPlanItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.TradovateSubscriptionPlanItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**TradovateSubscriptionPlan**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradovatesubscriptionplanitems"></a>
# **TradovateSubscriptionPlanItems**
> List<TradovateSubscriptionPlan> TradovateSubscriptionPlanItems (List<int?> ids)



Retrieves multiple entities of TradovateSubscriptionPlan type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradovateSubscriptionPlanItemsExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.TradovateSubscriptionPlanItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.TradovateSubscriptionPlanItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradovatesubscriptionplanlist"></a>
# **TradovateSubscriptionPlanList**
> List<TradovateSubscriptionPlan> TradovateSubscriptionPlanList ()



Retrieves all entities of TradovateSubscriptionPlan type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradovateSubscriptionPlanListExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.TradovateSubscriptionPlanList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.TradovateSubscriptionPlanList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradovatesubscriptionplansuggest"></a>
# **TradovateSubscriptionPlanSuggest**
> List<TradovateSubscriptionPlan> TradovateSubscriptionPlanSuggest (string t, int? l)



Retrieves entities of TradovateSubscriptionPlan type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradovateSubscriptionPlanSuggestExample
    {
        public void main()
        {

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.TradovateSubscriptionPlanSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.TradovateSubscriptionPlanSuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
