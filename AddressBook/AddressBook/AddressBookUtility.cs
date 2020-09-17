using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBookUtility
    {
        public void Utility()
        {
            Console.WriteLine("Enter the operation");
            Console.WriteLine("1.Add Person \n2.Edit person \n3.Delete person \n4.Sort Address book");
            int choice = Convert.ToInt32(Console.ReadLine());

            Collection collection = new Collection();

            switch (choice)
            {
                case 1:
                    collection.AddPerson();
                    break;
                case 2:
                    collection.EditPerson();
                    break;
                case 3:
                    collection.DeletePerson();
                    break;
                case 4:
                    SortAddressBook();
                    break;
                default:
                    break;
            }
            collection.PrintAddressBook();
        }

        public void SortAddressBook()
        {
            Console.WriteLine("1.Sort by name \n2.Sort by city \n3.Sort by state \n4. Sort by Zip code");
            int choice = Convert.ToInt32(Console.ReadLine());

            Collection collection = new Collection();

            switch (choice)
            {
                case 1:
                    collection.SortAddressBookByName();
                    break;
                case 2:
                    collection.SortAddressBookByCity();
                    break;
                case 3:
                    collection.SortAddressBookByState();
                    break;
                case 4:
                    collection.SortAddressBookByZip();
                    break;
                default:
                    break;
            }
        }
    }
}
