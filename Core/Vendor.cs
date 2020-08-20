using System.Collections.Generic;

namespace BakeSale.Core
{
    public class Vendor
    {
        public Dictionary<string,int> Stock { get; set; }
        public List<Money> AccountBalance { get; set; }
    }
}

