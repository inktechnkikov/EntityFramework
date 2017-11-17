using ConsoleApp1;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkOneToMany
{
    class Demo
    {
        static void Main(string[] args)
        {
            WorldContext context = new WorldContext();
            context.Students.Add(AddNewStudentToDB());
            AddStudentToSchool(context);
            context.SaveChanges();
        }

        private static void AddStudentToSchool(WorldContext context)
        {
            IEnumerable<Student> student = context.Students;
            context.School.Add(new School()
            {
                Name = "PG KAspichan",
            });
            foreach (Student student1 in student)
            {
                context.School.First().Students.Add(student1);

            }
        }

        public static Student AddNewStudentToDB()
        {
            return new Student()
            {
                Name = "Manteko",
                StudentAddress = new StudentAddress()
                {
                    Address = "koprivshtica",
                }
            };
        }
       
    }
}
