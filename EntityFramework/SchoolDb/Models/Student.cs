using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb.Models
{
   public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0,120)]
        public int Age { get; set; }
        public Teacher Teacher { get; set; }
    }
}
