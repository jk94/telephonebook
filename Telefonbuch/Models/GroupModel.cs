using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class GroupModel
    {
        public string Name { get; set; }
        public UserModel Creator { get; set; }
    }
}