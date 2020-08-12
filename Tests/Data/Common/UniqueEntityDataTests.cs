using BakeSale.Data.Common;
using BakeSale.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Data.Common
{
    [TestClass]
    public class UniqueEntityDataTests : AbstractClassTest<UniqueEntityData, object>
    {
        private class TestClass : UniqueEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            ClassObj = new TestClass();
        }
        [TestMethod]
        public void Id()
        {
            IsNullablePublicProperty(() => ClassObj.Id, x => ClassObj.Id = x);
        }
    }
}