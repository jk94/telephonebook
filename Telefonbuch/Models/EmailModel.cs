using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class EmailModel
    {
        public string EmailAddress { get; set; }
        public CategoryModel Category { get; set }
    }
}