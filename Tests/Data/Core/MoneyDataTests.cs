using BakeSale.Data.Common;
using BakeSale.Data.Core;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Data.Core
{
    [TestClass]
    public class MoneyDataTests : ClassTest<MoneyData, UniqueEntityData>
    {
        [TestMethod]
        public void Amount()
        {
            IsPublicProperty(() => ClassObj.Amount, x => ClassObj.Amount = x);
        }
        [TestMethod]
        public void CurrencyId()
        {
            IsNullablePublicProperty(() => ClassObj.CurrencyId, x => ClassObj.CurrencyId = x);
        }
        [TestMethod]
        public void Currency()
        {
            IsNullablePublicProperty(() => ClassObj.Currency, x => ClassObj.Currency = x);
        }
    }
}