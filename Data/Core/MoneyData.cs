using BakeSale.Data.Common;

namespace BakeSale.Data.Core
{
    public class MoneyData : UniqueEntityData
    {
        public float Amount { get; set; }
        public string CurrencyId { get; set; }
        public virtual CurrencyData Currency { get; set; }
    }
}