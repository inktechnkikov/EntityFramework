using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   public class Student
    {
        [ForeignKey("StudentAddress")]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }

        public virtual School School { get; set; }
    }
}
