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
            
           
            schoolDb.Students.Add(AddStudentToDb());
            schoolDb.SaveChanges();
            
        }
        public static Student AddStudentToDb()
        {
            return new Student()
            {
                Name = "Stamat",
                Age = 26,
            };
        }
        //public static Teacher AddTeacherToDb()
        //{
           
        //}
    }
}
