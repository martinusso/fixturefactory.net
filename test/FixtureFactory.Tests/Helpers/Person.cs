using System;

namespace FixtureFactory.Tests.Helpers
{
    class Person
    {
        private string _privateField;
        public string _publicField;

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public bool Designate { get; set; }
        public Address AddressInfo { get; set; }
        public Gender Gender { get; set; }

        public string GetPrivateId()
        {
            return _privateField;
        }

        public string GetPublicId()
        {
            return _publicField;
        }
    }
}
