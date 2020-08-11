using BakeSale.Data.common;
using BakeSale.Data.Core;

namespace BakeSale.Data
{
    public class ProductData : UniqueEntityData
    {
        public string Name { get; set; }
        public string PriceId { get; set; }
        public virtual MoneyData Price { get; set; }
        public byte[] Image { get; set; }
    }
}
