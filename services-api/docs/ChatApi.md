# Tradovate.Services.Api.ChatApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChatDependents**](ChatApi.md#chatdependents) | **GET** /chat/deps | 
[**ChatItem**](ChatApi.md#chatitem) | **GET** /chat/item | 
[**ChatItems**](ChatApi.md#chatitems) | **GET** /chat/items | 
[**ChatLDependents**](ChatApi.md#chatldependents) | **GET** /chat/ldeps | 
[**ChatList**](ChatApi.md#chatlist) | **GET** /chat/list | 
[**ChatMessageDependents**](ChatApi.md#chatmessagedependents) | **GET** /chatMessage/deps | 
[**ChatMessageItem**](ChatApi.md#chatmessageitem) | **GET** /chatMessage/item | 
[**ChatMessageItems**](ChatApi.md#chatmessageitems) | **GET** /chatMessage/items | 
[**ChatMessageLDependents**](ChatApi.md#chatmessageldependents) | **GET** /chatMessage/ldeps | 
[**CloseChat**](ChatApi.md#closechat) | **POST** /chat/closechat | 
[**MarkAsReadChatMessage**](ChatApi.md#markasreadchatmessage) | **POST** /chat/markasreadchatmessage | 
[**PostChatMessage**](ChatApi.md#postchatmessage) | **POST** /chat/postchatmessage | 

<a name="chatdependents"></a>
# **ChatDependents**
> List<Chat> ChatDependents (long? masterid)



Retrieves all entities of Chat type related to User entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatDependentsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var masterid = 789;  // long? | id of User entity

            try
            {
                List&lt;Chat&gt; result = apiInstance.ChatDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatDependents: " + e.Message );
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

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatitem"></a>
# **ChatItem**
> Chat ChatItem (long? id)



Retrieves an entity of Chat type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatItemExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var id = 789;  // long? | 

            try
            {
                Chat result = apiInstance.ChatItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatItem: " + e.Message );
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

[**Chat**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatitems"></a>
# **ChatItems**
> List<Chat> ChatItems (List<long?> ids)



Retrieves multiple entities of Chat type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatItemsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;Chat&gt; result = apiInstance.ChatItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatItems: " + e.Message );
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

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatldependents"></a>
# **ChatLDependents**
> List<Chat> ChatLDependents (List<long?> masterids)



Retrieves all entities of Chat type related to multiple entities of User type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var masterids = new List<long?>(); // List<long?> | ids of User entities

            try
            {
                List&lt;Chat&gt; result = apiInstance.ChatLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatLDependents: " + e.Message );
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

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatlist"></a>
# **ChatList**
> List<Chat> ChatList ()



Retrieves all entities of Chat type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatListExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();

            try
            {
                List&lt;Chat&gt; result = apiInstance.ChatList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatmessagedependents"></a>
# **ChatMessageDependents**
> List<ChatMessage> ChatMessageDependents (long? masterid)



Retrieves all entities of ChatMessage type related to Chat entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatMessageDependentsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var masterid = 789;  // long? | id of Chat entity

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.ChatMessageDependents(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatMessageDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **long?**| id of Chat entity | 

### Return type

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatmessageitem"></a>
# **ChatMessageItem**
> ChatMessage ChatMessageItem (long? id)



Retrieves an entity of ChatMessage type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatMessageItemExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var id = 789;  // long? | 

            try
            {
                ChatMessage result = apiInstance.ChatMessageItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatMessageItem: " + e.Message );
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

[**ChatMessage**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatmessageitems"></a>
# **ChatMessageItems**
> List<ChatMessage> ChatMessageItems (List<long?> ids)



Retrieves multiple entities of ChatMessage type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatMessageItemsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var ids = new List<long?>(); // List<long?> | 

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.ChatMessageItems(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatMessageItems: " + e.Message );
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

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatmessageldependents"></a>
# **ChatMessageLDependents**
> List<ChatMessage> ChatMessageLDependents (List<long?> masterids)



Retrieves all entities of ChatMessage type related to multiple entities of Chat type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class ChatMessageLDependentsExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var masterids = new List<long?>(); // List<long?> | ids of Chat entities

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.ChatMessageLDependents(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatMessageLDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List&lt;long?&gt;**](long?.md)| ids of Chat entities | 

### Return type

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="closechat"></a>
# **CloseChat**
> ChatResponse CloseChat (CloseChat body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CloseChatExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var body = new CloseChat(); // CloseChat | 

            try
            {
                ChatResponse result = apiInstance.CloseChat(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.CloseChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloseChat**](CloseChat.md)|  | 

### Return type

[**ChatResponse**](ChatResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="markasreadchatmessage"></a>
# **MarkAsReadChatMessage**
> ChatMessageResponse MarkAsReadChatMessage (MarkAsReadChatMessage body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarkAsReadChatMessageExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var body = new MarkAsReadChatMessage(); // MarkAsReadChatMessage | 

            try
            {
                ChatMessageResponse result = apiInstance.MarkAsReadChatMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.MarkAsReadChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MarkAsReadChatMessage**](MarkAsReadChatMessage.md)|  | 

### Return type

[**ChatMessageResponse**](ChatMessageResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postchatmessage"></a>
# **PostChatMessage**
> ChatMessageResponse PostChatMessage (PostChatMessage body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PostChatMessageExample
    {
        public void main()
        {

            var apiInstance = new ChatApi();
            var body = new PostChatMessage(); // PostChatMessage | 

            try
            {
                ChatMessageResponse result = apiInstance.PostChatMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostChatMessage**](PostChatMessage.md)|  | 

### Return type

[**ChatMessageResponse**](ChatMessageResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
