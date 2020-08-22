using System.Collections.Generic;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;
using BakeSale.Domain.SalePage.InformationAvailabilityState;

namespace BakeSale.Domain.SalePage
{
    public class ProductsObjectsList : List<ProductObject>
    {
        public static IInformationAvailabilityState State { get; set; } = new InfoNotInjectedState();

        public ProductsObjectsList(IEnumerable<ProductData> productData, IEnumerable<CurrencyData> currencyData
        , IEnumerable<MoneyData> moneyData, IEnumerable<VendorData> vendorData)
        {
            State.CreateObjects(currencyData, moneyData, productData, vendorData, this);
        }
    }
}