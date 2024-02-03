using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    public class Teacher : Person
    {
        public Teacher(string Name, int Age, string Id, string Subject) : base(Name, Age)
        {
            id = Id;
            subject = Subject;
        }

        //properties
        public string id { get; set; }
        public string subject { get; set; }
    }
}