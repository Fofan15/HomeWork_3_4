using System.Globalization;

namespace CodeHomeWork_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new ContactsList();

            contacts.AddContact(new Contact { Name = "John", NumberPhone = "555-1234" });
            contacts.AddContact(new Contact { Name = "Jane", NumberPhone = "555-5678" });
            contacts.AddContact(new Contact { Name = "Bob", NumberPhone = "555-9012" });
            contacts.AddContact(new Contact { Name = "Андрій", NumberPhone = "555-7890" });
            contacts.AddContact(new Contact { Name = "Андрій", NumberPhone = "555-7890" });
            contacts.AddContact(new Contact { Name = "Антон", NumberPhone = "555-7890" });
            contacts.AddContact(new Contact { Name = "Марія", NumberPhone = "555-2345" });
            contacts.AddContact(new Contact { Name = "1Марія", NumberPhone = "555-4615" });
            contacts.AddContact(new Contact { Name = "0 Сергій", NumberPhone = "555-1245" });

            var en = new CultureInfo("en-US");
            var uk = new CultureInfo("uk-UA");

            var foundEnContacts = contacts.GetContactsByLetter('J', en);

            foreach (var item in foundEnContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            var notFoundUkContacts = contacts.GetContactsByLetter('А', en);

            foreach (var item in notFoundUkContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");

            var foundAUkContacts = contacts.GetContactsByLetter('А', uk);

            foreach (var item in foundAUkContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            var foundMUkContacts = contacts.GetContactsByLetter('М', uk);

            foreach (var item in foundMUkContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");

            var notFoundMUkContacts = contacts.GetContactsByLetter('М', en);
            foreach (var item in notFoundMUkContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");

            contacts.GetAllContacts();
        }
    }
}