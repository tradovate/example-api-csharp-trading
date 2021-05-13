# Tradovate.Services.Model.PlaceOSO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountSpec** | **string** |  | [optional] 
**AccountId** | **long?** |  | [optional] 
**ClOrdId** | **string** |  | [optional] 
**Action** | **string** | Buy, Sell | 
**Symbol** | **string** |  | 
**OrderQty** | **int?** |  | 
**OrderType** | **string** | Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit | 
**Price** | **double?** |  | [optional] 
**StopPrice** | **double?** |  | [optional] 
**MaxShow** | **int?** |  | [optional] 
**PegDifference** | **double?** |  | [optional] 
**TimeInForce** | **string** | Day, FOK, GTC, GTD, IOC | [optional] 
**ExpireTime** | **DateTime?** |  | [optional] 
**Text** | **string** |  | [optional] 
**ActivationTime** | **DateTime?** |  | [optional] 
**CustomTag50** | **string** |  | [optional] 
**IsAutomated** | **bool?** |  | [optional] 
**Bracket1** | [**RestrainedOrderVersion**](RestrainedOrderVersion.md) |  | 
**Bracket2** | [**RestrainedOrderVersion**](RestrainedOrderVersion.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

