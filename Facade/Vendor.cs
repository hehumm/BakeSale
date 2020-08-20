using System.Collections.Generic;
using BakeSale.Core;

namespace BakeSale.Facade
{
    public class Vendor
    {
        public Dictionary<Product,int> Stock { get; set; }
        public List<Money> Wallet { get; set; }
    }
}

