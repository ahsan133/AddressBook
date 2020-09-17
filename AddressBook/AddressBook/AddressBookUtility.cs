using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBookUtility
    {
        public void Utility()
        {
            Console.WriteLine("Enter the operation");
            Console.WriteLine("1.Add Person \n2.Edit person \n3.Delete person");
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
            }
            collection.PrintAddressBook();
        }

    }
}
