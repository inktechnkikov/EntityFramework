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
            Student student = new Student()
            {
                Name = "Gosho",
                Age = 24,

            };
            schoolDb.Students.Add(student);
        }
    }
}
