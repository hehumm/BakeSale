using BakeSale.Data.common;

namespace BakeSale.Data.Core
{
    public class MoneyData : UniqueEntityData
    {
        public float Amount { get; set; }
        public string CurrencyId { get; set; }
        public virtual CurrencyData Currency { get; set; }
    }
}