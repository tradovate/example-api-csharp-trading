# Tradovate.Services.Api.PositionsApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FillPairDependents**](PositionsApi.md#fillpairdependents) | **GET** /fillPair/deps | 
[**FillPairItem**](PositionsApi.md#fillpairitem) | **GET** /fillPair/item | 
[**FillPairItems**](PositionsApi.md#fillpairitems) | **GET** /fillPair/items | 
[**FillPairLDependents**](PositionsApi.md#fillpairldependents) | **GET** /fillPair/ldeps | 
[**FillPairList**](PositionsApi.md#fillpairlist) | **GET** /fillPair/list | 
[**PositionDependents**](PositionsApi.md#positiondependents) | **GET** /position/deps | 
[**PositionFind**](PositionsApi.md#positionfind) | **GET** /position/find | 
[**PositionItem**](PositionsApi.md#positionitem) | **GET** /position/item | 
[**PositionItems**](PositionsApi.md#positionitems) | **GET** /position/items | 
[**PositionLDependents**](PositionsApi.md#positionldependents) | **GET** /position/ldeps | 
[**PositionList**](PositionsApi.md#positionlist) | **GET** /position/list | 

<a name="fillpairdependents"></a>
# **FillPairDependents**
> List<FillPair> FillPairDependents (long? masterid)



Retrieves all entities of FillPair type related to Position entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillPairDependentsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var masterid = 789;  // long? | id of Position entity

            try
            {
                List&lt;FillPair&gt; result = apiInstance.FillPairDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FillPairDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Position entity | 

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillpairitem"></a>
# **FillPairItem**
> FillPair FillPairItem (long? id)



Retrieves an entity of FillPair type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillPairItemExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var id = 789;  // long? | 

            try
            {
                FillPair result = apiInstance.FillPairItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FillPairItem: " + e.Message );
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

[**FillPair**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillpairitems"></a>
# **FillPairItems**
> List<FillPair> FillPairItems (List<long?> ids)



Retrieves multiple entities of FillPair type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillPairItemsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;FillPair&gt; result = apiInstance.FillPairItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FillPairItems: " + e.Message );
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

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillpairldependents"></a>
# **FillPairLDependents**
> List<FillPair> FillPairLDependents (List<long?> masterids)



Retrieves all entities of FillPair type related to multiple entities of Position type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillPairLDependentsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var masterids = new List<long?>(); // List<long?> | ids of Position entities

            try
            {
                List&lt;FillPair&gt; result = apiInstance.FillPairLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FillPairLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Position entities | 

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillpairlist"></a>
# **FillPairList**
> List<FillPair> FillPairList ()



Retrieves all entities of FillPair type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillPairListExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();

            try
            {
                List&lt;FillPair&gt; result = apiInstance.FillPairList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FillPairList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positiondependents"></a>
# **PositionDependents**
> List<Position> PositionDependents (long? masterid)



Retrieves all entities of Position type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionDependentsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;Position&gt; result = apiInstance.PositionDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionDependents: " + e.Message );
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

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positionfind"></a>
# **PositionFind**
> Position PositionFind (string name)



Retrieves an entity of Position type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionFindExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var name = name_example;  // string | 

            try
            {
                Position result = apiInstance.PositionFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionFind: " + e.Message );
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

[**Position**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positionitem"></a>
# **PositionItem**
> Position PositionItem (long? id)



Retrieves an entity of Position type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionItemExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var id = 789;  // long? | 

            try
            {
                Position result = apiInstance.PositionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionItem: " + e.Message );
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

[**Position**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positionitems"></a>
# **PositionItems**
> List<Position> PositionItems (List<long?> ids)



Retrieves multiple entities of Position type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionItemsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Position&gt; result = apiInstance.PositionItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionItems: " + e.Message );
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

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positionldependents"></a>
# **PositionLDependents**
> List<Position> PositionLDependents (List<long?> masterids)



Retrieves all entities of Position type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionLDependentsExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();
            var masterids = new List<long?>(); // List<long?> | ids of Account entities

            try
            {
                List&lt;Position&gt; result = apiInstance.PositionLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionLDependents: " + e.Message );
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

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="positionlist"></a>
# **PositionList**
> List<Position> PositionList ()



Retrieves all entities of Position type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PositionListExample
    {
        public void main()
        {

            var apiInstance = new PositionsApi();

            try
            {
                List&lt;Position&gt; result = apiInstance.PositionList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.PositionList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
