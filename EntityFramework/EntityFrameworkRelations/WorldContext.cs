namespace EntityFrameworkRelations
{
    using EntityFrameworkRelations.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WorldContext : DbContext
    {
      
        public WorldContext()
            : base("name=WorldContext")
        {
        }
        public IDbSet<Student> Student { get; set; }
        public IDbSet<StudentAddress> StudentAddress { get; set; }
    }

}