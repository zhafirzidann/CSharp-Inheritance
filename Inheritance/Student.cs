using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    public class Student : Person
    {
        public Student(string Name, int Age, string StudentId, string Email) : base(Name, Age)
        {
            studentid = StudentId;
            email = Email;
        }

        public string studentid { get; set; }
        public string email { get; set; }
    }
}