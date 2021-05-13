# Tradovate.Services.Model.CashBalanceLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** |  | [optional] 
**AccountId** | **long?** |  | 
**Timestamp** | **DateTime?** |  | 
**TradeDate** | [**TradeDate**](TradeDate.md) |  | 
**CurrencyId** | **long?** |  | 
**Amount** | **double?** |  | 
**RealizedPnL** | **double?** |  | [optional] 
**WeekRealizedPnL** | **double?** |  | [optional] 
**CashChangeType** | **string** | AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, Commission, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, OrderRoutingFee, TradePaired, TradovateSubscription | 
**FillPairId** | **long?** |  | [optional] 
**FillId** | **long?** |  | [optional] 
**FundTransactionId** | **long?** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Delta** | **double?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

