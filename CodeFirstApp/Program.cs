using System;
using System.Collections.Generic;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
           using (var ctx = new SchoolContext())
            {
                var student = new Student
                {
                    Id = 1,
                    FirstName = "Joe",
                    LastName = "Smith",
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
                foreach(var aStudent in ctx.Students)
                {
                    Console.WriteLine($"Student {aStudent.FirstName} {aStudent.LastName} Id is {aStudent.Id}.");
                }
               
                Console.ReadLine();
            } 
        }
    }
}
