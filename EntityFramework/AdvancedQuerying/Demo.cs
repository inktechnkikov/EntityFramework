using AdvancedQuerying;
using AdvancedQuerying.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuerying
{
    class Demo
    {
        static void Main(string[] args)
        {
            WorldContext context = new WorldContext();
          //  context.Towns.Add(AddTown());
            context.SaveChanges();
            PrintAllPersons(context);
        }
        public static Town AddTown()
        {
            return new Town()
            {
                Name = "Plovdiv",
                Persons = new List<Person>()
                {
                    new Person()
                    {
                        Name = "Pesho"
                    },
                    new Person()
                    {
                        Name = "Gosho"
                    },
                    new Person()
                    {
                        Name = "Momo"
                    }
                }
            };
        }
        public static void PrintAllPersons(WorldContext context)
        {
            var persons = context.Database.SqlQuery<Person>("select * from People");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }

        }
    }
}
