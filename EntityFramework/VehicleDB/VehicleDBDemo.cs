using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDB.Models;

namespace VehicleDB
{
    class VehicleDBDemo
    {
        static void Main(string[] args)
        {
            VehicleDBContext dBContext = new VehicleDBContext();
            ////dBContext.ElectricCar.Add(new Tesla { Model = "Model S", HP = 360, ProductionData = new DateTime(2016, 4, 20) });
            ////dBContext.GasolineCar.Add(new Mercedes { Model = "E Class", HP = 180, ProductionDate = new DateTime(2014, 8, 6) });
            //dBContext.GasolineCar.Add(new Mercedes { Model = "S Class", HP = 230, ProductionDate = new DateTime(2018, 10, 7) });
            //dBContext.SaveChanges();
            // AddVehiclesToDB(dBContext);
            AddVehiclesToDB(dBContext);

        }
        public static void AddVehiclesToDB(VehicleDBContext vehicleDB)
        {
            vehicleDB.ElectricCar.Add(new Tesla { Model = "Model S", HP = 360, ProductionData = new DateTime(2017, 5, 7) });
            vehicleDB.SaveChanges();
        }
        
    }
}
