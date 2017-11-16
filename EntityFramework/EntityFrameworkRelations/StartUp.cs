using EntityFrameworkRelations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkRelations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            WorldContext context = new WorldContext();
            context.Student.Add(AddNewStudentToDb());
            context.SaveChanges();
        }
        public static Student AddNewStudentToDb()
        {
            return new Student
            {
                Name = "Ilia",
                StudentAddress = new StudentAddress()
                {
                    Address = "Plovdiv",
                }
            };
          
        }
    }
}
