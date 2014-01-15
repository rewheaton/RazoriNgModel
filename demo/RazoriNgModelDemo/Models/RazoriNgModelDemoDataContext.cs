using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RazoriNgModelDemo.Models
{
    public class RazoriNgModelDemoDataContext : DbContext
    {
        public RazoriNgModelDemoDataContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Person> People { get; set; }
    }
}