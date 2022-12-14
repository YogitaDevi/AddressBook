using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_AddMultipleContact
{
    public class Person
    {
        public static List<Contact> person = new List<Contact>();

        public static object Remove { get; private set; }

        public static void CreateContacts()
        {
            Contact contacts = new Contact();

            Console.WriteLine("Enter First Name: ");
            contacts.FName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contacts.LName = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode: ");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter E-mail: ");
            contacts.Email = Console.ReadLine();
            person.Add(contacts);
        }
        public static void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName: " + data.FName + "2.LastName: " + data.LName + "3.Address: " + data.Address + "4.City: " + data.City + "5.State: " + data.State + "6.Zipcode: " + data.Zipcode + "7.PhoneNumber: " + data.PhoneNumber);
            }
        }
        public static void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string fName = Console.ReadLine();
                                data.FName = fName;
                                break;

                            case 2:
                                string lName = Console.ReadLine();
                                data.LName = lName;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;

                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;

                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;

                            case 6:
                                int zipcode = Convert.ToInt32(Console.ReadLine());
                                data.Zipcode = zipcode;
                                break;

                            case 7:
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
        public static void DeleteContact(string name)
        {
            Contact contacts = new Contact();
            foreach (var data in person)
            {
                if (data.FName == name)
                {
                    contacts = data;
                }
            }
            person.Remove(contacts);
        }
        public static void AddContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Please confirm how much contact you want to create:");
            int contactsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contactsCount; i++)
            {
                Console.WriteLine("Enter details for " + i + " Contact");

                Console.WriteLine("Enter FirstName: ");
                contacts.FName = Console.ReadLine();

                Console.WriteLine("Enter LastName: ");
                contacts.LName = Console.ReadLine();

                Console.WriteLine("Enter Adress: ");
                contacts.Address = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter State: ");
                contacts.State = Console.ReadLine();

                Console.WriteLine("Enter Zipcode: ");
                contacts.Zipcode = (int)Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Phone Number: ");
                contacts.PhoneNumber = (int)Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter EmailId: ");
                contacts.Email = Console.ReadLine();

                person.Add(contacts);
                Console.WriteLine("Contact added Successfully....");
            }
        }
    }
}
