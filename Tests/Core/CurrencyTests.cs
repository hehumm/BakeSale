using BakeSale.Core;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class CurrencyTests : ClassTest<Currency, object>
    {
        [TestMethod]
        public void Name()
        {
            IsNullablePublicProperty(() => ClassObj.Name, x => ClassObj.Name = x);
        }

        [TestMethod]
        public void BanknotesAndCoins()
        {
            IsNullablePublicProperty(() => ClassObj.BanknotesAndCoins, x => ClassObj.BanknotesAndCoins = x);
        }
    }
}