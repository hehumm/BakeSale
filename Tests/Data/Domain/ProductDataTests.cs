using BakeSale.Data.Common;
using BakeSale.Data.Domain;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Data.Domain
{
    [TestClass]
    public class ProductDataTests : ClassTest<ProductData,UniqueEntityData>
    {
        [TestMethod]
        public void Name()
        {
            IsNullablePublicProperty(() => ClassObj.Name, x => ClassObj.Name = x);
        }
        [TestMethod]
        public void PriceId()
        {
            IsNullablePublicProperty(() => ClassObj.PriceId, x => ClassObj.PriceId = x);
        }
        [TestMethod]
        public void Price()
        {
            IsNullablePublicProperty(() => ClassObj.Price, x => ClassObj.Price = x);
        }
        [TestMethod]
        public void Image()
        {
            IsNullablePublicProperty(() => ClassObj.Image, x => ClassObj.Image = x);
        }
    }
}