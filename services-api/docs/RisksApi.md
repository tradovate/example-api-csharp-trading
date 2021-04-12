# Tradovate.Services.Api.RisksApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractMarginDependents**](RisksApi.md#contractmargindependents) | **GET** /contractMargin/deps | 
[**ContractMarginItem**](RisksApi.md#contractmarginitem) | **GET** /contractMargin/item | 
[**ContractMarginItems**](RisksApi.md#contractmarginitems) | **GET** /contractMargin/items | 
[**ContractMarginLDependents**](RisksApi.md#contractmarginldependents) | **GET** /contractMargin/ldeps | 
[**DeleteUserAccountPositionLimit**](RisksApi.md#deleteuseraccountpositionlimit) | **POST** /userAccountPositionLimit/deleteuseraccountpositionlimit | 
[**DeleteUserAccountRiskParameter**](RisksApi.md#deleteuseraccountriskparameter) | **POST** /userAccountPositionLimit/deleteuseraccountriskparameter | 
[**ProductMarginDependents**](RisksApi.md#productmargindependents) | **GET** /productMargin/deps | 
[**ProductMarginItem**](RisksApi.md#productmarginitem) | **GET** /productMargin/item | 
[**ProductMarginItems**](RisksApi.md#productmarginitems) | **GET** /productMargin/items | 
[**ProductMarginLDependents**](RisksApi.md#productmarginldependents) | **GET** /productMargin/ldeps | 
[**ProductMarginList**](RisksApi.md#productmarginlist) | **GET** /productMargin/list | 
[**UserAccountAutoLiqCreate**](RisksApi.md#useraccountautoliqcreate) | **POST** /userAccountAutoLiq/create | 
[**UserAccountAutoLiqDependents**](RisksApi.md#useraccountautoliqdependents) | **GET** /userAccountAutoLiq/deps | 
[**UserAccountAutoLiqItem**](RisksApi.md#useraccountautoliqitem) | **GET** /userAccountAutoLiq/item | 
[**UserAccountAutoLiqItems**](RisksApi.md#useraccountautoliqitems) | **GET** /userAccountAutoLiq/items | 
[**UserAccountAutoLiqLDependents**](RisksApi.md#useraccountautoliqldependents) | **GET** /userAccountAutoLiq/ldeps | 
[**UserAccountAutoLiqList**](RisksApi.md#useraccountautoliqlist) | **GET** /userAccountAutoLiq/list | 
[**UserAccountAutoLiqUpdate**](RisksApi.md#useraccountautoliqupdate) | **POST** /userAccountAutoLiq/update | 
[**UserAccountPositionLimitCreate**](RisksApi.md#useraccountpositionlimitcreate) | **POST** /userAccountPositionLimit/create | 
[**UserAccountPositionLimitDependents**](RisksApi.md#useraccountpositionlimitdependents) | **GET** /userAccountPositionLimit/deps | 
[**UserAccountPositionLimitItem**](RisksApi.md#useraccountpositionlimititem) | **GET** /userAccountPositionLimit/item | 
[**UserAccountPositionLimitItems**](RisksApi.md#useraccountpositionlimititems) | **GET** /userAccountPositionLimit/items | 
[**UserAccountPositionLimitLDependents**](RisksApi.md#useraccountpositionlimitldependents) | **GET** /userAccountPositionLimit/ldeps | 
[**UserAccountPositionLimitUpdate**](RisksApi.md#useraccountpositionlimitupdate) | **POST** /userAccountPositionLimit/update | 
[**UserAccountRiskParameterCreate**](RisksApi.md#useraccountriskparametercreate) | **POST** /userAccountRiskParameter/create | 
[**UserAccountRiskParameterDependents**](RisksApi.md#useraccountriskparameterdependents) | **GET** /userAccountRiskParameter/deps | 
[**UserAccountRiskParameterItem**](RisksApi.md#useraccountriskparameteritem) | **GET** /userAccountRiskParameter/item | 
[**UserAccountRiskParameterItems**](RisksApi.md#useraccountriskparameteritems) | **GET** /userAccountRiskParameter/items | 
[**UserAccountRiskParameterLDependents**](RisksApi.md#useraccountriskparameterldependents) | **GET** /userAccountRiskParameter/ldeps | 
[**UserAccountRiskParameterUpdate**](RisksApi.md#useraccountriskparameterupdate) | **POST** /userAccountRiskParameter/update | 

<a name="contractmargindependents"></a>
# **ContractMarginDependents**
> List<ContractMargin> ContractMarginDependents (long? masterid)



Retrieves all entities of ContractMargin type related to Contract entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMarginDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterid = 789;  // long? | id of Contract entity

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.ContractMarginDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ContractMarginDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Contract entity | 

### Return type

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmarginitem"></a>
# **ContractMarginItem**
> ContractMargin ContractMarginItem (long? id)



Retrieves an entity of ContractMargin type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMarginItemExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var id = 789;  // long? | 

            try
            {
                ContractMargin result = apiInstance.ContractMarginItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ContractMarginItem: " + e.Message );
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

[**ContractMargin**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmarginitems"></a>
# **ContractMarginItems**
> List<ContractMargin> ContractMarginItems (List<long?> ids)



Retrieves multiple entities of ContractMargin type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMarginItemsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.ContractMarginItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ContractMarginItems: " + e.Message );
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

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contractmarginldependents"></a>
# **ContractMarginLDependents**
> List<ContractMargin> ContractMarginLDependents (List<long?> masterids)



Retrieves all entities of ContractMargin type related to multiple entities of Contract type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ContractMarginLDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterids = new List<long?>(); // List<long?> | ids of Contract entities

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.ContractMarginLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ContractMarginLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Contract entities | 

### Return type

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuseraccountpositionlimit"></a>
# **DeleteUserAccountPositionLimit**
> DeleteResultResponse DeleteUserAccountPositionLimit (DeleteUserAccountPositionLimit body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DeleteUserAccountPositionLimitExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new DeleteUserAccountPositionLimit(); // DeleteUserAccountPositionLimit | 

            try
            {
                DeleteResultResponse result = apiInstance.DeleteUserAccountPositionLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.DeleteUserAccountPositionLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteUserAccountPositionLimit**](DeleteUserAccountPositionLimit.md)|  | 

### Return type

[**DeleteResultResponse**](DeleteResultResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuseraccountriskparameter"></a>
# **DeleteUserAccountRiskParameter**
> DeleteResultResponse DeleteUserAccountRiskParameter (DeleteUserAccountRiskParameter body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DeleteUserAccountRiskParameterExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new DeleteUserAccountRiskParameter(); // DeleteUserAccountRiskParameter | 

            try
            {
                DeleteResultResponse result = apiInstance.DeleteUserAccountRiskParameter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.DeleteUserAccountRiskParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteUserAccountRiskParameter**](DeleteUserAccountRiskParameter.md)|  | 

### Return type

[**DeleteResultResponse**](DeleteResultResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productmargindependents"></a>
# **ProductMarginDependents**
> List<ProductMargin> ProductMarginDependents (long? masterid)



Retrieves all entities of ProductMargin type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductMarginDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterid = 789;  // long? | id of Product entity

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.ProductMarginDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ProductMarginDependents: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productmarginitem"></a>
# **ProductMarginItem**
> ProductMargin ProductMarginItem (long? id)



Retrieves an entity of ProductMargin type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductMarginItemExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var id = 789;  // long? | 

            try
            {
                ProductMargin result = apiInstance.ProductMarginItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ProductMarginItem: " + e.Message );
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

[**ProductMargin**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productmarginitems"></a>
# **ProductMarginItems**
> List<ProductMargin> ProductMarginItems (List<long?> ids)



Retrieves multiple entities of ProductMargin type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductMarginItemsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.ProductMarginItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ProductMarginItems: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productmarginldependents"></a>
# **ProductMarginLDependents**
> List<ProductMargin> ProductMarginLDependents (List<long?> masterids)



Retrieves all entities of ProductMargin type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductMarginLDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterids = new List<long?>(); // List<long?> | ids of Product entities

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.ProductMarginLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ProductMarginLDependents: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="productmarginlist"></a>
# **ProductMarginList**
> List<ProductMargin> ProductMarginList ()



Retrieves all entities of ProductMargin type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ProductMarginListExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.ProductMarginList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.ProductMarginList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqcreate"></a>
# **UserAccountAutoLiqCreate**
> UserAccountAutoLiq UserAccountAutoLiqCreate (UserAccountAutoLiq body)



Creates a new entity of UserAccountAutoLiq

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqCreateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountAutoLiq(); // UserAccountAutoLiq | 

            try
            {
                UserAccountAutoLiq result = apiInstance.UserAccountAutoLiqCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountAutoLiq**](UserAccountAutoLiq.md)|  | 

### Return type

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqdependents"></a>
# **UserAccountAutoLiqDependents**
> List<UserAccountAutoLiq> UserAccountAutoLiqDependents (long? masterid)



Retrieves all entities of UserAccountAutoLiq type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.UserAccountAutoLiqDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Account entity | 

### Return type

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqitem"></a>
# **UserAccountAutoLiqItem**
> UserAccountAutoLiq UserAccountAutoLiqItem (long? id)



Retrieves an entity of UserAccountAutoLiq type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqItemExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var id = 789;  // long? | 

            try
            {
                UserAccountAutoLiq result = apiInstance.UserAccountAutoLiqItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqItem: " + e.Message );
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

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqitems"></a>
# **UserAccountAutoLiqItems**
> List<UserAccountAutoLiq> UserAccountAutoLiqItems (List<long?> ids)



Retrieves multiple entities of UserAccountAutoLiq type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqItemsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.UserAccountAutoLiqItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqItems: " + e.Message );
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

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqldependents"></a>
# **UserAccountAutoLiqLDependents**
> List<UserAccountAutoLiq> UserAccountAutoLiqLDependents (List<long?> masterids)



Retrieves all entities of UserAccountAutoLiq type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqLDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterids = new List<long?>(); // List<long?> | ids of Account entities

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.UserAccountAutoLiqLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Account entities | 

### Return type

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqlist"></a>
# **UserAccountAutoLiqList**
> List<UserAccountAutoLiq> UserAccountAutoLiqList ()



Retrieves all entities of UserAccountAutoLiq type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqListExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.UserAccountAutoLiqList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountautoliqupdate"></a>
# **UserAccountAutoLiqUpdate**
> UserAccountAutoLiq UserAccountAutoLiqUpdate (UserAccountAutoLiq body)



Updates an existing entity of UserAccountAutoLiq

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountAutoLiqUpdateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountAutoLiq(); // UserAccountAutoLiq | 

            try
            {
                UserAccountAutoLiq result = apiInstance.UserAccountAutoLiqUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountAutoLiqUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountAutoLiq**](UserAccountAutoLiq.md)|  | 

### Return type

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimitcreate"></a>
# **UserAccountPositionLimitCreate**
> UserAccountPositionLimit UserAccountPositionLimitCreate (UserAccountPositionLimit body)



Creates a new entity of UserAccountPositionLimit

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitCreateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountPositionLimit(); // UserAccountPositionLimit | 

            try
            {
                UserAccountPositionLimit result = apiInstance.UserAccountPositionLimitCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountPositionLimit**](UserAccountPositionLimit.md)|  | 

### Return type

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimitdependents"></a>
# **UserAccountPositionLimitDependents**
> List<UserAccountPositionLimit> UserAccountPositionLimitDependents (long? masterid)



Retrieves all entities of UserAccountPositionLimit type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.UserAccountPositionLimitDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Account entity | 

### Return type

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimititem"></a>
# **UserAccountPositionLimitItem**
> UserAccountPositionLimit UserAccountPositionLimitItem (long? id)



Retrieves an entity of UserAccountPositionLimit type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitItemExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var id = 789;  // long? | 

            try
            {
                UserAccountPositionLimit result = apiInstance.UserAccountPositionLimitItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitItem: " + e.Message );
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

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimititems"></a>
# **UserAccountPositionLimitItems**
> List<UserAccountPositionLimit> UserAccountPositionLimitItems (List<long?> ids)



Retrieves multiple entities of UserAccountPositionLimit type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitItemsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.UserAccountPositionLimitItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitItems: " + e.Message );
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

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimitldependents"></a>
# **UserAccountPositionLimitLDependents**
> List<UserAccountPositionLimit> UserAccountPositionLimitLDependents (List<long?> masterids)



Retrieves all entities of UserAccountPositionLimit type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitLDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterids = new List<long?>(); // List<long?> | ids of Account entities

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.UserAccountPositionLimitLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Account entities | 

### Return type

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountpositionlimitupdate"></a>
# **UserAccountPositionLimitUpdate**
> UserAccountPositionLimit UserAccountPositionLimitUpdate (UserAccountPositionLimit body)



Updates an existing entity of UserAccountPositionLimit

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountPositionLimitUpdateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountPositionLimit(); // UserAccountPositionLimit | 

            try
            {
                UserAccountPositionLimit result = apiInstance.UserAccountPositionLimitUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountPositionLimitUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountPositionLimit**](UserAccountPositionLimit.md)|  | 

### Return type

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparametercreate"></a>
# **UserAccountRiskParameterCreate**
> UserAccountRiskParameter UserAccountRiskParameterCreate (UserAccountRiskParameter body)



Creates a new entity of UserAccountRiskParameter

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterCreateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountRiskParameter(); // UserAccountRiskParameter | 

            try
            {
                UserAccountRiskParameter result = apiInstance.UserAccountRiskParameterCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountRiskParameter**](UserAccountRiskParameter.md)|  | 

### Return type

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparameterdependents"></a>
# **UserAccountRiskParameterDependents**
> List<UserAccountRiskParameter> UserAccountRiskParameterDependents (long? masterid)



Retrieves all entities of UserAccountRiskParameter type related to UserAccountPositionLimit entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterid = 789;  // long? | id of UserAccountPositionLimit entity

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.UserAccountRiskParameterDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of UserAccountPositionLimit entity | 

### Return type

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparameteritem"></a>
# **UserAccountRiskParameterItem**
> UserAccountRiskParameter UserAccountRiskParameterItem (long? id)



Retrieves an entity of UserAccountRiskParameter type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterItemExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var id = 789;  // long? | 

            try
            {
                UserAccountRiskParameter result = apiInstance.UserAccountRiskParameterItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterItem: " + e.Message );
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

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparameteritems"></a>
# **UserAccountRiskParameterItems**
> List<UserAccountRiskParameter> UserAccountRiskParameterItems (List<long?> ids)



Retrieves multiple entities of UserAccountRiskParameter type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterItemsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.UserAccountRiskParameterItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterItems: " + e.Message );
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

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparameterldependents"></a>
# **UserAccountRiskParameterLDependents**
> List<UserAccountRiskParameter> UserAccountRiskParameterLDependents (List<long?> masterids)



Retrieves all entities of UserAccountRiskParameter type related to multiple entities of UserAccountPositionLimit type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterLDependentsExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var masterids = new List<long?>(); // List<long?> | ids of UserAccountPositionLimit entities

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.UserAccountRiskParameterLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of UserAccountPositionLimit entities | 

### Return type

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="useraccountriskparameterupdate"></a>
# **UserAccountRiskParameterUpdate**
> UserAccountRiskParameter UserAccountRiskParameterUpdate (UserAccountRiskParameter body)



Updates an existing entity of UserAccountRiskParameter

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UserAccountRiskParameterUpdateExample
    {
        public void main()
        {

            var apiInstance = new RisksApi();
            var body = new UserAccountRiskParameter(); // UserAccountRiskParameter | 

            try
            {
                UserAccountRiskParameter result = apiInstance.UserAccountRiskParameterUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UserAccountRiskParameterUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountRiskParameter**](UserAccountRiskParameter.md)|  | 

### Return type

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
