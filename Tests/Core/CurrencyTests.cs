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
            IsReadOnlyProperty(ClassObj, "Name", ClassObj.Name);
        }
    }
}