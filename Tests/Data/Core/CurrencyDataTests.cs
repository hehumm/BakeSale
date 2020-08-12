using BakeSale.Data.Common;
using BakeSale.Data.Core;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Data.Core
{
    [TestClass]
    public class CurrencyDataTests : ClassTest<CurrencyData,UniqueEntityData>
    {
        [TestMethod]
        public void Name()
        {
            IsNullablePublicProperty(() => ClassObj.Name, x => ClassObj.Name = x);
        }
        [TestMethod]
        public void BanknotesAndCoinsInStringFormat()
        {
            IsNullablePublicProperty(() => ClassObj.BanknotesAndCoinsInStringFormat, x => ClassObj.BanknotesAndCoinsInStringFormat = x);
        }
    }
}