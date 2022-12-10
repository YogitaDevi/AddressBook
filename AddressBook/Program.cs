namespace AddressBook
{
    class Program
    {
        public static List<contact> Person = new List<contact>();
        public static void Main(string[] args)
        {
            AddressBook.Person.CreateContacts();
            AddressBook.Person.editContact();
            AddressBook.Person.Display();
            AddressBook.Person.DeleteContact();
        }
    }
}
