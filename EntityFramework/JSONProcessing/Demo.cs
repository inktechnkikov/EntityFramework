using JSONProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JSONProcessing
{
    class Demo
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dog dog = new Dog("Sharo", "German sheppard");
            Human human = new Human("Pesho");
            dog.Owner = human;
            string serializDog = serializer.Serialize(dog);
            Console.WriteLine(serializDog);
            //For Deserialize object we have create defoult contructor
          //  Dog dog1 = serializer.Deserialize<Dog>(serializDog);
          
        }
    }
}
