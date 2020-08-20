using System.Collections.Generic;
using BakeSale.Data.Common;
using BakeSale.Data.Core;

namespace BakeSale.Data.Domain
{
    public class VendorData : UniqueEntityData
    {
        public string ProductIdsAndQuantities { get; set; }
        //Todo: rename to MoneyDataId in a new migration
        public string AccountBalanceString { get; set; }
    }
}