using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NurseryExample3.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("Connection")
        {

        }
        public DbSet<NurseryProduct> nurseryProducts { get; set; }
        public DbSet<NurseryCategory> nurseryCategories { get; set; }

    }
}