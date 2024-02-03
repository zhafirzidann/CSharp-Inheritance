using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    public class Person
    {
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        //properties
        public string name { get; set; }
        public int age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("Mahasiswa ini bernama : {0} berusia : {1}", name, age);
        }
    }
}