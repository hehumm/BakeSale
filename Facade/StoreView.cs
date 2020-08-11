using System.Collections.Generic;
using BakeSale.Core;

namespace BakeSale.Facade
{
    public class StoreView
    {
        public Dictionary<Product,int> Stock { get; set; }
        public List<Money> Wallet { get; set; }
    }
}

