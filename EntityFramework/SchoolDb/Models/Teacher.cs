using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb.Models
{
   public class Teacher
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }
    }
}
