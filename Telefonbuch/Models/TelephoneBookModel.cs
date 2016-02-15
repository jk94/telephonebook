using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class TelephoneBookModel
    {
        public List<ContactModel> Contacts { get; set; }
        
        // TODO
        public void addContact(ContractModel contact)
        {
            this.Contacts.add(contact);
        }

        public ContactModel Contacts(int index)
        {
            this.Contacts.get(index);
        }
    }
}