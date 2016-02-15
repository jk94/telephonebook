using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class UserContext : DbContext
    {

        public DbSet<UserModel> UserModels { get; set; }
    }
}