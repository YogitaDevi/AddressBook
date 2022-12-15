using System;

namespace UC3_EditContact
{
    class Program
    {
        public static List<Contact> Person = new List<Contact>();
        public static void Main(string[] args)
        {
            UC3_EditContact.Person.CreateContacts();
            UC3_EditContact.Person.editContact();
        }
    }
}
