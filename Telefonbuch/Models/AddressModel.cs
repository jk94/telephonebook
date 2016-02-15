using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public int HouseNumber { get; set; }
        public CategoryModel Category { get; set; }

    }
}