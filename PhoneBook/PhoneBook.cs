using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; }   
        private void DisplayContactDetail(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name},{contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetail(contact);
            }
        }
        public void Add(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetail(contact);
            }
        }
        public void DisplayAllContacts()
        {
            DisplayContactsDetails(_contacts);
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
