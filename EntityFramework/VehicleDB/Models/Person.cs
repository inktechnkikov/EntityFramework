﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDB.Models
{
  public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Tesla TeslaCar { get; set; }
    }
}
