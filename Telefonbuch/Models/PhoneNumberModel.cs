﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class PhoneNumberModel
    {
        public string PhoneNumber { get; set; }
        public CategoryModel Category{ get; set; }

    }
}