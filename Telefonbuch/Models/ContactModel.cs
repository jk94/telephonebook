using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class ContactModels
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string WebSite { get; set; }
        public DateTime birthday { get; set; }
        public List<PhoneNumberModel> PhoneNumbers { get; set; }
        public List<EmailModel> Emails { get; set; }
        public List<AddressModel> AdressList { get; set; }
        public List<GroupModel> Groups { get; set; }
    }
}