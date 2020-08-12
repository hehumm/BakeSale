using BakeSale.Core;
using BakeSale.Support;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class MoneyTests : ClassTest<Money, object>
    {
        [TestMethod]
        public void Amount()
        {
            IsPublicProperty(() => ClassObj.Amount, x => ClassObj.Amount = x);
        }

        [TestMethod]
        public void Currency()
        {
            IsNullablePublicProperty(() => ClassObj.Currency, x => ClassObj.Currency = x);
        }

        [TestMethod]
        public void TestChangeAmount()
        {
            float initialValue = ClassObj.Amount;
            float amountToChange = GetRandom.Float();
            ClassObj.ChangeAmount(amountToChange);
            Assert.AreEqual(initialValue + amountToChange, ClassObj.Amount);
            ClassObj.ChangeAmount(-amountToChange);
            Assert.AreEqual(initialValue, ClassObj.Amount);
        }
    }
}