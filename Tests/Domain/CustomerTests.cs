using BakeSale.Domain;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Domain
{
    [TestClass]
    public class CustomerTests : ClassTest<Customer, object>
    {
        [TestMethod]
        public void Wallet()
        {
            IsNullablePublicProperty(() => ClassObj.Wallet, x => ClassObj.Wallet = x);
        }
    }
}