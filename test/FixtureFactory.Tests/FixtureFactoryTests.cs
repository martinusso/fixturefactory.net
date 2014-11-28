using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FixtureFactory.Tests.Helpers;

namespace FixtureFactory.Tests
{
    [TestClass]
    public class FixtureFactoryTests
    {
        [TestMethod]
        public void ShouldReturnObjectOfSameType()
        {
            FixtureFactory.Make(typeof(Person));
            var f = (Person)FixtureFactory.From(typeof(Person)).GetFake();
            Assert.AreEqual(f.GetType(), typeof(Person));
        }

        [TestMethod]
        public void ShouldReturnObjectOfSameTypeWithoutMake()
        {
            var f = (Person)FixtureFactory.From(typeof(Person)).GetFake();
            Assert.AreEqual(f.GetType(), typeof(Person));
        }

        [TestMethod]
        public void ShouldReturnObjectOfSameTypeWithGetFakeOfMethod()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.AreEqual(f.GetType(), typeof(Person));
        }

        [TestMethod]
        public void ShouldReturnObjectWithStringValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.Name);
        }

        [TestMethod]
        public void ShouldReturnObjectWithIntValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.Age);
        }

        [TestMethod]
        public void ShouldReturnObjectWithDateTimeValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.Birthday);
        }
    }
}
