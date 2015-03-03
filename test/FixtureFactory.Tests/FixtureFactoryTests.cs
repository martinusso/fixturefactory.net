using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FixtureFactory.Tests.Helpers;

namespace FixtureFactory.Tests
{
    [TestClass]
    public class FixtureFactoryTests
    {
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
            Assert.IsNotNull(f.DateOfBirth);
        }

        [TestMethod]
        public void ShouldReturnObjectWithBooleanValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.Designate);
        }

        [TestMethod]
        public void ShouldReturnObjectWithEnumAssigned()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.Gender);
        }

        [TestMethod]
        public void ShouldNotReturnPrivateFieldWithValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNull(f.GetPrivateId());
        }

        [TestMethod]
        public void ShouldReturnPublicFieldWithValue()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.GetPublicId());
        }

        [TestMethod]
        public void ShouldReturnChildObjectWithValues()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.IsNotNull(f.AddressInfo.Street);
            Assert.IsNotNull(f.AddressInfo.City);
            Assert.IsNotNull(f.AddressInfo.State);
            Assert.IsNotNull(f.AddressInfo.PostalCode);
        }
    }
}
