using System.Collections.Generic;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage.InformationAvailabilityState
{
    public interface IInformationAvailabilityState
    {
        void CreateObjects(IEnumerable<CurrencyData> currencyData
            , IEnumerable<MoneyData> moneyData, IEnumerable<ProductData> productData
            , IEnumerable<VendorData> vendorData
            , ProductsObjectsList contextList);
    }
}