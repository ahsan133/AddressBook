using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookOperation
    {
        private static List<Person> list = new List<Person>();
        public void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("Enter first name");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter city");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter zip code");
            person.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enterphone number");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            list.Add(person);
        }

        public void PrintAddressBook()
        {
            foreach (var entry in list)
            {
                Console.WriteLine("\nAddress Book : \n");
                Console.WriteLine("First name : " + entry.FirstName);
                Console.WriteLine("Last name : " + entry.LastName);
                Console.WriteLine("Address : " + entry.Address);
                Console.WriteLine("City : " + entry.City);
                Console.WriteLine("State : " + entry.State);
                Console.WriteLine("Zip code : " + entry.Zip);
                Console.WriteLine("Phone Number : " + entry.PhoneNumber);
                Console.WriteLine("\n");

                new AddressBookUtility().Utility();
            }
        }
    }
}
