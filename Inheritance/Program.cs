using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Zidan", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jaystka", 20, "21.11.3952", "Komdat");
            teacher.GetNameAndAge();

            Student student = new Student("Alif", 22, "21.11.3935", "alif@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}