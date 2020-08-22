using System.Collections.Generic;
using BakeSale.Core;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage.InformationAvailabilityState
{
    public class InfoNotInjectedState : InformationAvailabilityAbstract
    {
        public override void CreateObjects(IEnumerable<CurrencyData> currencyData
            , IEnumerable<MoneyData> moneyData
            , IEnumerable<ProductData> productData
            , IEnumerable<VendorData> vendorData
            , ProductsObjectsList contextList)
        {
            PopulateProperties(currencyData, moneyData, productData, vendorData);
            ProductsObjectsList.State = new InfoInjectedState();
            CallFactory(productData, contextList);
        }

        public void PopulateProperties(IEnumerable<CurrencyData> currencyData
            , IEnumerable<MoneyData> moneyData, IEnumerable<ProductData> productData
            , IEnumerable<VendorData> vendorData)
        {
            LoadCurrencies(currencyData);
            LoadMoney(moneyData);
            LoadProducts(productData);
            LoadVendors(vendorData);
        }

        private static void LoadCurrencies(IEnumerable<CurrencyData> currencyData)
        {
            foreach (var data in currencyData)
            {
                string[] stringArray = data.BanknotesAndCoinsInStringFormat.Split(';');
                float[] floatArray = new float[stringArray.Length];
                for (int i = 0; i < stringArray.Length; i++)
                {
                    floatArray[i] = float.Parse(stringArray[i]);
                }
                CurrenciesDictionary.Add(data.Id
                    ,new Currency()
                    {
                        Name = data.Name,
                        BanknotesAndCoins = floatArray
                    }
                );
            }
        }

        private static void LoadMoney(IEnumerable<MoneyData> moneyData)
        {
            foreach (var money in moneyData)
            {
                MoniesDictionary.Add(money.Id
                    ,new Money()
                    {
                        Amount = money.Amount
                        ,Currency = CurrenciesDictionary[money.CurrencyId]
                    }
                );
            }
        }

        private static void LoadProducts(IEnumerable<ProductData> productData)
        {
            foreach (var data in productData)
            {
                ProductsDictionary.Add(data.Id, new Product()
                {
                    Name = data.Name,
                    Price = MoniesDictionary[data.PriceId].Amount
                });
            }
        }

        private static void LoadVendors(IEnumerable<VendorData> vendorData)
        {
            foreach (var data in vendorData)
            {
                Vendor vendor = new Vendor(){Stock = new Dictionary<string, int>(), AccountBalance = new List<Money>()};
                string[] productsAndQuantitiesInStringsArray = data.ProductIdsAndQuantities.Split(';');
                foreach (var productQuantity in productsAndQuantitiesInStringsArray)
                {
                    string[] productAndQuantityArray = productQuantity.Split(':');
                    vendor.Stock.Add(ProductsDictionary[productAndQuantityArray[0]].Name,int.Parse(productAndQuantityArray[1]));
                }

                string[] accountBalanceArray = data.AccountBalanceString.Split(';');
                for (int i = 0; i < accountBalanceArray.Length; i++)
                {
                    vendor.AccountBalance.Add(MoniesDictionary[accountBalanceArray[i]]);
                }

                Vendors.Add(data.Id, vendor);
            }
        }
    }
}