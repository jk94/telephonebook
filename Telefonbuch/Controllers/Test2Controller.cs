using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using Telefonbuch.Models;

namespace Telefonbuch.Controllers
{
    public class Test2Controller : ApiController
    {
        [Authorize]
        public ContactModel Get()
        {
            TelephoneBookModel telephoneBookModel = new TelephoneBookModel();
            telephoneBookModel.addContact(new ContactModel());
            return telephoneBookModel.getContact(0);
        }
    }
}