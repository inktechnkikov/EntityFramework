using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProcessingDemo.Models
{
   public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Cat Pet { get; set; }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
