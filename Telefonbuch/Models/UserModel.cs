using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserImage { get; set; }
        public DateTime Birthday { get; set; }
        public GenderModel Gender { get; set; }

    }
}