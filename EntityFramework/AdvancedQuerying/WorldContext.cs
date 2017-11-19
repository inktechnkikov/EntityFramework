namespace AdvancedQuerying
{
    using AdvancedQuerying.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WorldContext : DbContext
    {
      
        public WorldContext()
            : base("name=WorldContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Town> Towns { get; set; }
    }

}