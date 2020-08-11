using BakeSale.Data.Common;
using BakeSale.Data.Core;

namespace BakeSale.Data.Domain
{
    public class ProductData : UniqueEntityData
    {
        public string Name { get; set; }
        public string PriceId { get; set; }
        public virtual MoneyData Price { get; set; }
        public byte[] Image { get; set; }
    }
}
