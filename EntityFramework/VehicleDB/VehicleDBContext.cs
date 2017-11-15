namespace VehicleDB
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using VehicleDB.Models;

    public class VehicleDBContext : DbContext
    {

        public VehicleDBContext()
            : base("name=VehicleDBContext")
        {
        }

        public IDbSet<Tesla> ElectricCar { get; set; }

        public IDbSet<Mercedes> GasolineCar { get; set; }

        public IDbSet<Person> People { get; set; }
    }
}