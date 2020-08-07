using System.Collections.Generic;
using BakeSale.Core;

namespace BakeSale.Domain
{
    public class Vendor
    {
        public Dictionary<Product,int> Stock { get; set; }
        public List<Money> Wallet { get; set; }

        public void ProcessTransaction()
        {
            //Todo
        }
    }
}
