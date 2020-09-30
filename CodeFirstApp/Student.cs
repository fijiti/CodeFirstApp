using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApp
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Grade Grade { get; set; }
    }
}
