using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinTables
{
    class Demo
    {
        static void Main(string[] args)
        {
            AdvanceQueryingContext context = new AdvanceQueryingContext();
            var persons = context.People.Join(context.Towns, person => person.Town_Id, town => town.Id,
                (person, town) => new
                {
                    TownName = town.Name,
                    PersonName = person.Name
                }).ToArray();
            foreach (var person in persons)
            {
                Console.WriteLine($"Town {person.TownName} Name {person.PersonName}");
            }
        }
    }
}
