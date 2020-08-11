using BakeSale.Data.common;

namespace BakeSale.Data.Core
{
    public class CurrencyData : UniqueEntityData
    {
        public string Name { get; set; }

        public string BanknotesAndCoinsInStringFormat { get; set; }
    }
}