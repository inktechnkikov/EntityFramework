using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkRelations.Models
{
   public class Student
    {

        [ForeignKey("StudentAddress")]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
    }
}
