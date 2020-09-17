using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phoneNumber;

        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public long Zip { get => this.zip; set => this.zip = value; }
        public long PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
    }
}
