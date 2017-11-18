namespace CarSimulator
{
    using CarSimulator.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarsContext : DbContext
    {
      
        public CarsContext()
            : base("name=CarsContext")
        {
        }
        public IDbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Mercedes>().ToTable("Mercedes Cars");
            modelBuilder.Entity<Seat>().ToTable("Seat Cars");
            base.OnModelCreating(modelBuilder);
        }
    }

}