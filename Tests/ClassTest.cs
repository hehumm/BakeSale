using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests
{
    [TestClass]
    public abstract class ClassTest<TClass, TBaseClass> : BaseTest<TClass, TBaseClass> where TClass : new()
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            BaseObj = new TClass();
            Type = BaseObj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(BaseObj);
        }


    }
}