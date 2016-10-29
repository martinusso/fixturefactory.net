using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FixtureFactory.Tests.Helpers;

namespace FixtureFactory.Tests
{
    [TestClass]
    public class FixtureFactoryTests
    {
        [TestMethod]
        public void TestGetFakeOf()
        {
            var f = FixtureFactory.GetFakeOf<Person>();
            Assert.AreEqual(f.GetType(), typeof(Person), "Should return an object of same type with GetFakeOf method");
            Assert.IsNotNull(f.Name, "invalid Name");
            Assert.IsNotNull(f.Age, "invalid Age");
            Assert.IsNotNull(f.DateOfBirth, "Invalid DateOfBirth");
            Assert.IsNotNull(f.Designate, "Invalid Designate");
            Assert.IsNotNull(f.Gender, "Invalid Gender");
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
