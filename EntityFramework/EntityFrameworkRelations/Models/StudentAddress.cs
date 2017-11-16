using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkRelations.Models
{
   public class StudentAddress
    {   
        public int ID { get; set; }

        public string Address { get; set; }

        public Student Student { get; set; }
    }
}
