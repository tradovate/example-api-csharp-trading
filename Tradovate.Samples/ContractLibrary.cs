/*
 *
 * Tradovate API, Samples.
 * Contract specifications
 *
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class ContractLibrary
    {
        public static async void PrepopulateCache()
        {
            // Cache pre-populating can save some latency at trading time, but not recommended for short-term connections
            Log.Write("PRE-POPULATING CONTRACT LIBRARY");

            var contractLibraryApi = new ContractLibraryApi();
            await contractLibraryApi.ContractGroupListAsync();
            await contractLibraryApi.ExchangeListAsync();
            await contractLibraryApi.CurrencyListAsync();
            await contractLibraryApi.CurrencyRateListAsync();

            var riskApi = new RisksApi();
            await riskApi.ProductMarginListAsync();

            var products = await contractLibraryApi.ProductListAsync();

            // Highly not recommended for short-term connections
            foreach (var product in products)
            {
                await contractLibraryApi.ContractMaturityDependentsAsync(product.Id)
                    .ContinueWith(contractMaturities => {
                        return contractLibraryApi.ContractLDependentsAsync(contractMaturities.Result.Select(contractMaturity => contractMaturity.Id).ToList());
                    });
            }
        }

        public static void ContractSpec(string symbol)
        {
            var contractLibraryApi = new ContractLibraryApi();
            Contract contract = contractLibraryApi.ContractFind(symbol);
            Log.Write(contract);
            ContractMaturity contractMaturity = contractLibraryApi.ContractMaturityItem(contract.ContractMaturityId);
            Log.Write(contractMaturity);
            Product product = contractLibraryApi.ProductItem(contractMaturity.ProductId);
            Log.Write(product);
            Exchange exchange = contractLibraryApi.ExchangeItem(product.ExchangeId);
            Log.Write(exchange);
            ContractGroup contractGroup = contractLibraryApi.ContractGroupItem(product.ContractGroupId);
            Log.Write(contractGroup);
            Currency currency = contractLibraryApi.CurrencyItem(product.CurrencyId);
            Log.Write(currency);
            CurrencyRate currencyRate = contractLibraryApi.CurrencyRateItem(product.CurrencyId);
            Log.Write(currencyRate);
            ProductSession productSession = contractLibraryApi.ProductSessionItem(product.Id);
            Log.Write(productSession);
            ProductFeeParamsResponse productFees = contractLibraryApi.GetProductFeeParams(new GetProductFeeParams(new List<long?> { product.Id }));
            foreach (var fee in productFees.Params)
            {
                Log.Write(fee);
            }
            var riskApi = new RisksApi();
            ProductMargin productMargin = riskApi.ProductMarginItem(product.Id);
            Log.Write(productMargin);
            try
            {
                ContractMargin contractMargin = riskApi.ContractMarginItem(contract.Id);
                Log.Write(contractMargin);
            }
            catch
            {
                Log.Write("Per-contract margin is not specified");
            }
        }
    }
}