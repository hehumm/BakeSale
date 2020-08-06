using BakeSale.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class CurrencyTests : ClassTest<Currency, object>
    {
        [TestMethod]
        public void Name()
        {
            IsReadOnlyProperty(BaseObj, "Name", BaseObj.Name);
        }
    }
}