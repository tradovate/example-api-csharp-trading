# Tradovate.Services.Api.AlertsApi

All URIs are relative to *https://demo.tradovateapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminAlertSignalDependents**](AlertsApi.md#adminalertsignaldependents) | **GET** /adminAlertSignal/deps | 
[**AdminAlertSignalItem**](AlertsApi.md#adminalertsignalitem) | **GET** /adminAlertSignal/item | 
[**AdminAlertSignalItems**](AlertsApi.md#adminalertsignalitems) | **GET** /adminAlertSignal/items | 
[**AdminAlertSignalLDependents**](AlertsApi.md#adminalertsignalldependents) | **GET** /adminAlertSignal/ldeps | 
[**AdminAlertSignalList**](AlertsApi.md#adminalertsignallist) | **GET** /adminAlertSignal/list | 
[**AlertDependents**](AlertsApi.md#alertdependents) | **GET** /alert/deps | 
[**AlertItem**](AlertsApi.md#alertitem) | **GET** /alert/item | 
[**AlertItems**](AlertsApi.md#alertitems) | **GET** /alert/items | 
[**AlertLDependents**](AlertsApi.md#alertldependents) | **GET** /alert/ldeps | 
[**AlertList**](AlertsApi.md#alertlist) | **GET** /alert/list | 
[**AlertSignalDependents**](AlertsApi.md#alertsignaldependents) | **GET** /alertSignal/deps | 
[**AlertSignalItem**](AlertsApi.md#alertsignalitem) | **GET** /alertSignal/item | 
[**AlertSignalItems**](AlertsApi.md#alertsignalitems) | **GET** /alertSignal/items | 
[**AlertSignalLDependents**](AlertsApi.md#alertsignalldependents) | **GET** /alertSignal/ldeps | 
[**AlertSignalList**](AlertsApi.md#alertsignallist) | **GET** /alertSignal/list | 
[**CompleteAlertSignal**](AlertsApi.md#completealertsignal) | **POST** /adminAlertSignal/completealertsignal | 
[**CreateAlert**](AlertsApi.md#createalert) | **POST** /alert/createalert | 
[**DeleteAlert**](AlertsApi.md#deletealert) | **POST** /alert/deletealert | 
[**DismissAlert**](AlertsApi.md#dismissalert) | **POST** /alert/dismissalert | 
[**MarkReadAlertSignal**](AlertsApi.md#markreadalertsignal) | **POST** /alert/markreadalertsignal | 
[**ModifyAlert**](AlertsApi.md#modifyalert) | **POST** /alert/modifyalert | 
[**ResetAlert**](AlertsApi.md#resetalert) | **POST** /alert/resetalert | 
[**TakeAlertSignalOwnership**](AlertsApi.md#takealertsignalownership) | **POST** /adminAlertSignal/takealertsignalownership | 

<a name="adminalertsignaldependents"></a>
# **AdminAlertSignalDependents**
> List<AdminAlertSignal> AdminAlertSignalDependents (long? masterid)



Retrieves all entities of AdminAlertSignal type related to AdminAlert entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSignalDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterid = 789;  // long? | id of AdminAlert entity

            try
            {
                List&lt;AdminAlertSignal&gt; result = apiInstance.AdminAlertSignalDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AdminAlertSignalDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of AdminAlert entity | 

### Return type

[**List<AdminAlertSignal>**](AdminAlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertsignalitem"></a>
# **AdminAlertSignalItem**
> AdminAlertSignal AdminAlertSignalItem (long? id)



Retrieves an entity of AdminAlertSignal type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSignalItemExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var id = 789;  // long? | 

            try
            {
                AdminAlertSignal result = apiInstance.AdminAlertSignalItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AdminAlertSignalItem: " + e.Message );
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

[**AdminAlertSignal**](AdminAlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertsignalitems"></a>
# **AdminAlertSignalItems**
> List<AdminAlertSignal> AdminAlertSignalItems (List<long?> ids)



Retrieves multiple entities of AdminAlertSignal type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSignalItemsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;AdminAlertSignal&gt; result = apiInstance.AdminAlertSignalItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AdminAlertSignalItems: " + e.Message );
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

[**List<AdminAlertSignal>**](AdminAlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertsignalldependents"></a>
# **AdminAlertSignalLDependents**
> List<AdminAlertSignal> AdminAlertSignalLDependents (List<long?> masterids)



Retrieves all entities of AdminAlertSignal type related to multiple entities of AdminAlert type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSignalLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterids = new List<long?>(); // List<long?> | ids of AdminAlert entities

            try
            {
                List&lt;AdminAlertSignal&gt; result = apiInstance.AdminAlertSignalLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AdminAlertSignalLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of AdminAlert entities | 

### Return type

[**List<AdminAlertSignal>**](AdminAlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adminalertsignallist"></a>
# **AdminAlertSignalList**
> List<AdminAlertSignal> AdminAlertSignalList ()



Retrieves all entities of AdminAlertSignal type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AdminAlertSignalListExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();

            try
            {
                List&lt;AdminAlertSignal&gt; result = apiInstance.AdminAlertSignalList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AdminAlertSignalList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AdminAlertSignal>**](AdminAlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertdependents"></a>
# **AlertDependents**
> List<Alert> AlertDependents (long? masterid)



Retrieves all entities of Alert type related to User entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterid = 789;  // long? | id of User entity

            try
            {
                List&lt;Alert&gt; result = apiInstance.AlertDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of User entity | 

### Return type

[**List<Alert>**](Alert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertitem"></a>
# **AlertItem**
> Alert AlertItem (long? id)



Retrieves an entity of Alert type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertItemExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var id = 789;  // long? | 

            try
            {
                Alert result = apiInstance.AlertItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertItem: " + e.Message );
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

[**Alert**](Alert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertitems"></a>
# **AlertItems**
> List<Alert> AlertItems (List<long?> ids)



Retrieves multiple entities of Alert type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertItemsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Alert&gt; result = apiInstance.AlertItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertItems: " + e.Message );
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

[**List<Alert>**](Alert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertldependents"></a>
# **AlertLDependents**
> List<Alert> AlertLDependents (List<long?> masterids)



Retrieves all entities of Alert type related to multiple entities of User type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterids = new List<long?>(); // List<long?> | ids of User entities

            try
            {
                List&lt;Alert&gt; result = apiInstance.AlertLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of User entities | 

### Return type

[**List<Alert>**](Alert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertlist"></a>
# **AlertList**
> List<Alert> AlertList ()



Retrieves all entities of Alert type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertListExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();

            try
            {
                List&lt;Alert&gt; result = apiInstance.AlertList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Alert>**](Alert.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsignaldependents"></a>
# **AlertSignalDependents**
> List<AlertSignal> AlertSignalDependents (long? masterid)



Retrieves all entities of AlertSignal type related to Alert entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertSignalDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterid = 789;  // long? | id of Alert entity

            try
            {
                List&lt;AlertSignal&gt; result = apiInstance.AlertSignalDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertSignalDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Alert entity | 

### Return type

[**List<AlertSignal>**](AlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsignalitem"></a>
# **AlertSignalItem**
> AlertSignal AlertSignalItem (long? id)



Retrieves an entity of AlertSignal type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertSignalItemExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var id = 789;  // long? | 

            try
            {
                AlertSignal result = apiInstance.AlertSignalItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertSignalItem: " + e.Message );
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

[**AlertSignal**](AlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsignalitems"></a>
# **AlertSignalItems**
> List<AlertSignal> AlertSignalItems (List<long?> ids)



Retrieves multiple entities of AlertSignal type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertSignalItemsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;AlertSignal&gt; result = apiInstance.AlertSignalItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertSignalItems: " + e.Message );
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

[**List<AlertSignal>**](AlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsignalldependents"></a>
# **AlertSignalLDependents**
> List<AlertSignal> AlertSignalLDependents (List<long?> masterids)



Retrieves all entities of AlertSignal type related to multiple entities of Alert type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertSignalLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var masterids = new List<long?>(); // List<long?> | ids of Alert entities

            try
            {
                List&lt;AlertSignal&gt; result = apiInstance.AlertSignalLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertSignalLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Alert entities | 

### Return type

[**List<AlertSignal>**](AlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="alertsignallist"></a>
# **AlertSignalList**
> List<AlertSignal> AlertSignalList ()



Retrieves all entities of AlertSignal type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlertSignalListExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();

            try
            {
                List&lt;AlertSignal&gt; result = apiInstance.AlertSignalList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.AlertSignalList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertSignal>**](AlertSignal.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="completealertsignal"></a>
# **CompleteAlertSignal**
> AdminAlertSignalResponse CompleteAlertSignal (CompleteAlertSignal body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CompleteAlertSignalExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new CompleteAlertSignal(); // CompleteAlertSignal | 

            try
            {
                AdminAlertSignalResponse result = apiInstance.CompleteAlertSignal(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CompleteAlertSignal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompleteAlertSignal**](CompleteAlertSignal.md)|  | 

### Return type

[**AdminAlertSignalResponse**](AdminAlertSignalResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createalert"></a>
# **CreateAlert**
> AlertResponse CreateAlert (CreateAlert body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CreateAlertExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new CreateAlert(); // CreateAlert | 

            try
            {
                AlertResponse result = apiInstance.CreateAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAlert**](CreateAlert.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletealert"></a>
# **DeleteAlert**
> AlertResponse DeleteAlert (DeleteAlert body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DeleteAlertExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new DeleteAlert(); // DeleteAlert | 

            try
            {
                AlertResponse result = apiInstance.DeleteAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteAlert**](DeleteAlert.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dismissalert"></a>
# **DismissAlert**
> AlertResponse DismissAlert (DismissAlert body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DismissAlertExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new DismissAlert(); // DismissAlert | 

            try
            {
                AlertResponse result = apiInstance.DismissAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DismissAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DismissAlert**](DismissAlert.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="markreadalertsignal"></a>
# **MarkReadAlertSignal**
> AlertResponse MarkReadAlertSignal (MarkReadAlertSignal body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarkReadAlertSignalExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new MarkReadAlertSignal(); // MarkReadAlertSignal | 

            try
            {
                AlertResponse result = apiInstance.MarkReadAlertSignal(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.MarkReadAlertSignal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MarkReadAlertSignal**](MarkReadAlertSignal.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifyalert"></a>
# **ModifyAlert**
> AlertResponse ModifyAlert (ModifyAlert body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ModifyAlertExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new ModifyAlert(); // ModifyAlert | 

            try
            {
                AlertResponse result = apiInstance.ModifyAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ModifyAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyAlert**](ModifyAlert.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resetalert"></a>
# **ResetAlert**
> AlertResponse ResetAlert (ResetAlert body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ResetAlertExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new ResetAlert(); // ResetAlert | 

            try
            {
                AlertResponse result = apiInstance.ResetAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ResetAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetAlert**](ResetAlert.md)|  | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="takealertsignalownership"></a>
# **TakeAlertSignalOwnership**
> AdminAlertSignalResponse TakeAlertSignalOwnership (TakeAlertSignalOwnership body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TakeAlertSignalOwnershipExample
    {
        public void main()
        {

            var apiInstance = new AlertsApi();
            var body = new TakeAlertSignalOwnership(); // TakeAlertSignalOwnership | 

            try
            {
                AdminAlertSignalResponse result = apiInstance.TakeAlertSignalOwnership(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.TakeAlertSignalOwnership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TakeAlertSignalOwnership**](TakeAlertSignalOwnership.md)|  | 

### Return type

[**AdminAlertSignalResponse**](AdminAlertSignalResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
