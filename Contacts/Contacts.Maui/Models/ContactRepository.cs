using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{

    //Repository: Serves the purpose of performing data operations in the memory -> With clean architecture you use many to deal with DBs for example and use dependency injection to inject the repositories into application logic layer 
    //But for now we're gonna only use this 
    //THE STATIC REPOSITORY LIKE THIS IS MAINLY FOR TEACHING PURPOSES (having it all in a central area)
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact {ContactId = 1, Name="John Doe", Email="JohnDoe@gmail.com"},
            new Contact {ContactId = 2, Name="Jane Doe", Email="JaneDoe@gmail.com"},
            new Contact {ContactId = 3, Name="Tom Hanks", Email="Tomhanks@gmail.com"},
            new Contact {ContactId = 4, Name="Frank Liu", Email="FrankLiu@gmail.com"}
        };

        //Method to get the contacts
        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
