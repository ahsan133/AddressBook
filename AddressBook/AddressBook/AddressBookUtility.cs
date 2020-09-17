using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBookUtility
    {
        public void Utility()
        {
            Console.WriteLine("Enter the operation");
            Console.WriteLine("1.Add Person \n2.Edit person");
            int choice = Convert.ToInt32(Console.ReadLine());

            AddressBookOperation operation = new AddressBookOperation();

            switch (choice)
            {
                case 1:
                    operation.AddPerson();
                    break;
                case 2:
                    operation.EditPerson();
                    break;
            }
            operation.PrintAddressBook();
        }

    }
}
