using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class CodeFirstDemo
    {
        static void Main(string[] args)
        {
            CodeFirstContext codeFirst = new CodeFirstContext();
            codeFirst.Cats.Add(new Cat { Name = "Disco", Breed = "Persian" });
            codeFirst.Dogs.Add(new Dog { Name = "Pesho", Breed = "Pitbul", BirthDate = new DateTime(2016, 2, 15) });
            codeFirst.SaveChanges();
        }
    }
}
