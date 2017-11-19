using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProcessingDemo.Models
{
   public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
