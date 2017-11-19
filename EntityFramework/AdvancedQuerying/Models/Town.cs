using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQuerying.Models
{
   public class Town
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
