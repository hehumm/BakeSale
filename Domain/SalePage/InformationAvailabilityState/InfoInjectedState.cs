using System.Collections.Generic;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage.InformationAvailabilityState
{
    public class InfoInjectedState : InformationAvailabilityAbstract
    {
        public override void CreateObjects(IEnumerable<CurrencyData> currencyData
            , IEnumerable<MoneyData> moneyData, IEnumerable<ProductData> productData
            , IEnumerable<VendorData> vendorData, ProductsObjectsList contextList)
        {
            CallFactory(productData, contextList);
        }
    }
}