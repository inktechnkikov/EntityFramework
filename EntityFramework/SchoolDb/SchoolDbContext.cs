namespace SchoolDb
{
    using SchoolDb.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolDbContext : DbContext
    {
       
        public SchoolDbContext()
            : base("name=SchoolDbContext")
        {
        }
        public DbSet<Student> Students { get; set; }


        public DbSet<Teacher> Teachers { get; set; }

    }
    
}