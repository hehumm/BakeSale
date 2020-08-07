using BakeSale.Core;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class ProductTests : ClassTest<Product, object>
    {
        [TestMethod]
        public void Name()
        {
            IsNullablePublicProperty(() => ClassObj.Name, x => ClassObj.Name = x);
        }

        [TestMethod]
        public void Price()
        {
            IsPublicProperty(() => ClassObj.Price, x => ClassObj.Price = x);
        }
    }
}