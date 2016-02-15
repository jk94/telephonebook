using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class TelephoneBookModel
    {
        public List<ContactModel> Contacts { get; set; }

        public TelephoneBookModel()
        {
            this.Contacts = new List<ContactModel>();
        }
        
        // TODO
        public void addContact(ContactModel contact)
        {
            this.Contacts.Add(contact);
        }

        public ContactModel getContact(int index)
        {
            return this.Contacts.ElementAtOrDefault(index);
        }
    }
}