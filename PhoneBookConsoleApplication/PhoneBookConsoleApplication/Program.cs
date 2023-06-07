using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console PhoneBook App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 add contact");
            Console.WriteLine("2 Display Conatct by number");
            Console.WriteLine("3 view all contacts");
            Console.WriteLine("4 search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit ");

            var userInput = Console.ReadLine();
            var PhoneBookConsole = new PhoneBookConsole();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        PhoneBookConsole.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Contact Number to search");
                        var searchNumber = Console.ReadLine();
                        PhoneBookConsole.DisplayContact(searchNumber);
                        break;
                    case "3":
                        PhoneBookConsole.DisplayAllContact();

                        break;
                    case "4":
                        Console.WriteLine("Name search phase");
                        var searchPhase = Console.ReadLine();

                        PhoneBookConsole.DisplayMarchingContacts(searchPhase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("select valid operation");
                        break;

                }

                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
            
        }
    }
}
