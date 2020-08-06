using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests
{
    [TestClass]
    public abstract class AbstractClassTest<TClass, TBaseClass> : BaseTest<TClass, TBaseClass>
    {
        [TestMethod]
        public void IsAbstract()
        {
            Assert.IsTrue(Type.IsAbstract);
        }
    }
}