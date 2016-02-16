using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string WebSite { get; set; }
        public DateTime Birthday { get; set; }
        public List<PhoneNumberModel> PhoneNumbers { get; set; }
        public List<EmailModel> Emails { get; set; }
        public List<AddressModel> AddressList { get; set; }
        public List<GroupModel> Groups { get; set; }

        public ContactModel()
        {
            this.Name = "";
            this.FirstName = "";
            this.MiddleName = "";
            this.WebSite = "";
            this.Birthday = DateTime.Now;
            this.PhoneNumbers = new List<PhoneNumberModel>();
            this.Emails = new List<EmailModel>();
            this.AddressList = new List<AddressModel>();
            this.Groups = new List<GroupModel>();
        }
    }
}