# Tradovate.Services.Api.ConfigurationApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminAlertFind**](ConfigurationApi.md#adminalertfind) | **GET** /adminAlert/find | 
[**AdminAlertItem**](ConfigurationApi.md#adminalertitem) | **GET** /adminAlert/item | 
[**AdminAlertItems**](ConfigurationApi.md#adminalertitems) | **GET** /adminAlert/items | 
[**AdminAlertList**](ConfigurationApi.md#adminalertlist) | **GET** /adminAlert/list | 
[**AdminAlertSuggest**](ConfigurationApi.md#adminalertsuggest) | **GET** /adminAlert/suggest | 
[**ClearingHouseFind**](ConfigurationApi.md#clearinghousefind) | **GET** /clearingHouse/find | 
[**ClearingHouseItem**](ConfigurationApi.md#clearinghouseitem) | **GET** /clearingHouse/item | 
[**ClearingHouseItems**](ConfigurationApi.md#clearinghouseitems) | **GET** /clearingHouse/items | 
[**ClearingHouseList**](ConfigurationApi.md#clearinghouselist) | **GET** /clearingHouse/list | 
[**ClearingHouseSuggest**](ConfigurationApi.md#clearinghousesuggest) | **GET** /clearingHouse/suggest | 
[**EntitlementItem**](ConfigurationApi.md#entitlementitem) | **GET** /entitlement/item | 
[**EntitlementItems**](ConfigurationApi.md#entitlementitems) | **GET** /entitlement/items | 
[**EntitlementList**](ConfigurationApi.md#entitlementlist) | **GET** /entitlement/list | 
[**OrderStrategyTypeFind**](ConfigurationApi.md#orderstrategytypefind) | **GET** /orderStrategyType/find | 
[**OrderStrategyTypeItem**](ConfigurationApi.md#orderstrategytypeitem) | **GET** /orderStrategyType/item | 
[**OrderStrategyTypeItems**](ConfigurationApi.md#orderstrategytypeitems) | **GET** /orderStrategyType/items | 
[**OrderStrategyTypeList**](ConfigurationApi.md#orderstrategytypelist) | **GET** /orderStrategyType/list | 
[**OrderStrategyTypeSuggest**](ConfigurationApi.md#orderstrategytypesuggest) | **GET** /orderStrategyType/suggest | 
[**PropertyFind**](ConfigurationApi.md#propertyfind) | **GET** /property/find | 
[**PropertyItem**](ConfigurationApi.md#propertyitem) | **GET** /property/item | 
[**PropertyItems**](ConfigurationApi.md#propertyitems) | **GET** /property/items | 
[**PropertyList**](ConfigurationApi.md#propertylist) | **GET** /property/list | 
[**PropertySuggest**](ConfigurationApi.md#propertysuggest) | **GET** /property/suggest | 

<a name="adminalertfind"></a>
# **AdminAlertFind**
> AdminAlert AdminAlertFind (string name)



Retrieves an entity of AdminAlert type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertFindExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var name = name_example;  // string | 

            try
            {
                AdminAlert result = apiInstance.AdminAlertFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.AdminAlertFind: " + e.Message );
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

[**AdminAlert**](AdminAlert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertitem"></a>
# **AdminAlertItem**
> AdminAlert AdminAlertItem (long? id)



Retrieves an entity of AdminAlert type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertItemExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var id = 789;  // long? | 

            try
            {
                AdminAlert result = apiInstance.AdminAlertItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.AdminAlertItem: " + e.Message );
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

[**AdminAlert**](AdminAlert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertitems"></a>
# **AdminAlertItems**
> List<AdminAlert> AdminAlertItems (List<long?> ids)



Retrieves multiple entities of AdminAlert type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertItemsExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;AdminAlert&gt; result = apiInstance.AdminAlertItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.AdminAlertItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)|  | 

### Return type

[**List<AdminAlert>**](AdminAlert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertlist"></a>
# **AdminAlertList**
> List<AdminAlert> AdminAlertList ()



Retrieves all entities of AdminAlert type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertListExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();

            try
            {
                List&lt;AdminAlert&gt; result = apiInstance.AdminAlertList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.AdminAlertList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AdminAlert>**](AdminAlert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertsuggest"></a>
# **AdminAlertSuggest**
> List<AdminAlert> AdminAlertSuggest (string t, int? l)



Retrieves entities of AdminAlert type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSuggestExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;AdminAlert&gt; result = apiInstance.AdminAlertSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.AdminAlertSuggest: " + e.Message );
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

[**List<AdminAlert>**](AdminAlert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearinghousefind"></a>
# **ClearingHouseFind**
> ClearingHouse ClearingHouseFind (string name)



Retrieves an entity of ClearingHouse type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ClearingHouseFindExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var name = name_example;  // string | 

            try
            {
                ClearingHouse result = apiInstance.ClearingHouseFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ClearingHouseFind: " + e.Message );
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

[**ClearingHouse**](ClearingHouse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearinghouseitem"></a>
# **ClearingHouseItem**
> ClearingHouse ClearingHouseItem (long? id)



Retrieves an entity of ClearingHouse type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ClearingHouseItemExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var id = 789;  // long? | 

            try
            {
                ClearingHouse result = apiInstance.ClearingHouseItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ClearingHouseItem: " + e.Message );
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

[**ClearingHouse**](ClearingHouse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearinghouseitems"></a>
# **ClearingHouseItems**
> List<ClearingHouse> ClearingHouseItems (List<long?> ids)



Retrieves multiple entities of ClearingHouse type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ClearingHouseItemsExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ClearingHouse&gt; result = apiInstance.ClearingHouseItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ClearingHouseItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)|  | 

### Return type

[**List<ClearingHouse>**](ClearingHouse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearinghouselist"></a>
# **ClearingHouseList**
> List<ClearingHouse> ClearingHouseList ()



Retrieves all entities of ClearingHouse type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ClearingHouseListExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();

            try
            {
                List&lt;ClearingHouse&gt; result = apiInstance.ClearingHouseList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ClearingHouseList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ClearingHouse>**](ClearingHouse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="clearinghousesuggest"></a>
# **ClearingHouseSuggest**
> List<ClearingHouse> ClearingHouseSuggest (string t, int? l)



Retrieves entities of ClearingHouse type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ClearingHouseSuggestExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;ClearingHouse&gt; result = apiInstance.ClearingHouseSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ClearingHouseSuggest: " + e.Message );
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

[**List<ClearingHouse>**](ClearingHouse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="entitlementitem"></a>
# **EntitlementItem**
> Entitlement EntitlementItem (long? id)



Retrieves an entity of Entitlement type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class EntitlementItemExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var id = 789;  // long? | 

            try
            {
                Entitlement result = apiInstance.EntitlementItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.EntitlementItem: " + e.Message );
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

[**Entitlement**](Entitlement.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="entitlementitems"></a>
# **EntitlementItems**
> List<Entitlement> EntitlementItems (List<long?> ids)



Retrieves multiple entities of Entitlement type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class EntitlementItemsExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Entitlement&gt; result = apiInstance.EntitlementItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.EntitlementItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)|  | 

### Return type

[**List<Entitlement>**](Entitlement.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="entitlementlist"></a>
# **EntitlementList**
> List<Entitlement> EntitlementList ()



Retrieves all entities of Entitlement type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class EntitlementListExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();

            try
            {
                List&lt;Entitlement&gt; result = apiInstance.EntitlementList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.EntitlementList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Entitlement>**](Entitlement.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategytypefind"></a>
# **OrderStrategyTypeFind**
> OrderStrategyType OrderStrategyTypeFind (string name)



Retrieves an entity of OrderStrategyType type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyTypeFindExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var name = name_example;  // string | 

            try
            {
                OrderStrategyType result = apiInstance.OrderStrategyTypeFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OrderStrategyTypeFind: " + e.Message );
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

[**OrderStrategyType**](OrderStrategyType.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategytypeitem"></a>
# **OrderStrategyTypeItem**
> OrderStrategyType OrderStrategyTypeItem (long? id)



Retrieves an entity of OrderStrategyType type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyTypeItemExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var id = 789;  // long? | 

            try
            {
                OrderStrategyType result = apiInstance.OrderStrategyTypeItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OrderStrategyTypeItem: " + e.Message );
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

[**OrderStrategyType**](OrderStrategyType.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategytypeitems"></a>
# **OrderStrategyTypeItems**
> List<OrderStrategyType> OrderStrategyTypeItems (List<long?> ids)



Retrieves multiple entities of OrderStrategyType type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyTypeItemsExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;OrderStrategyType&gt; result = apiInstance.OrderStrategyTypeItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OrderStrategyTypeItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)|  | 

### Return type

[**List<OrderStrategyType>**](OrderStrategyType.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategytypelist"></a>
# **OrderStrategyTypeList**
> List<OrderStrategyType> OrderStrategyTypeList ()



Retrieves all entities of OrderStrategyType type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyTypeListExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();

            try
            {
                List&lt;OrderStrategyType&gt; result = apiInstance.OrderStrategyTypeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OrderStrategyTypeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrderStrategyType>**](OrderStrategyType.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategytypesuggest"></a>
# **OrderStrategyTypeSuggest**
> List<OrderStrategyType> OrderStrategyTypeSuggest (string t, int? l)



Retrieves entities of OrderStrategyType type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyTypeSuggestExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;OrderStrategyType&gt; result = apiInstance.OrderStrategyTypeSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OrderStrategyTypeSuggest: " + e.Message );
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

[**List<OrderStrategyType>**](OrderStrategyType.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="propertyfind"></a>
# **PropertyFind**
> Property PropertyFind (string name)



Retrieves an entity of Property type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PropertyFindExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var name = name_example;  // string | 

            try
            {
                Property result = apiInstance.PropertyFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PropertyFind: " + e.Message );
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

[**Property**](Property.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="propertyitem"></a>
# **PropertyItem**
> Property PropertyItem (long? id)



Retrieves an entity of Property type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PropertyItemExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var id = 789;  // long? | 

            try
            {
                Property result = apiInstance.PropertyItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PropertyItem: " + e.Message );
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

[**Property**](Property.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="propertyitems"></a>
# **PropertyItems**
> List<Property> PropertyItems (List<long?> ids)



Retrieves multiple entities of Property type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PropertyItemsExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Property&gt; result = apiInstance.PropertyItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PropertyItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)|  | 

### Return type

[**List<Property>**](Property.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="propertylist"></a>
# **PropertyList**
> List<Property> PropertyList ()



Retrieves all entities of Property type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PropertyListExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();

            try
            {
                List&lt;Property&gt; result = apiInstance.PropertyList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PropertyList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Property>**](Property.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="propertysuggest"></a>
# **PropertySuggest**
> List<Property> PropertySuggest (string t, int? l)



Retrieves entities of Property type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PropertySuggestExample
    {
        public void main()
        {

            var apiInstance = new ConfigurationApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Property&gt; result = apiInstance.PropertySuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PropertySuggest: " + e.Message );
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

[**List<Property>**](Property.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
