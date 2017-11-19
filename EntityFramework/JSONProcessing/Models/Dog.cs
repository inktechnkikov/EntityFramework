using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProcessing.Models
{
   public class Dog
    {
            public string Name { get; set; }
            public string Breed { get; set; }
            public Human Owner { get; set; }

        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
        public Dog()
        {

        }

    }
}
