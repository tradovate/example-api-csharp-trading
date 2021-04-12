# Tradovate.Services.Api.OrdersApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrder**](OrdersApi.md#cancelorder) | **POST** /order/cancelorder | 
[**CommandDependents**](OrdersApi.md#commanddependents) | **GET** /command/deps | 
[**CommandItem**](OrdersApi.md#commanditem) | **GET** /command/item | 
[**CommandItems**](OrdersApi.md#commanditems) | **GET** /command/items | 
[**CommandLDependents**](OrdersApi.md#commandldependents) | **GET** /command/ldeps | 
[**CommandList**](OrdersApi.md#commandlist) | **GET** /command/list | 
[**CommandReportDependents**](OrdersApi.md#commandreportdependents) | **GET** /commandReport/deps | 
[**CommandReportItem**](OrdersApi.md#commandreportitem) | **GET** /commandReport/item | 
[**CommandReportItems**](OrdersApi.md#commandreportitems) | **GET** /commandReport/items | 
[**CommandReportLDependents**](OrdersApi.md#commandreportldependents) | **GET** /commandReport/ldeps | 
[**CommandReportList**](OrdersApi.md#commandreportlist) | **GET** /commandReport/list | 
[**ExecutionReportDependents**](OrdersApi.md#executionreportdependents) | **GET** /executionReport/deps | 
[**ExecutionReportFind**](OrdersApi.md#executionreportfind) | **GET** /executionReport/find | 
[**ExecutionReportItem**](OrdersApi.md#executionreportitem) | **GET** /executionReport/item | 
[**ExecutionReportItems**](OrdersApi.md#executionreportitems) | **GET** /executionReport/items | 
[**ExecutionReportLDependents**](OrdersApi.md#executionreportldependents) | **GET** /executionReport/ldeps | 
[**ExecutionReportList**](OrdersApi.md#executionreportlist) | **GET** /executionReport/list | 
[**ExecutionReportSuggest**](OrdersApi.md#executionreportsuggest) | **GET** /executionReport/suggest | 
[**FillDependents**](OrdersApi.md#filldependents) | **GET** /fill/deps | 
[**FillFeeDependents**](OrdersApi.md#fillfeedependents) | **GET** /fillFee/deps | 
[**FillFeeItem**](OrdersApi.md#fillfeeitem) | **GET** /fillFee/item | 
[**FillFeeItems**](OrdersApi.md#fillfeeitems) | **GET** /fillFee/items | 
[**FillFeeLDependents**](OrdersApi.md#fillfeeldependents) | **GET** /fillFee/ldeps | 
[**FillFeeList**](OrdersApi.md#fillfeelist) | **GET** /fillFee/list | 
[**FillItem**](OrdersApi.md#fillitem) | **GET** /fill/item | 
[**FillItems**](OrdersApi.md#fillitems) | **GET** /fill/items | 
[**FillLDependents**](OrdersApi.md#fillldependents) | **GET** /fill/ldeps | 
[**FillList**](OrdersApi.md#filllist) | **GET** /fill/list | 
[**InterruptOrderStrategy**](OrdersApi.md#interruptorderstrategy) | **POST** /orderStrategy/interruptorderstrategy | 
[**LiquidatePosition**](OrdersApi.md#liquidateposition) | **POST** /order/liquidateposition | 
[**ModifyOrder**](OrdersApi.md#modifyorder) | **POST** /order/modifyorder | 
[**ModifyOrderStrategy**](OrdersApi.md#modifyorderstrategy) | **POST** /orderStrategy/modifyorderstrategy | 
[**OrderDependents**](OrdersApi.md#orderdependents) | **GET** /order/deps | 
[**OrderItem**](OrdersApi.md#orderitem) | **GET** /order/item | 
[**OrderItems**](OrdersApi.md#orderitems) | **GET** /order/items | 
[**OrderLDependents**](OrdersApi.md#orderldependents) | **GET** /order/ldeps | 
[**OrderList**](OrdersApi.md#orderlist) | **GET** /order/list | 
[**OrderStrategyDependents**](OrdersApi.md#orderstrategydependents) | **GET** /orderStrategy/deps | 
[**OrderStrategyItem**](OrdersApi.md#orderstrategyitem) | **GET** /orderStrategy/item | 
[**OrderStrategyItems**](OrdersApi.md#orderstrategyitems) | **GET** /orderStrategy/items | 
[**OrderStrategyLDependents**](OrdersApi.md#orderstrategyldependents) | **GET** /orderStrategy/ldeps | 
[**OrderStrategyLinkDependents**](OrdersApi.md#orderstrategylinkdependents) | **GET** /orderStrategyLink/deps | 
[**OrderStrategyLinkItem**](OrdersApi.md#orderstrategylinkitem) | **GET** /orderStrategyLink/item | 
[**OrderStrategyLinkItems**](OrdersApi.md#orderstrategylinkitems) | **GET** /orderStrategyLink/items | 
[**OrderStrategyLinkLDependents**](OrdersApi.md#orderstrategylinkldependents) | **GET** /orderStrategyLink/ldeps | 
[**OrderStrategyLinkList**](OrdersApi.md#orderstrategylinklist) | **GET** /orderStrategyLink/list | 
[**OrderStrategyList**](OrdersApi.md#orderstrategylist) | **GET** /orderStrategy/list | 
[**OrderVersionDependents**](OrdersApi.md#orderversiondependents) | **GET** /orderVersion/deps | 
[**OrderVersionItem**](OrdersApi.md#orderversionitem) | **GET** /orderVersion/item | 
[**OrderVersionItems**](OrdersApi.md#orderversionitems) | **GET** /orderVersion/items | 
[**OrderVersionLDependents**](OrdersApi.md#orderversionldependents) | **GET** /orderVersion/ldeps | 
[**OrderVersionList**](OrdersApi.md#orderversionlist) | **GET** /orderVersion/list | 
[**PlaceOCO**](OrdersApi.md#placeoco) | **POST** /order/placeoco | 
[**PlaceOSO**](OrdersApi.md#placeoso) | **POST** /order/placeoso | 
[**PlaceOrder**](OrdersApi.md#placeorder) | **POST** /order/placeorder | 
[**StartOrderStrategy**](OrdersApi.md#startorderstrategy) | **POST** /orderStrategy/startorderstrategy | 

<a name="cancelorder"></a>
# **CancelOrder**
> CommandResult CancelOrder (CancelOrder body)



 ## Make a request to cancel an order.

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new CancelOrder(); // CancelOrder | 

            try
            {
                CommandResult result = apiInstance.CancelOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CancelOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CancelOrder**](CancelOrder.md)|  | 

### Return type

[**CommandResult**](CommandResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commanddependents"></a>
# **CommandDependents**
> List<Command> CommandDependents (long? masterid)



Retrieves all entities of Command type related to Order entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Order entity

            try
            {
                List&lt;Command&gt; result = apiInstance.CommandDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Order entity | 

### Return type

[**List<Command>**](Command.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commanditem"></a>
# **CommandItem**
> Command CommandItem (long? id)



Retrieves an entity of Command type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                Command result = apiInstance.CommandItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandItem: " + e.Message );
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

[**Command**](Command.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commanditems"></a>
# **CommandItems**
> List<Command> CommandItems (List<int?> ids)



Retrieves multiple entities of Command type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Command&gt; result = apiInstance.CommandItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandItems: " + e.Message );
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

[**List<Command>**](Command.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandldependents"></a>
# **CommandLDependents**
> List<Command> CommandLDependents (List<int?> masterids)



Retrieves all entities of Command type related to multiple entities of Order type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Order entities

            try
            {
                List&lt;Command&gt; result = apiInstance.CommandLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Order entities | 

### Return type

[**List<Command>**](Command.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandlist"></a>
# **CommandList**
> List<Command> CommandList ()



Retrieves all entities of Command type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;Command&gt; result = apiInstance.CommandList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Command>**](Command.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandreportdependents"></a>
# **CommandReportDependents**
> List<CommandReport> CommandReportDependents (long? masterid)



Retrieves all entities of CommandReport type related to Command entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandReportDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Command entity

            try
            {
                List&lt;CommandReport&gt; result = apiInstance.CommandReportDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandReportDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Command entity | 

### Return type

[**List<CommandReport>**](CommandReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandreportitem"></a>
# **CommandReportItem**
> CommandReport CommandReportItem (long? id)



Retrieves an entity of CommandReport type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandReportItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                CommandReport result = apiInstance.CommandReportItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandReportItem: " + e.Message );
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

[**CommandReport**](CommandReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandreportitems"></a>
# **CommandReportItems**
> List<CommandReport> CommandReportItems (List<int?> ids)



Retrieves multiple entities of CommandReport type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandReportItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;CommandReport&gt; result = apiInstance.CommandReportItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandReportItems: " + e.Message );
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

[**List<CommandReport>**](CommandReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandreportldependents"></a>
# **CommandReportLDependents**
> List<CommandReport> CommandReportLDependents (List<int?> masterids)



Retrieves all entities of CommandReport type related to multiple entities of Command type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandReportLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Command entities

            try
            {
                List&lt;CommandReport&gt; result = apiInstance.CommandReportLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandReportLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Command entities | 

### Return type

[**List<CommandReport>**](CommandReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="commandreportlist"></a>
# **CommandReportList**
> List<CommandReport> CommandReportList ()



Retrieves all entities of CommandReport type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CommandReportListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;CommandReport&gt; result = apiInstance.CommandReportList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CommandReportList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CommandReport>**](CommandReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportdependents"></a>
# **ExecutionReportDependents**
> List<ExecutionReport> ExecutionReportDependents (long? masterid)



Retrieves all entities of ExecutionReport type related to Command entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Command entity

            try
            {
                List&lt;ExecutionReport&gt; result = apiInstance.ExecutionReportDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Command entity | 

### Return type

[**List<ExecutionReport>**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportfind"></a>
# **ExecutionReportFind**
> ExecutionReport ExecutionReportFind (string name)



Retrieves an entity of ExecutionReport type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportFindExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var name = name_example;  // string | 

            try
            {
                ExecutionReport result = apiInstance.ExecutionReportFind(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportFind: " + e.Message );
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

[**ExecutionReport**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportitem"></a>
# **ExecutionReportItem**
> ExecutionReport ExecutionReportItem (long? id)



Retrieves an entity of ExecutionReport type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                ExecutionReport result = apiInstance.ExecutionReportItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportItem: " + e.Message );
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

[**ExecutionReport**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportitems"></a>
# **ExecutionReportItems**
> List<ExecutionReport> ExecutionReportItems (List<int?> ids)



Retrieves multiple entities of ExecutionReport type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ExecutionReport&gt; result = apiInstance.ExecutionReportItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportItems: " + e.Message );
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

[**List<ExecutionReport>**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportldependents"></a>
# **ExecutionReportLDependents**
> List<ExecutionReport> ExecutionReportLDependents (List<int?> masterids)



Retrieves all entities of ExecutionReport type related to multiple entities of Command type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Command entities

            try
            {
                List&lt;ExecutionReport&gt; result = apiInstance.ExecutionReportLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Command entities | 

### Return type

[**List<ExecutionReport>**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportlist"></a>
# **ExecutionReportList**
> List<ExecutionReport> ExecutionReportList ()



Retrieves all entities of ExecutionReport type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;ExecutionReport&gt; result = apiInstance.ExecutionReportList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ExecutionReport>**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executionreportsuggest"></a>
# **ExecutionReportSuggest**
> List<ExecutionReport> ExecutionReportSuggest (string t, int? l)



Retrieves entities of ExecutionReport type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ExecutionReportSuggestExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;ExecutionReport&gt; result = apiInstance.ExecutionReportSuggest(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ExecutionReportSuggest: " + e.Message );
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

[**List<ExecutionReport>**](ExecutionReport.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="filldependents"></a>
# **FillDependents**
> List<Fill> FillDependents (long? masterid)



Retrieves all entities of Fill type related to Order entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Order entity

            try
            {
                List&lt;Fill&gt; result = apiInstance.FillDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Order entity | 

### Return type

[**List<Fill>**](Fill.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillfeedependents"></a>
# **FillFeeDependents**
> List<FillFee> FillFeeDependents (long? masterid)



Retrieves all entities of FillFee type related to Fill entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillFeeDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Fill entity

            try
            {
                List&lt;FillFee&gt; result = apiInstance.FillFeeDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillFeeDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Fill entity | 

### Return type

[**List<FillFee>**](FillFee.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillfeeitem"></a>
# **FillFeeItem**
> FillFee FillFeeItem (long? id)



Retrieves an entity of FillFee type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillFeeItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                FillFee result = apiInstance.FillFeeItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillFeeItem: " + e.Message );
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

[**FillFee**](FillFee.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillfeeitems"></a>
# **FillFeeItems**
> List<FillFee> FillFeeItems (List<int?> ids)



Retrieves multiple entities of FillFee type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillFeeItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;FillFee&gt; result = apiInstance.FillFeeItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillFeeItems: " + e.Message );
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

[**List<FillFee>**](FillFee.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillfeeldependents"></a>
# **FillFeeLDependents**
> List<FillFee> FillFeeLDependents (List<int?> masterids)



Retrieves all entities of FillFee type related to multiple entities of Fill type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillFeeLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Fill entities

            try
            {
                List&lt;FillFee&gt; result = apiInstance.FillFeeLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillFeeLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Fill entities | 

### Return type

[**List<FillFee>**](FillFee.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillfeelist"></a>
# **FillFeeList**
> List<FillFee> FillFeeList ()



Retrieves all entities of FillFee type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillFeeListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;FillFee&gt; result = apiInstance.FillFeeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillFeeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FillFee>**](FillFee.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillitem"></a>
# **FillItem**
> Fill FillItem (long? id)



Retrieves an entity of Fill type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                Fill result = apiInstance.FillItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillItem: " + e.Message );
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

[**Fill**](Fill.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillitems"></a>
# **FillItems**
> List<Fill> FillItems (List<int?> ids)



Retrieves multiple entities of Fill type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Fill&gt; result = apiInstance.FillItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillItems: " + e.Message );
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

[**List<Fill>**](Fill.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="fillldependents"></a>
# **FillLDependents**
> List<Fill> FillLDependents (List<int?> masterids)



Retrieves all entities of Fill type related to multiple entities of Order type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Order entities

            try
            {
                List&lt;Fill&gt; result = apiInstance.FillLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Order entities | 

### Return type

[**List<Fill>**](Fill.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="filllist"></a>
# **FillList**
> List<Fill> FillList ()



Retrieves all entities of Fill type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FillListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;Fill&gt; result = apiInstance.FillList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.FillList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Fill>**](Fill.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="interruptorderstrategy"></a>
# **InterruptOrderStrategy**
> OrderStrategyStatusResponse InterruptOrderStrategy (InterruptOrderStrategy body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class InterruptOrderStrategyExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new InterruptOrderStrategy(); // InterruptOrderStrategy | 

            try
            {
                OrderStrategyStatusResponse result = apiInstance.InterruptOrderStrategy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.InterruptOrderStrategy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InterruptOrderStrategy**](InterruptOrderStrategy.md)|  | 

### Return type

[**OrderStrategyStatusResponse**](OrderStrategyStatusResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="liquidateposition"></a>
# **LiquidatePosition**
> PlaceOrderResult LiquidatePosition (LiquidatePosition body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class LiquidatePositionExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new LiquidatePosition(); // LiquidatePosition | 

            try
            {
                PlaceOrderResult result = apiInstance.LiquidatePosition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.LiquidatePosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LiquidatePosition**](LiquidatePosition.md)|  | 

### Return type

[**PlaceOrderResult**](PlaceOrderResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifyorder"></a>
# **ModifyOrder**
> CommandResult ModifyOrder (ModifyOrder body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ModifyOrderExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new ModifyOrder(); // ModifyOrder | 

            try
            {
                CommandResult result = apiInstance.ModifyOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ModifyOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyOrder**](ModifyOrder.md)|  | 

### Return type

[**CommandResult**](CommandResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modifyorderstrategy"></a>
# **ModifyOrderStrategy**
> OrderStrategyStatusResponse ModifyOrderStrategy (ModifyOrderStrategy body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ModifyOrderStrategyExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new ModifyOrderStrategy(); // ModifyOrderStrategy | 

            try
            {
                OrderStrategyStatusResponse result = apiInstance.ModifyOrderStrategy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.ModifyOrderStrategy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifyOrderStrategy**](ModifyOrderStrategy.md)|  | 

### Return type

[**OrderStrategyStatusResponse**](OrderStrategyStatusResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderdependents"></a>
# **OrderDependents**
> List<Order> OrderDependents (long? masterid)



Retrieves all entities of Order type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;Order&gt; result = apiInstance.OrderDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderDependents: " + e.Message );
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

[**List<Order>**](Order.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderitem"></a>
# **OrderItem**
> Order OrderItem (long? id)



Retrieves an entity of Order type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                Order result = apiInstance.OrderItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderItem: " + e.Message );
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

[**Order**](Order.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderitems"></a>
# **OrderItems**
> List<Order> OrderItems (List<int?> ids)



Retrieves multiple entities of Order type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Order&gt; result = apiInstance.OrderItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderItems: " + e.Message );
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

[**List<Order>**](Order.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderldependents"></a>
# **OrderLDependents**
> List<Order> OrderLDependents (List<int?> masterids)



Retrieves all entities of Order type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;Order&gt; result = apiInstance.OrderLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderLDependents: " + e.Message );
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

[**List<Order>**](Order.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderlist"></a>
# **OrderList**
> List<Order> OrderList ()



Retrieves all entities of Order type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;Order&gt; result = apiInstance.OrderList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Order>**](Order.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategydependents"></a>
# **OrderStrategyDependents**
> List<OrderStrategy> OrderStrategyDependents (long? masterid)



Retrieves all entities of OrderStrategy type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Account entity

            try
            {
                List&lt;OrderStrategy&gt; result = apiInstance.OrderStrategyDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyDependents: " + e.Message );
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

[**List<OrderStrategy>**](OrderStrategy.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategyitem"></a>
# **OrderStrategyItem**
> OrderStrategy OrderStrategyItem (long? id)



Retrieves an entity of OrderStrategy type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                OrderStrategy result = apiInstance.OrderStrategyItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyItem: " + e.Message );
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

[**OrderStrategy**](OrderStrategy.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategyitems"></a>
# **OrderStrategyItems**
> List<OrderStrategy> OrderStrategyItems (List<int?> ids)



Retrieves multiple entities of OrderStrategy type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;OrderStrategy&gt; result = apiInstance.OrderStrategyItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyItems: " + e.Message );
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

[**List<OrderStrategy>**](OrderStrategy.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategyldependents"></a>
# **OrderStrategyLDependents**
> List<OrderStrategy> OrderStrategyLDependents (List<int?> masterids)



Retrieves all entities of OrderStrategy type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;OrderStrategy&gt; result = apiInstance.OrderStrategyLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLDependents: " + e.Message );
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

[**List<OrderStrategy>**](OrderStrategy.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylinkdependents"></a>
# **OrderStrategyLinkDependents**
> List<OrderStrategyLink> OrderStrategyLinkDependents (long? masterid)



Retrieves all entities of OrderStrategyLink type related to OrderStrategy entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLinkDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of OrderStrategy entity

            try
            {
                List&lt;OrderStrategyLink&gt; result = apiInstance.OrderStrategyLinkDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLinkDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of OrderStrategy entity | 

### Return type

[**List<OrderStrategyLink>**](OrderStrategyLink.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylinkitem"></a>
# **OrderStrategyLinkItem**
> OrderStrategyLink OrderStrategyLinkItem (long? id)



Retrieves an entity of OrderStrategyLink type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLinkItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                OrderStrategyLink result = apiInstance.OrderStrategyLinkItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLinkItem: " + e.Message );
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

[**OrderStrategyLink**](OrderStrategyLink.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylinkitems"></a>
# **OrderStrategyLinkItems**
> List<OrderStrategyLink> OrderStrategyLinkItems (List<int?> ids)



Retrieves multiple entities of OrderStrategyLink type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLinkItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;OrderStrategyLink&gt; result = apiInstance.OrderStrategyLinkItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLinkItems: " + e.Message );
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

[**List<OrderStrategyLink>**](OrderStrategyLink.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylinkldependents"></a>
# **OrderStrategyLinkLDependents**
> List<OrderStrategyLink> OrderStrategyLinkLDependents (List<int?> masterids)



Retrieves all entities of OrderStrategyLink type related to multiple entities of OrderStrategy type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLinkLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of OrderStrategy entities

            try
            {
                List&lt;OrderStrategyLink&gt; result = apiInstance.OrderStrategyLinkLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLinkLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of OrderStrategy entities | 

### Return type

[**List<OrderStrategyLink>**](OrderStrategyLink.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylinklist"></a>
# **OrderStrategyLinkList**
> List<OrderStrategyLink> OrderStrategyLinkList ()



Retrieves all entities of OrderStrategyLink type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyLinkListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;OrderStrategyLink&gt; result = apiInstance.OrderStrategyLinkList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyLinkList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrderStrategyLink>**](OrderStrategyLink.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderstrategylist"></a>
# **OrderStrategyList**
> List<OrderStrategy> OrderStrategyList ()



Retrieves all entities of OrderStrategy type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderStrategyListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;OrderStrategy&gt; result = apiInstance.OrderStrategyList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderStrategyList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrderStrategy>**](OrderStrategy.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderversiondependents"></a>
# **OrderVersionDependents**
> List<OrderVersion> OrderVersionDependents (long? masterid)



Retrieves all entities of OrderVersion type related to Order entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderVersionDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterid = 789;  // long? | id of Order entity

            try
            {
                List&lt;OrderVersion&gt; result = apiInstance.OrderVersionDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderVersionDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Order entity | 

### Return type

[**List<OrderVersion>**](OrderVersion.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderversionitem"></a>
# **OrderVersionItem**
> OrderVersion OrderVersionItem (long? id)



Retrieves an entity of OrderVersion type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderVersionItemExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | 

            try
            {
                OrderVersion result = apiInstance.OrderVersionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderVersionItem: " + e.Message );
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

[**OrderVersion**](OrderVersion.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderversionitems"></a>
# **OrderVersionItems**
> List<OrderVersion> OrderVersionItems (List<int?> ids)



Retrieves multiple entities of OrderVersion type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderVersionItemsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;OrderVersion&gt; result = apiInstance.OrderVersionItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderVersionItems: " + e.Message );
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

[**List<OrderVersion>**](OrderVersion.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderversionldependents"></a>
# **OrderVersionLDependents**
> List<OrderVersion> OrderVersionLDependents (List<int?> masterids)



Retrieves all entities of OrderVersion type related to multiple entities of Order type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderVersionLDependentsExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var masterids = new List<int?>(); // List<int?> | ids of Order entities

            try
            {
                List&lt;OrderVersion&gt; result = apiInstance.OrderVersionLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderVersionLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;int?&gt;**](int?.md)| ids of Order entities | 

### Return type

[**List<OrderVersion>**](OrderVersion.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderversionlist"></a>
# **OrderVersionList**
> List<OrderVersion> OrderVersionList ()



Retrieves all entities of OrderVersion type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class OrderVersionListExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();

            try
            {
                List&lt;OrderVersion&gt; result = apiInstance.OrderVersionList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderVersionList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrderVersion>**](OrderVersion.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placeoco"></a>
# **PlaceOCO**
> PlaceOcoResult PlaceOCO (PlaceOCO body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PlaceOCOExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new PlaceOCO(); // PlaceOCO | 

            try
            {
                PlaceOcoResult result = apiInstance.PlaceOCO(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.PlaceOCO: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlaceOCO**](PlaceOCO.md)|  | 

### Return type

[**PlaceOcoResult**](PlaceOcoResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placeoso"></a>
# **PlaceOSO**
> PlaceOsoResult PlaceOSO (PlaceOSO body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PlaceOSOExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new PlaceOSO(); // PlaceOSO | 

            try
            {
                PlaceOsoResult result = apiInstance.PlaceOSO(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.PlaceOSO: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlaceOSO**](PlaceOSO.md)|  | 

### Return type

[**PlaceOsoResult**](PlaceOsoResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="placeorder"></a>
# **PlaceOrder**
> PlaceOrderResult PlaceOrder (PlaceOrder body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PlaceOrderExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new PlaceOrder(); // PlaceOrder | 

            try
            {
                PlaceOrderResult result = apiInstance.PlaceOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.PlaceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlaceOrder**](PlaceOrder.md)|  | 

### Return type

[**PlaceOrderResult**](PlaceOrderResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="startorderstrategy"></a>
# **StartOrderStrategy**
> OrderStrategyStatusResponse StartOrderStrategy (StartOrderStrategy body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class StartOrderStrategyExample
    {
        public void main()
        {

            var apiInstance = new OrdersApi();
            var body = new StartOrderStrategy(); // StartOrderStrategy | 

            try
            {
                OrderStrategyStatusResponse result = apiInstance.StartOrderStrategy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.StartOrderStrategy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StartOrderStrategy**](StartOrderStrategy.md)|  | 

### Return type

[**OrderStrategyStatusResponse**](OrderStrategyStatusResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
