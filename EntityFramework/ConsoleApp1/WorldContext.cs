namespace ConsoleApp1
{
    using ConsoleApp1.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WorldContext : DbContext
    {
      
        public WorldContext()
            : base("name=WorldContext")
        {
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<StudentAddress> StudentAddress { get; set; }
        public IDbSet<School> School { get; set; }
    }

}