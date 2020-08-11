using System.Collections.Generic;
using BakeSale.Data.Common;
using BakeSale.Data.Core;

namespace BakeSale.Data.Domain
{
    public class VendorData : UniqueEntityData
    {
        public string ProductIdsAndQuantities { get; set; }
        public string AccountBalanceString { get; set; }
    }
}