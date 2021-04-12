# Tradovate.Services.Api.AccountingApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountDependents**](AccountingApi.md#accountdependents) | **GET** /account/deps | 
[**AccountFind**](AccountingApi.md#accountfind) | **GET** /account/find | 
[**AccountItem**](AccountingApi.md#accountitem) | **GET** /account/item | 
[**AccountItems**](AccountingApi.md#accountitems) | **GET** /account/items | 
[**AccountLDependents**](AccountingApi.md#accountldependents) | **GET** /account/ldeps | 
[**AccountList**](AccountingApi.md#accountlist) | **GET** /account/list | 
[**AccountSuggest**](AccountingApi.md#accountsuggest) | **GET** /account/suggest | 
[**CashBalanceDependents**](AccountingApi.md#cashbalancedependents) | **GET** /cashBalance/deps | 
[**CashBalanceItem**](AccountingApi.md#cashbalanceitem) | **GET** /cashBalance/item | 
[**CashBalanceItems**](AccountingApi.md#cashbalanceitems) | **GET** /cashBalance/items | 
[**CashBalanceLDependents**](AccountingApi.md#cashbalanceldependents) | **GET** /cashBalance/ldeps | 
[**CashBalanceList**](AccountingApi.md#cashbalancelist) | **GET** /cashBalance/list | 
[**CashBalanceLogDependents**](AccountingApi.md#cashbalancelogdependents) | **GET** /cashBalanceLog/deps | 
[**CashBalanceLogItem**](AccountingApi.md#cashbalancelogitem) | **GET** /cashBalanceLog/item | 
[**CashBalanceLogItems**](AccountingApi.md#cashbalancelogitems) | **GET** /cashBalanceLog/items | 
[**CashBalanceLogLDependents**](AccountingApi.md#cashbalancelogldependents) | **GET** /cashBalanceLog/ldeps | 
[**GetCashBalanceSnapshot**](AccountingApi.md#getcashbalancesnapshot) | **POST** /cashBalance/getcashbalancesnapshot | 
[**MarginSnapshotDependents**](AccountingApi.md#marginsnapshotdependents) | **GET** /marginSnapshot/deps | 
[**MarginSnapshotItem**](AccountingApi.md#marginsnapshotitem) | **GET** /marginSnapshot/item | 
[**MarginSnapshotItems**](AccountingApi.md#marginsnapshotitems) | **GET** /marginSnapshot/items | 
[**MarginSnapshotLDependents**](AccountingApi.md#marginsnapshotldependents) | **GET** /marginSnapshot/ldeps | 
[**MarginSnapshotList**](AccountingApi.md#marginsnapshotlist) | **GET** /marginSnapshot/list | 
[**TradingPermissionDependents**](AccountingApi.md#tradingpermissiondependents) | **GET** /tradingPermission/deps | 
[**TradingPermissionItem**](AccountingApi.md#tradingpermissionitem) | **GET** /tradingPermission/item | 
[**TradingPermissionItems**](AccountingApi.md#tradingpermissionitems) | **GET** /tradingPermission/items | 
[**TradingPermissionLDependents**](AccountingApi.md#tradingpermissionldependents) | **GET** /tradingPermission/ldeps | 
[**TradingPermissionList**](AccountingApi.md#tradingpermissionlist) | **GET** /tradingPermission/list | 

<a name="accountdependents"></a>
# **AccountDependents**
> List<Account> AccountDependents (long? masterid)



Retrieves all entities of Account type related to User entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterid = 789;  // long? | id of User entity

            try
            {
                List&lt;Account&gt; result = apiInstance.AccountDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountDependents: " + e.Message );
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

[**List<Account>**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountfind"></a>
# **AccountFind**
> Account AccountFind (string name)



Retrieves an entity of Account type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountFindExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var name = name_example;  // string | 

            try
            {
                Account result = apiInstance.AccountFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountFind: " + e.Message );
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

[**Account**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountitem"></a>
# **AccountItem**
> Account AccountItem (long? id)



Retrieves an entity of Account type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountItemExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var id = 789;  // long? | 

            try
            {
                Account result = apiInstance.AccountItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountItem: " + e.Message );
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

[**Account**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountitems"></a>
# **AccountItems**
> List<Account> AccountItems (List<int?> ids)



Retrieves multiple entities of Account type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountItemsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Account&gt; result = apiInstance.AccountItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountItems: " + e.Message );
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

[**List<Account>**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountldependents"></a>
# **AccountLDependents**
> List<Account> AccountLDependents (List<int?> masterids)



Retrieves all entities of Account type related to multiple entities of User type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterids = new List<int?>(); // List<int?> | ids of User entities

            try
            {
                List&lt;Account&gt; result = apiInstance.AccountLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of User entities | 

### Return type

[**List<Account>**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountlist"></a>
# **AccountList**
> List<Account> AccountList ()



Retrieves all entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountListExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();

            try
            {
                List&lt;Account&gt; result = apiInstance.AccountList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Account>**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsuggest"></a>
# **AccountSuggest**
> List<Account> AccountSuggest (string t, int? l)



Retrieves entities of Account type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccountSuggestExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Account&gt; result = apiInstance.AccountSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.AccountSuggest: " + e.Message );
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

[**List<Account>**](Account.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancedependents"></a>
# **CashBalanceDependents**
> List<CashBalance> CashBalanceDependents (long? masterid)



Retrieves all entities of CashBalance type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;CashBalance&gt; result = apiInstance.CashBalanceDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceDependents: " + e.Message );
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

[**List<CashBalance>**](CashBalance.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalanceitem"></a>
# **CashBalanceItem**
> CashBalance CashBalanceItem (long? id)



Retrieves an entity of CashBalance type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceItemExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var id = 789;  // long? | 

            try
            {
                CashBalance result = apiInstance.CashBalanceItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceItem: " + e.Message );
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

[**CashBalance**](CashBalance.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalanceitems"></a>
# **CashBalanceItems**
> List<CashBalance> CashBalanceItems (List<int?> ids)



Retrieves multiple entities of CashBalance type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceItemsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;CashBalance&gt; result = apiInstance.CashBalanceItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceItems: " + e.Message );
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

[**List<CashBalance>**](CashBalance.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalanceldependents"></a>
# **CashBalanceLDependents**
> List<CashBalance> CashBalanceLDependents (List<int?> masterids)



Retrieves all entities of CashBalance type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;CashBalance&gt; result = apiInstance.CashBalanceLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Account entities | 

### Return type

[**List<CashBalance>**](CashBalance.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancelist"></a>
# **CashBalanceList**
> List<CashBalance> CashBalanceList ()



Retrieves all entities of CashBalance type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceListExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();

            try
            {
                List&lt;CashBalance&gt; result = apiInstance.CashBalanceList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CashBalance>**](CashBalance.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancelogdependents"></a>
# **CashBalanceLogDependents**
> List<CashBalanceLog> CashBalanceLogDependents (long? masterid)



Retrieves all entities of CashBalanceLog type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceLogDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;CashBalanceLog&gt; result = apiInstance.CashBalanceLogDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceLogDependents: " + e.Message );
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

[**List<CashBalanceLog>**](CashBalanceLog.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancelogitem"></a>
# **CashBalanceLogItem**
> CashBalanceLog CashBalanceLogItem (long? id)



Retrieves an entity of CashBalanceLog type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceLogItemExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var id = 789;  // long? | 

            try
            {
                CashBalanceLog result = apiInstance.CashBalanceLogItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceLogItem: " + e.Message );
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

[**CashBalanceLog**](CashBalanceLog.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancelogitems"></a>
# **CashBalanceLogItems**
> List<CashBalanceLog> CashBalanceLogItems (List<int?> ids)



Retrieves multiple entities of CashBalanceLog type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceLogItemsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;CashBalanceLog&gt; result = apiInstance.CashBalanceLogItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceLogItems: " + e.Message );
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

[**List<CashBalanceLog>**](CashBalanceLog.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cashbalancelogldependents"></a>
# **CashBalanceLogLDependents**
> List<CashBalanceLog> CashBalanceLogLDependents (List<int?> masterids)



Retrieves all entities of CashBalanceLog type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CashBalanceLogLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;CashBalanceLog&gt; result = apiInstance.CashBalanceLogLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.CashBalanceLogLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Account entities | 

### Return type

[**List<CashBalanceLog>**](CashBalanceLog.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcashbalancesnapshot"></a>
# **GetCashBalanceSnapshot**
> CashBalanceSnapshot GetCashBalanceSnapshot (GetCashBalanceSnapshot body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetCashBalanceSnapshotExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var body = new GetCashBalanceSnapshot(); // GetCashBalanceSnapshot | 

            try
            {
                CashBalanceSnapshot result = apiInstance.GetCashBalanceSnapshot(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.GetCashBalanceSnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetCashBalanceSnapshot**](GetCashBalanceSnapshot.md)|  | 

### Return type

[**CashBalanceSnapshot**](CashBalanceSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marginsnapshotdependents"></a>
# **MarginSnapshotDependents**
> List<MarginSnapshot> MarginSnapshotDependents (long? masterid)



Retrieves all entities of MarginSnapshot type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarginSnapshotDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;MarginSnapshot&gt; result = apiInstance.MarginSnapshotDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.MarginSnapshotDependents: " + e.Message );
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

[**List<MarginSnapshot>**](MarginSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marginsnapshotitem"></a>
# **MarginSnapshotItem**
> MarginSnapshot MarginSnapshotItem (long? id)



Retrieves an entity of MarginSnapshot type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarginSnapshotItemExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var id = 789;  // long? | 

            try
            {
                MarginSnapshot result = apiInstance.MarginSnapshotItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.MarginSnapshotItem: " + e.Message );
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

[**MarginSnapshot**](MarginSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marginsnapshotitems"></a>
# **MarginSnapshotItems**
> List<MarginSnapshot> MarginSnapshotItems (List<int?> ids)



Retrieves multiple entities of MarginSnapshot type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarginSnapshotItemsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;MarginSnapshot&gt; result = apiInstance.MarginSnapshotItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.MarginSnapshotItems: " + e.Message );
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

[**List<MarginSnapshot>**](MarginSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marginsnapshotldependents"></a>
# **MarginSnapshotLDependents**
> List<MarginSnapshot> MarginSnapshotLDependents (List<int?> masterids)



Retrieves all entities of MarginSnapshot type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarginSnapshotLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;MarginSnapshot&gt; result = apiInstance.MarginSnapshotLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.MarginSnapshotLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Account entities | 

### Return type

[**List<MarginSnapshot>**](MarginSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="marginsnapshotlist"></a>
# **MarginSnapshotList**
> List<MarginSnapshot> MarginSnapshotList ()



Retrieves all entities of MarginSnapshot type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarginSnapshotListExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();

            try
            {
                List&lt;MarginSnapshot&gt; result = apiInstance.MarginSnapshotList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.MarginSnapshotList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarginSnapshot>**](MarginSnapshot.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradingpermissiondependents"></a>
# **TradingPermissionDependents**
> List<TradingPermission> TradingPermissionDependents (long? masterid)



Retrieves all entities of TradingPermission type related to User entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradingPermissionDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterid = 789;  // long? | id of User entity

            try
            {
                List&lt;TradingPermission&gt; result = apiInstance.TradingPermissionDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.TradingPermissionDependents: " + e.Message );
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

[**List<TradingPermission>**](TradingPermission.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradingpermissionitem"></a>
# **TradingPermissionItem**
> TradingPermission TradingPermissionItem (long? id)



Retrieves an entity of TradingPermission type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradingPermissionItemExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var id = 789;  // long? | 

            try
            {
                TradingPermission result = apiInstance.TradingPermissionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.TradingPermissionItem: " + e.Message );
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

[**TradingPermission**](TradingPermission.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradingpermissionitems"></a>
# **TradingPermissionItems**
> List<TradingPermission> TradingPermissionItems (List<int?> ids)



Retrieves multiple entities of TradingPermission type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradingPermissionItemsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;TradingPermission&gt; result = apiInstance.TradingPermissionItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.TradingPermissionItems: " + e.Message );
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

[**List<TradingPermission>**](TradingPermission.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradingpermissionldependents"></a>
# **TradingPermissionLDependents**
> List<TradingPermission> TradingPermissionLDependents (List<int?> masterids)



Retrieves all entities of TradingPermission type related to multiple entities of User type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradingPermissionLDependentsExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();
            var masterids = new List<int?>(); // List<int?> | ids of User entities

            try
            {
                List&lt;TradingPermission&gt; result = apiInstance.TradingPermissionLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.TradingPermissionLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of User entities | 

### Return type

[**List<TradingPermission>**](TradingPermission.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tradingpermissionlist"></a>
# **TradingPermissionList**
> List<TradingPermission> TradingPermissionList ()



Retrieves all entities of TradingPermission type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class TradingPermissionListExample
    {
        public void main()
        {

            var apiInstance = new AccountingApi();

            try
            {
                List&lt;TradingPermission&gt; result = apiInstance.TradingPermissionList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingApi.TradingPermissionList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TradingPermission>**](TradingPermission.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
