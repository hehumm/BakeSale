using System.Collections.Generic;
using BakeSale.Core;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage.InformationAvailabilityState
{
    public abstract class InformationAvailabilityAbstract : IInformationAvailabilityState
    {
        protected static readonly Dictionary<string, Money> MoniesDictionary = new Dictionary<string, Money>();
        protected static readonly Dictionary<string,Currency> CurrenciesDictionary = new Dictionary<string, Currency>();
        protected static readonly Dictionary<string,Product> ProductsDictionary = new Dictionary<string, Product>();
        protected static readonly Dictionary<string,Vendor> Vendors = new Dictionary<string, Vendor>();

        public abstract void CreateObjects(IEnumerable<CurrencyData> currencyData, IEnumerable<MoneyData> moneyData, IEnumerable<ProductData> productData,
            IEnumerable<VendorData> vendorData, ProductsObjectsList contextList);

        protected void CallFactory(IEnumerable<ProductData> productData, ProductsObjectsList contextList)
        {
            foreach (var data in productData)
            {
                contextList.Add(ProductFactory.Create(
                    ProductsDictionary[data.Id]
                    ,MoniesDictionary[data.PriceId].Currency
                    ,MoniesDictionary[data.PriceId]
                    //in this sale we only have 1 vendor, so no built-in function for selecting a specific one
                    ,Vendors["1"]));
            }
        }
    }
}