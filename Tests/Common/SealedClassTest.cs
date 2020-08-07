using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Common
{
    [TestClass]
    public abstract class SealedClassTest<TClass, TBaseClass> : ClassTest<TClass, TBaseClass> where TClass : new()
    {
        [TestMethod]
        public void IsSealed()
        {
            Assert.IsTrue(Type.IsSealed);
        }
    }
}