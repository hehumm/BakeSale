using BakeSale.Domain;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Domain
{
    [TestClass]
    public class VendorTests : ClassTest<Vendor, object>
    {
        [TestMethod]
        public void Wallet()
        {
            IsNullablePublicProperty(() => ClassObj.Wallet, x => ClassObj.Wallet = x);
        }

        [TestMethod]
        public void Stock()
        {
            //Todo: get it working
        }
    }
}