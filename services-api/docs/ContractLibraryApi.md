# Tradovate.Services.Api.ContractLibraryApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractDependents**](ContractLibraryApi.md#contractdependents) | **GET** /contract/deps | 
[**ContractFind**](ContractLibraryApi.md#contractfind) | **GET** /contract/find | 
[**ContractGroupFind**](ContractLibraryApi.md#contractgroupfind) | **GET** /contractGroup/find | 
[**ContractGroupItem**](ContractLibraryApi.md#contractgroupitem) | **GET** /contractGroup/item | 
[**ContractGroupItems**](ContractLibraryApi.md#contractgroupitems) | **GET** /contractGroup/items | 
[**ContractGroupList**](ContractLibraryApi.md#contractgrouplist) | **GET** /contractGroup/list | 
[**ContractGroupSuggest**](ContractLibraryApi.md#contractgroupsuggest) | **GET** /contractGroup/suggest | 
[**ContractItem**](ContractLibraryApi.md#contractitem) | **GET** /contract/item | 
[**ContractItems**](ContractLibraryApi.md#contractitems) | **GET** /contract/items | 
[**ContractLDependents**](ContractLibraryApi.md#contractldependents) | **GET** /contract/ldeps | 
[**ContractMaturityDependents**](ContractLibraryApi.md#contractmaturitydependents) | **GET** /contractMaturity/deps | 
[**ContractMaturityItem**](ContractLibraryApi.md#contractmaturityitem) | **GET** /contractMaturity/item | 
[**ContractMaturityItems**](ContractLibraryApi.md#contractmaturityitems) | **GET** /contractMaturity/items | 
[**ContractMaturityLDependents**](ContractLibraryApi.md#contractmaturityldependents) | **GET** /contractMaturity/ldeps | 
[**ContractSuggest**](ContractLibraryApi.md#contractsuggest) | **GET** /contract/suggest | 
[**CurrencyFind**](ContractLibraryApi.md#currencyfind) | **GET** /currency/find | 
[**CurrencyItem**](ContractLibraryApi.md#currencyitem) | **GET** /currency/item | 
[**CurrencyItems**](ContractLibraryApi.md#currencyitems) | **GET** /currency/items | 
[**CurrencyList**](ContractLibraryApi.md#currencylist) | **GET** /currency/list | 
[**CurrencyRateDependents**](ContractLibraryApi.md#currencyratedependents) | **GET** /currencyRate/deps | 
[**CurrencyRateItem**](ContractLibraryApi.md#currencyrateitem) | **GET** /currencyRate/item | 
[**CurrencyRateItems**](ContractLibraryApi.md#currencyrateitems) | **GET** /currencyRate/items | 
[**CurrencyRateLDependents**](ContractLibraryApi.md#currencyrateldependents) | **GET** /currencyRate/ldeps | 
[**CurrencyRateList**](ContractLibraryApi.md#currencyratelist) | **GET** /currencyRate/list | 
[**CurrencySuggest**](ContractLibraryApi.md#currencysuggest) | **GET** /currency/suggest | 
[**ExchangeFind**](ContractLibraryApi.md#exchangefind) | **GET** /exchange/find | 
[**ExchangeItem**](ContractLibraryApi.md#exchangeitem) | **GET** /exchange/item | 
[**ExchangeItems**](ContractLibraryApi.md#exchangeitems) | **GET** /exchange/items | 
[**ExchangeList**](ContractLibraryApi.md#exchangelist) | **GET** /exchange/list | 
[**ExchangeSuggest**](ContractLibraryApi.md#exchangesuggest) | **GET** /exchange/suggest | 
[**GetProductFeeParams**](ContractLibraryApi.md#getproductfeeparams) | **POST** /contract/getproductfeeparams | 
[**ProductDependents**](ContractLibraryApi.md#productdependents) | **GET** /product/deps | 
[**ProductFind**](ContractLibraryApi.md#productfind) | **GET** /product/find | 
[**ProductItem**](ContractLibraryApi.md#productitem) | **GET** /product/item | 
[**ProductItems**](ContractLibraryApi.md#productitems) | **GET** /product/items | 
[**ProductLDependents**](ContractLibraryApi.md#productldependents) | **GET** /product/ldeps | 
[**ProductList**](ContractLibraryApi.md#productlist) | **GET** /product/list | 
[**ProductSessionDependents**](ContractLibraryApi.md#productsessiondependents) | **GET** /productSession/deps | 
[**ProductSessionItem**](ContractLibraryApi.md#productsessionitem) | **GET** /productSession/item | 
[**ProductSessionItems**](ContractLibraryApi.md#productsessionitems) | **GET** /productSession/items | 
[**ProductSessionLDependents**](ContractLibraryApi.md#productsessionldependents) | **GET** /productSession/ldeps | 
[**ProductSuggest**](ContractLibraryApi.md#productsuggest) | **GET** /product/suggest | 
[**RollContract**](ContractLibraryApi.md#rollcontract) | **POST** /contract/rollcontract | 
[**SpreadDefinitionItem**](ContractLibraryApi.md#spreaddefinitionitem) | **GET** /spreadDefinition/item | 
[**SpreadDefinitionItems**](ContractLibraryApi.md#spreaddefinitionitems) | **GET** /spreadDefinition/items | 

<a name="contractdependents"></a>
# **ContractDependents**
> List<Contract> ContractDependents (long? masterid)



Retrieves all entities of Contract type related to ContractMaturity entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterid = 789;  // long? | id of ContractMaturity entity

            try
            {
                List&lt;Contract&gt; result = apiInstance.ContractDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of ContractMaturity entity | 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractfind"></a>
# **ContractFind**
> Contract ContractFind (string name)



Retrieves an entity of Contract type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractFindExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Contract result = apiInstance.ContractFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractFind: " + e.Message );
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

[**Contract**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractgroupfind"></a>
# **ContractGroupFind**
> ContractGroup ContractGroupFind (string name)



Retrieves an entity of ContractGroup type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractGroupFindExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                ContractGroup result = apiInstance.ContractGroupFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractGroupFind: " + e.Message );
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

[**ContractGroup**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractgroupitem"></a>
# **ContractGroupItem**
> ContractGroup ContractGroupItem (long? id)



Retrieves an entity of ContractGroup type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractGroupItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                ContractGroup result = apiInstance.ContractGroupItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractGroupItem: " + e.Message );
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

[**ContractGroup**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractgroupitems"></a>
# **ContractGroupItems**
> List<ContractGroup> ContractGroupItems (List<long?> ids)



Retrieves multiple entities of ContractGroup type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractGroupItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.ContractGroupItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractGroupItems: " + e.Message );
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

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractgrouplist"></a>
# **ContractGroupList**
> List<ContractGroup> ContractGroupList ()



Retrieves all entities of ContractGroup type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractGroupListExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.ContractGroupList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractGroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractgroupsuggest"></a>
# **ContractGroupSuggest**
> List<ContractGroup> ContractGroupSuggest (string t, int? l)



Retrieves entities of ContractGroup type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractGroupSuggestExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.ContractGroupSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractGroupSuggest: " + e.Message );
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

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractitem"></a>
# **ContractItem**
> Contract ContractItem (long? id)



Retrieves an entity of Contract type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                Contract result = apiInstance.ContractItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractItem: " + e.Message );
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

[**Contract**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractitems"></a>
# **ContractItems**
> List<Contract> ContractItems (List<long?> ids)



Retrieves multiple entities of Contract type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Contract&gt; result = apiInstance.ContractItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractItems: " + e.Message );
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

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractldependents"></a>
# **ContractLDependents**
> List<Contract> ContractLDependents (List<long?> masterids)



Retrieves all entities of Contract type related to multiple entities of ContractMaturity type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<long?>(); // List<long?> | ids of ContractMaturity entities

            try
            {
                List&lt;Contract&gt; result = apiInstance.ContractLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of ContractMaturity entities | 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmaturitydependents"></a>
# **ContractMaturityDependents**
> List<ContractMaturity> ContractMaturityDependents (long? masterid)



Retrieves all entities of ContractMaturity type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMaturityDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterid = 789;  // long? | id of Product entity

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.ContractMaturityDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractMaturityDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Product entity | 

### Return type

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmaturityitem"></a>
# **ContractMaturityItem**
> ContractMaturity ContractMaturityItem (long? id)



Retrieves an entity of ContractMaturity type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMaturityItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                ContractMaturity result = apiInstance.ContractMaturityItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractMaturityItem: " + e.Message );
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

[**ContractMaturity**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmaturityitems"></a>
# **ContractMaturityItems**
> List<ContractMaturity> ContractMaturityItems (List<long?> ids)



Retrieves multiple entities of ContractMaturity type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMaturityItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.ContractMaturityItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractMaturityItems: " + e.Message );
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

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmaturityldependents"></a>
# **ContractMaturityLDependents**
> List<ContractMaturity> ContractMaturityLDependents (List<long?> masterids)



Retrieves all entities of ContractMaturity type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMaturityLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<long?>(); // List<long?> | ids of Product entities

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.ContractMaturityLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractMaturityLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Product entities | 

### Return type

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractsuggest"></a>
# **ContractSuggest**
> List<Contract> ContractSuggest (string t, int? l)



Retrieves entities of Contract type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractSuggestExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Contract&gt; result = apiInstance.ContractSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ContractSuggest: " + e.Message );
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

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyfind"></a>
# **CurrencyFind**
> Currency CurrencyFind (string name)



Retrieves an entity of Currency type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyFindExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Currency result = apiInstance.CurrencyFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyFind: " + e.Message );
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

[**Currency**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyitem"></a>
# **CurrencyItem**
> Currency CurrencyItem (long? id)



Retrieves an entity of Currency type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                Currency result = apiInstance.CurrencyItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyItem: " + e.Message );
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

[**Currency**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyitems"></a>
# **CurrencyItems**
> List<Currency> CurrencyItems (List<long?> ids)



Retrieves multiple entities of Currency type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Currency&gt; result = apiInstance.CurrencyItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyItems: " + e.Message );
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

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencylist"></a>
# **CurrencyList**
> List<Currency> CurrencyList ()



Retrieves all entities of Currency type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyListExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Currency&gt; result = apiInstance.CurrencyList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyratedependents"></a>
# **CurrencyRateDependents**
> List<CurrencyRate> CurrencyRateDependents (long? masterid)



Retrieves all entities of CurrencyRate type related to Currency entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyRateDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterid = 789;  // long? | id of Currency entity

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.CurrencyRateDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyRateDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Currency entity | 

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyrateitem"></a>
# **CurrencyRateItem**
> CurrencyRate CurrencyRateItem (long? id)



Retrieves an entity of CurrencyRate type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyRateItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                CurrencyRate result = apiInstance.CurrencyRateItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyRateItem: " + e.Message );
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

[**CurrencyRate**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyrateitems"></a>
# **CurrencyRateItems**
> List<CurrencyRate> CurrencyRateItems (List<long?> ids)



Retrieves multiple entities of CurrencyRate type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyRateItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.CurrencyRateItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyRateItems: " + e.Message );
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

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyrateldependents"></a>
# **CurrencyRateLDependents**
> List<CurrencyRate> CurrencyRateLDependents (List<long?> masterids)



Retrieves all entities of CurrencyRate type related to multiple entities of Currency type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyRateLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<long?>(); // List<long?> | ids of Currency entities

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.CurrencyRateLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyRateLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Currency entities | 

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencyratelist"></a>
# **CurrencyRateList**
> List<CurrencyRate> CurrencyRateList ()



Retrieves all entities of CurrencyRate type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencyRateListExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.CurrencyRateList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencyRateList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencysuggest"></a>
# **CurrencySuggest**
> List<Currency> CurrencySuggest (string t, int? l)



Retrieves entities of Currency type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CurrencySuggestExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Currency&gt; result = apiInstance.CurrencySuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.CurrencySuggest: " + e.Message );
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

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exchangefind"></a>
# **ExchangeFind**
> Exchange ExchangeFind (string name)



Retrieves an entity of Exchange type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExchangeFindExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Exchange result = apiInstance.ExchangeFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ExchangeFind: " + e.Message );
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

[**Exchange**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exchangeitem"></a>
# **ExchangeItem**
> Exchange ExchangeItem (long? id)



Retrieves an entity of Exchange type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExchangeItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                Exchange result = apiInstance.ExchangeItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ExchangeItem: " + e.Message );
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

[**Exchange**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exchangeitems"></a>
# **ExchangeItems**
> List<Exchange> ExchangeItems (List<long?> ids)



Retrieves multiple entities of Exchange type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExchangeItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Exchange&gt; result = apiInstance.ExchangeItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ExchangeItems: " + e.Message );
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

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exchangelist"></a>
# **ExchangeList**
> List<Exchange> ExchangeList ()



Retrieves all entities of Exchange type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExchangeListExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Exchange&gt; result = apiInstance.ExchangeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ExchangeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="exchangesuggest"></a>
# **ExchangeSuggest**
> List<Exchange> ExchangeSuggest (string t, int? l)



Retrieves entities of Exchange type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExchangeSuggestExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Exchange&gt; result = apiInstance.ExchangeSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ExchangeSuggest: " + e.Message );
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

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductfeeparams"></a>
# **GetProductFeeParams**
> ProductFeeParamsResponse GetProductFeeParams (GetProductFeeParams body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductFeeParamsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var body = new GetProductFeeParams(); // GetProductFeeParams | 

            try
            {
                ProductFeeParamsResponse result = apiInstance.GetProductFeeParams(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProductFeeParams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetProductFeeParams**](GetProductFeeParams.md)|  | 

### Return type

[**ProductFeeParamsResponse**](ProductFeeParamsResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productdependents"></a>
# **ProductDependents**
> List<Product> ProductDependents (long? masterid)



Retrieves all entities of Product type related to Exchange entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterid = 789;  // long? | id of Exchange entity

            try
            {
                List&lt;Product&gt; result = apiInstance.ProductDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Exchange entity | 

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productfind"></a>
# **ProductFind**
> Product ProductFind (string name)



Retrieves an entity of Product type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductFindExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Product result = apiInstance.ProductFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductFind: " + e.Message );
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

[**Product**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productitem"></a>
# **ProductItem**
> Product ProductItem (long? id)



Retrieves an entity of Product type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                Product result = apiInstance.ProductItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductItem: " + e.Message );
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

[**Product**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productitems"></a>
# **ProductItems**
> List<Product> ProductItems (List<long?> ids)



Retrieves multiple entities of Product type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Product&gt; result = apiInstance.ProductItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductItems: " + e.Message );
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

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productldependents"></a>
# **ProductLDependents**
> List<Product> ProductLDependents (List<long?> masterids)



Retrieves all entities of Product type related to multiple entities of Exchange type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<long?>(); // List<long?> | ids of Exchange entities

            try
            {
                List&lt;Product&gt; result = apiInstance.ProductLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Exchange entities | 

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productlist"></a>
# **ProductList**
> List<Product> ProductList ()



Retrieves all entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductListExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Product&gt; result = apiInstance.ProductList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsessiondependents"></a>
# **ProductSessionDependents**
> List<ProductSession> ProductSessionDependents (long? masterid)



Retrieves all entities of ProductSession type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductSessionDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterid = 789;  // long? | id of Product entity

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.ProductSessionDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductSessionDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Product entity | 

### Return type

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsessionitem"></a>
# **ProductSessionItem**
> ProductSession ProductSessionItem (long? id)



Retrieves an entity of ProductSession type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductSessionItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                ProductSession result = apiInstance.ProductSessionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductSessionItem: " + e.Message );
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

[**ProductSession**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsessionitems"></a>
# **ProductSessionItems**
> List<ProductSession> ProductSessionItems (List<long?> ids)



Retrieves multiple entities of ProductSession type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductSessionItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.ProductSessionItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductSessionItems: " + e.Message );
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

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsessionldependents"></a>
# **ProductSessionLDependents**
> List<ProductSession> ProductSessionLDependents (List<long?> masterids)



Retrieves all entities of ProductSession type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductSessionLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<long?>(); // List<long?> | ids of Product entities

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.ProductSessionLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductSessionLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Product entities | 

### Return type

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productsuggest"></a>
# **ProductSuggest**
> List<Product> ProductSuggest (string t, int? l)



Retrieves entities of Product type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductSuggestExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Product&gt; result = apiInstance.ProductSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.ProductSuggest: " + e.Message );
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

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="rollcontract"></a>
# **RollContract**
> RollContractResponse RollContract (RollContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class RollContractExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var body = new RollContract(); // RollContract | 

            try
            {
                RollContractResponse result = apiInstance.RollContract(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.RollContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RollContract**](RollContract.md)|  | 

### Return type

[**RollContractResponse**](RollContractResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="spreaddefinitionitem"></a>
# **SpreadDefinitionItem**
> SpreadDefinition SpreadDefinitionItem (long? id)



Retrieves an entity of SpreadDefinition type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SpreadDefinitionItemExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var id = 789;  // long? | 

            try
            {
                SpreadDefinition result = apiInstance.SpreadDefinitionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SpreadDefinitionItem: " + e.Message );
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

[**SpreadDefinition**](SpreadDefinition.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="spreaddefinitionitems"></a>
# **SpreadDefinitionItems**
> List<SpreadDefinition> SpreadDefinitionItems (List<long?> ids)



Retrieves multiple entities of SpreadDefinition type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SpreadDefinitionItemsExample
    {
        public void main()
        {

            var apiInstance = new ContractLibraryApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;SpreadDefinition&gt; result = apiInstance.SpreadDefinitionItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SpreadDefinitionItems: " + e.Message );
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

[**List<SpreadDefinition>**](SpreadDefinition.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
