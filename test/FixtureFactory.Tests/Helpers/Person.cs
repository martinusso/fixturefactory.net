using System;
using System.Collections.Generic;

namespace FixtureFactory.Tests.Helpers
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public bool Designate { get; set; }
        public Address AddressInfo { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<string> Phones { get; set; }
        public IList<string> Documents { get; set; }
        public ICollection<FamilyMember> FamilyMembers { get; set; }
        public IDictionary<bool, Contact> Contacts { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public struct Contact
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
