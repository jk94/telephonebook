using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Telefonbuch.Models
{
    public class EmailContext :DbContext
    {
        public DbSet<EmailModel> EmailModels { get; set; } 
    }
}