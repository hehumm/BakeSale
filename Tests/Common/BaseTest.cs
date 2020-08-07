using System;
using BakeSale.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeSale.Tests.Common
{
    [TestClass]
    public abstract class BaseTest<TClass, TBaseClass>
    {
        protected TClass ClassObj;
        protected Type Type;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            Type = typeof(TClass);
        }


        [TestMethod]
        public virtual void IsInheritedTest()
        {
            Assert.AreEqual(typeof(TBaseClass), Type.BaseType);
        }

        protected static void IsNullablePublicProperty<T>(Func<T> get, Action<T> set)
        {
            IsPublicProperty(get, set);
            set(default);
            Assert.IsNull(get());
        }

        protected static void IsPublicProperty<T>(Func<T> get, Action<T> set)
        {
            var d = (T)IsProperty(get);
            set(d);
            Assert.AreEqual(d, get());
        }

        protected static void IsReadOnlyProperty(object o, string name, object expected)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);
            var actual = property.GetValue(o);
            Assert.AreEqual(expected, actual);
        }

        protected static object IsProperty<T>(Func<T> get)
        {
            var d = (T)GetRandom.Value(typeof(T));
            Assert.AreNotEqual(d, get());
            return d;
        }
    }
}