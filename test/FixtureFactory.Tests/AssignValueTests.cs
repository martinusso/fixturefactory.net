using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FixtureFactory.Tests
{
    [TestClass]
    public class AssignValueTests
    {
        private void ValidateValueByCorrectlyType(Type t)
        {
            var generator = new GeneratorValues();
            var value = generator.GetValue(t);
            Assert.IsInstanceOfType(value, t);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void ShouldReturnStringValue()
        {
            var t = typeof(string);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnBooleanValue()
        {
            var t = typeof(bool);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnDateTimeValue()
        {
            var t = typeof(DateTime);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnSByteValue()
        {
            var t = typeof(sbyte);
            ValidateValueByCorrectlyType(t);
        }
        
        [TestMethod]
        public void ShouldReturnByteValue()
        {
            var t = typeof(byte);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnCharValue()
        {
            var t = typeof(char);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnShortValue()
        {
            var t = typeof(short);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnUShortValue()
        {
            var t = typeof(ushort);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnIntegerValue()
        {
            var t = typeof(int);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnUIntValue()
        {
            var t = typeof(uint);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnLongValue()
        {
            var t = typeof(long);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnULongValue()
        {
            var t = typeof(ulong);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnFloatValue()
        {
            var t = typeof(float);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnDoubleValue()
        {
            var t = typeof(double);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnDecimalValue()
        {
            var t = typeof(decimal);
            ValidateValueByCorrectlyType(t);
        }

        [TestMethod]
        public void ShouldReturnArrayValue()
        {
            var t = typeof(Array);
            var assigner = new GeneratorValues();
            var value = assigner.GetValue(t);
            Assert.IsNull(value);
        }
        
        [TestMethod]
        public void ShouldReturnEnumValue()
        {
            var t = typeof(Enum);
            var assigner = new GeneratorValues();
            var value = assigner.GetValue(t);
            Assert.IsNull(value);
        }
    }
}
