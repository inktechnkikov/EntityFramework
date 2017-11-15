using SchoolDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb
{
    class SchoolDbDemo
    {
        static void Main(string[] args)
        {
            SchoolDbContext schoolDb = new SchoolDbContext();

           // schoolDb.Students.Add(AddStudentToDb());
            GetAllStudents(schoolDb);
            schoolDb.SaveChanges();
            
        }
        public static Student AddStudentToDb()
        {
            return new Student()
            {
                Name = "Unufri",
                Age = 27,
            };
        }
        public static void GetAllStudents(SchoolDbContext studentContext)
        {
            foreach (var student in studentContext.Students)
            {
                Console.WriteLine($"Student Name --> {student.Name} \nAge --> {student.Age}");
            }
        }
    }
}
