namespace AutoMappingObjects
{
    using AutoMappingObjects.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MappingContext : DbContext
    {
      
        public MappingContext()
            : base("name=MappingContext")
        {
        }
        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Book> Books { get; set; }

    }

}