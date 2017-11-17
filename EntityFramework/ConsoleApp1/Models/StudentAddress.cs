using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   public class StudentAddress
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public virtual Student Student { get; set; }
    }
}
