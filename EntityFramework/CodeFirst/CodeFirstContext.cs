namespace CodeFirst
{
    using CodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirstContext : DbContext
    {
       
        public CodeFirstContext()
            : base("name=CodeFirstContext")
        {

        }
        public IDbSet<Cat> Cats { get; set; }

        public IDbSet<Dog> Dogs { get; set; }
    }

    
}