using System.Collections.Generic;
using BakeSale.Core;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace Infra.SalePage
{
    public class ProductsObjectsList : List<ProductObject>
    {
        private static Dictionary<string, Money> _moniesDictionary = new Dictionary<string, Money>();
        private static Dictionary<string,Currency> _currenciesDictionary = new Dictionary<string, Currency>();
        private static Dictionary<string,Product> _productsDictionary = new Dictionary<string, Product>();
        private static Dictionary<string,Vendor> _vendors = new Dictionary<string, Vendor>();

        public ProductsObjectsList(IEnumerable<ProductData> productData, IEnumerable<CurrencyData> currencyData
        , IEnumerable<MoneyData> moneyData, IEnumerable<VendorData> vendorData)
        {
            if (_currenciesDictionary.Count == 0 
                ||_moniesDictionary.Count == 0 
                ||_productsDictionary.Count == 0 
                ||_vendors.Count == 0 )
            {
                LoadCurrencies(currencyData);
                LoadMoney(moneyData);
                LoadProducts(productData);
                LoadVendors(vendorData);
            }
            foreach (var data in productData)
            {
                Add(ProductFactory.Create(
                    _productsDictionary[data.Id]
                    ,_moniesDictionary[data.PriceId].Currency
                    ,_moniesDictionary[data.PriceId]
                    //in this sale we only have 1 vendor, so no built-in function for selecting a specific one
                    ,_vendors["1"]));
            }
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
                _currenciesDictionary.Add(data.Id
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
                _moniesDictionary.Add(money.Id
                    ,new Money()
                    {
                        Amount = money.Amount
                        ,Currency = _currenciesDictionary[money.CurrencyId]
                    }
                );
            }
        }

        private static void LoadProducts(IEnumerable<ProductData> productData)
        {
            foreach (var data in productData)
            {
                _productsDictionary.Add(data.Id, new Product()
                {
                    Name = data.Name,
                    Price = _moniesDictionary[data.PriceId].Amount
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
                    vendor.Stock.Add(_productsDictionary[productAndQuantityArray[0]].Name,int.Parse(productAndQuantityArray[1]));
                }

                string[] accountBalanceArray = data.AccountBalanceString.Split(';');
                for (int i = 0; i < accountBalanceArray.Length; i++)
                {
                    vendor.AccountBalance.Add(_moniesDictionary[accountBalanceArray[i]]);
                }

                _vendors.Add(data.Id, vendor);
            }
        }
    }
}