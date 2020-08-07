using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Common
{
    [TestClass]
    public abstract class ClassTest<TClass, TBaseClass> : BaseTest<TClass, TBaseClass> where TClass : new()
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            ClassObj = new TClass();
            Type = ClassObj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(ClassObj);
        }


    }
}