using System;
using System.Collections.Generic;

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
            Console.WriteLine("Enter phone number");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            list.Add(person);
        }

        public void EditPerson()
        {
            Console.WriteLine("Enter full name of person to edit");
            string fullName = Console.ReadLine();
            string[] name = fullName.Split(" ");
            int count = 0;
            foreach(var entry in list)
            {
                if(entry.FirstName == name[0] && entry.LastName == name[1])
                {
                    break;
                }
                count++;
            }

            Console.WriteLine("enter 1 to edit address\nenter 2 to edit city\nenter 3 to edit state\n" +
                               "enter 4 to edit zip code\nenter 5 to edit phone number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter new address");
                    list[count].Address = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("enter new city");
                    list[count].City = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("enter new state");
                    list[count].State = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("enter new zip code");
                    list[count].Zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("enter new phone number");
                    list[count].PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }

        public void DeletePerson()
        {
            Console.WriteLine("Enter full name of person to delete");
            string fullName = Console.ReadLine();
            string[] name = fullName.Split(" ");
            int count = 0;
            foreach (var entry in list)
            {
                if (entry.FirstName == name[0] && entry.LastName == name[1])
                {
                    break;
                }
                count++;
            }

            list.Remove(list[count]);
        }

        public void PrintAddressBook()
        {
            Console.WriteLine("\nAddress Book : \n");
            foreach (var entry in list)
            {
                Console.WriteLine("First name : " + entry.FirstName);
                Console.WriteLine("Last name : " + entry.LastName);
                Console.WriteLine("Address : " + entry.Address);
                Console.WriteLine("City : " + entry.City);
                Console.WriteLine("State : " + entry.State);
                Console.WriteLine("Zip code : " + entry.Zip);
                Console.WriteLine("Phone Number : " + entry.PhoneNumber);
                Console.WriteLine("\n");
            }

            new AddressBookUtility().Utility();
        }
    }
}
