using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FixtureFactory.Tests
{
    [TestClass]
    public class AssignValueTests
    {
        private void ValidateValueByCorrectlyType(Type t)
        {
            var a = new AssignValue();
            var value = a.GetValue(t);
            Assert.IsInstanceOfType(value, t);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void ShouldReturnStringValue()
        {
            ValidateValueByCorrectlyType(typeof(string));
        }

        [TestMethod]
        public void ShouldReturnBooleanValue()
        {
            ValidateValueByCorrectlyType(typeof(bool));
        }

        [TestMethod]
        public void ShouldReturnDateTimeValue()
        {
            ValidateValueByCorrectlyType(typeof(DateTime));
        }

        [TestMethod]
        public void ShouldReturnSByteValue()
        {
            ValidateValueByCorrectlyType(typeof(sbyte));
        }
        
        [TestMethod]
        public void ShouldReturnByteValue()
        {
            ValidateValueByCorrectlyType(typeof(byte));
        }

        [TestMethod]
        public void ShouldReturnCharValue()
        {
            ValidateValueByCorrectlyType(typeof(char));
        }

        [TestMethod]
        public void ShouldReturnShortValue()
        {
            ValidateValueByCorrectlyType(typeof(short));
        }

        [TestMethod]
        public void ShouldReturnUShortValue()
        {
            ValidateValueByCorrectlyType(typeof(ushort));
        }

        [TestMethod]
        public void ShouldReturnIntegerValue()
        {
            ValidateValueByCorrectlyType(typeof(int));
        }

        [TestMethod]
        public void ShouldReturnUIntValue()
        {
            ValidateValueByCorrectlyType(typeof(uint));
        }

        [TestMethod]
        public void ShouldReturnLongValue()
        {
            ValidateValueByCorrectlyType(typeof(long));
        }

        [TestMethod]
        public void ShouldReturnULongValue()
        {
            ValidateValueByCorrectlyType(typeof(ulong));
        }

        [TestMethod]
        public void ShouldReturnFloatValue()
        {
            ValidateValueByCorrectlyType(typeof(float));
        }

        [TestMethod]
        public void ShouldReturnDoubleValue()
        {
            ValidateValueByCorrectlyType(typeof(double));
        }

        [TestMethod]
        public void ShouldReturnDecimalValue()
        {
            ValidateValueByCorrectlyType(typeof(decimal));
        }

        [TestMethod]
        public void ShouldReturnArrayValue()
        {
            var t = typeof(Array);
            var a = new AssignValue();
            var value = a.GetValue(t);
            Assert.IsNull(value);
        }
        
        [TestMethod]
        public void ShouldReturnEnumValue()
        {
            var t = typeof(Enum);
            var a = new AssignValue();
            var value = a.GetValue(t);
            Assert.IsNull(value);
        }
    }
}
