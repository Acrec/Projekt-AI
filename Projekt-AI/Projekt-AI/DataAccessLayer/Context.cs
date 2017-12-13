using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using Projekt_AI.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projekt_AI.DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {


        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Position_on_Order> Position_on_Order { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}