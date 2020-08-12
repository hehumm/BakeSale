using BakeSale.Data.Common;
using BakeSale.Data.Domain;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Data.Domain
{
    [TestClass]
    public class VendorDataTests : ClassTest<VendorData, UniqueEntityData>
    {
        [TestMethod]
        public void ProductIdsAndQuantities()
        {
            IsNullablePublicProperty(() => ClassObj.ProductIdsAndQuantities, x => ClassObj.ProductIdsAndQuantities = x);
        }
        [TestMethod]
        public void AccountBalanceString()
        {
            IsNullablePublicProperty(() => ClassObj.AccountBalanceString, x => ClassObj.AccountBalanceString = x);
        }
    }
}