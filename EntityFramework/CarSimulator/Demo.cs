using CarSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Demo
    {
        static void Main(string[] args)
        {
            CarsContext context = new CarsContext();
           
            context.Cars.Add(CreateCar());
            context.SaveChanges();
        }
        public static Car CreateCar()
        {
            return new Mercedes()
            {
                Model ="G class",
                EngineType = "Benzin",
                Manufacturer = "Benz",
                MaxSpeed = 250,
                Price = 140,
                AirCondition = "Yes"
            };
            //context.Cars.Add(new Mercedes()
            //{
            //    Model = "G class",
            //    EngineType = "diesel",
            //    Manufacturer = "Benz",
            //    Price = 25000,
            //    MaxSpeed = 260,
            //    AirCondition = "Yes"
            //});

        }
    }
}
