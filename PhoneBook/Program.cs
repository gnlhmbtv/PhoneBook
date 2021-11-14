using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console PhoneBook App");
            Console.WriteLine("Select operation:");
            Console.WriteLine("1-Add Contact");
            Console.WriteLine("2-Display contact by number");
            Console.WriteLine("3-View all contacts");
            Console.WriteLine("4-Search contacts for a given name");
            Console.WriteLine("0-Exit");
            var userinput = Console.ReadLine();

            var phoneBook = new PhoneBook();
            while (true)
            {
                switch (userinput)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Input contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Contact number to search with name:");
                        var searchName = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchName);
                        break;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                Console.WriteLine("Select operation or press 0 to exit.");
                userinput = Console.ReadLine();
            }   
        }
    }
}
