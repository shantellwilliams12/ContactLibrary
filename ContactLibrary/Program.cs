using System;

namespace ContactLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your PhoneBook App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1) Add Contact");
            Console.WriteLine("2) Display contact by number");
            Console.WriteLine("3) View all contacts");
            Console.WriteLine("4) Search contacts by name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        DateTime now = DateTime.Now;
                        Console.WriteLine($"Contact {name} and {number} was successfully added at {DateTime.Now} ");

                        break;
                         

                    case "2":
                        Console.WriteLine("Contact number: ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);

                        break;

                    case "3":
                        phoneBook.DisplayAllContact();

                        break;

                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;

                    case "x":
                        Console.WriteLine("See you next time!!");
                        return;

                    default:
                        Console.WriteLine("Please select valid operation");
                        break;
                }

                
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}