﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    public class Collection
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

            if(Search(person.FirstName,person.LastName).Equals("duplicate"))
            {
                Console.WriteLine("\nname already exist");
            }
            else
            {
                list.Add(person);
            }
        }

        public string Search(string firstName, string lastName)
        {
            foreach (var entry in list)
            {
                if (entry.FirstName == firstName && entry.LastName == lastName)
                {
                    return "duplicate";
                }
            }
            return "different";
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

        public void SortAddressBookByName()
        {
            list = list.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }      
        
        public void SortAddressBookByCity()
        {
            list = list.OrderBy(x => x.City).ToList();
        }

        public void SortAddressBookByState()
        {
            list = list.OrderBy(x => x.State).ToList();
        }

        public void SortAddressBookByZip()
        {
            list = list.OrderBy(x => x.Zip).ToList();
        }

        public void ViewPersonByCity()
        {
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("names :");
            foreach (var entry in list)
            {
                if(entry.City == city)
                {
                    Console.WriteLine("\n"+entry.FirstName +" "+ entry.LastName );
                }
                else
                {
                    Console.WriteLine("person not found");
                }
            }
        }

        public void ViewPersonByState()
        {
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("names :");
            foreach (var entry in list)
            {
                if (entry.State == state)
                {
                    Console.WriteLine("\n" + entry.FirstName + " " + entry.LastName);
                }
                else
                {
                    Console.WriteLine("person not found");
                }
            }
        }

        public void SearchPerson()
        {
            Console.WriteLine("Enter full name of person to search");
            string fullName = Console.ReadLine();
            string[] name = fullName.Split(" ");
            foreach(var entry in list)
            {
                if(entry.FirstName == name[0] && entry.LastName == name[1])
                {
                    Console.WriteLine("First name : " + entry.FirstName + "\nLast name : " + entry.LastName + 
                        "\nAddress : " + entry.Address + "\nCity : " + entry.City + "\nState : " + 
                        entry.State + "\nZip code : " + entry.Zip + "\nPhone Number : " + entry.PhoneNumber);
                }
                else
                {
                    Console.WriteLine("person not found");
                }
            }
        }
    }
}
