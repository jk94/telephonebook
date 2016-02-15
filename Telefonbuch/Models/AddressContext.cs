using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class AddressContext : DbContext
    {
        public DbSet<AddressModel> AddressModels { get; set; } 
    }
}