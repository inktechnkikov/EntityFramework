namespace JoinTables
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdvanceQueryingContext : DbContext
    {
        public AdvanceQueryingContext()
            : base("name=AdvanceQueryingContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Town>()
                .HasMany(e => e.People)
                .WithOptional(e => e.Town)
                .HasForeignKey(e => e.Town_Id);
        }
    }
}
