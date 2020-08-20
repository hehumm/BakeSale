using BakeSale.Core;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Core
{
    [TestClass]
    public class VendorTests : ClassTest<Vendor, object>
    {
        [TestMethod]
        public void Stock()
        {
            IsNullablePublicProperty(() => ClassObj.Stock, x => ClassObj.Stock = x);
        }

        [TestMethod]
        public void Wallet()
        {
            IsNullablePublicProperty(() => ClassObj.AccountBalance, x => ClassObj.AccountBalance = x);
        }
    }
}