# Tradovate.Services.Model.ExecutionReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** |  | [optional] 
**CommandId** | **long?** |  | 
**Name** | **string** |  | 
**AccountId** | **long?** |  | 
**ContractId** | **long?** |  | 
**Timestamp** | **DateTime?** |  | 
**TradeDate** | [**TradeDate**](TradeDate.md) |  | [optional] 
**OrderId** | **long?** |  | 
**ExecType** | **string** | Canceled, Completed, DoneForDay, Expired, New, OrderStatus, PendingCancel, PendingNew, PendingReplace, Rejected, Replaced, Stopped, Suspended, Trade, TradeCancel, TradeCorrect | 
**ExecRefId** | **string** |  | [optional] 
**OrdStatus** | **string** | Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working | [optional] 
**Action** | **string** | Buy, Sell | 
**CumQty** | **int?** |  | [optional] 
**AvgPx** | **double?** |  | [optional] 
**LastQty** | **int?** |  | [optional] 
**LastPx** | **double?** |  | [optional] 
**RejectReason** | **string** | AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported | [optional] 
**Text** | **string** |  | [optional] 
**ExchangeOrderId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

