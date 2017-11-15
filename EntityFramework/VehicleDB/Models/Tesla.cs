using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDB.Models
{
   public class Tesla
    {
        public int ID { get; set; }

        public string Model { get; set; }

        public int HP { get; set; }

        public DateTime ProductionData { get; set; }
    }
}
