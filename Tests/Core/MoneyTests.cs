using BakeSale.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class MoneyTests : ClassTest<Money, object>
    {
        [TestMethod]
        public void Amount()
        {
            IsProperty(() => BaseObj.Amount);
        }

        [TestMethod]
        public void Currency()
        {
            IsReadOnlyProperty(BaseObj, "Currency", BaseObj.Currency);
        }

        [TestMethod]
        public void TestChangeMoneyAmount()
        {

        }
    }
}