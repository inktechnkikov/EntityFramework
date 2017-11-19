using JSONProcessingDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProcessingDemo
{ 
    class Demo
    {
        static void Main(string[] args)
        {
            Person person = new Person("Robert",24);
            Cat cat = new Cat("Tiger", 1);
            person.Pet = cat;
            //string convertToJs = JsonConvert.SerializeObject(person);
            //Console.WriteLine(convertToJs);
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Pesho", "Plovdiv");
            data.Add("Gosho", "Sofia");
            data.Add("Unufri", "Varna");
            string serialization = JsonConvert.SerializeObject(data);
            Dictionary<string, string> desirializal = JsonConvert.DeserializeObject<Dictionary<string, string>>(serialization);
            Console.WriteLine(serialization);
        }
    }
}
