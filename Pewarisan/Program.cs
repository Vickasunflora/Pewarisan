using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Vicka";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Kamarudin";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Pemrogramman";
            teacher.GetNameAndAge();

            Students students = new Students();
            students.Name = "Rizky";
            students.Age = 19;
            students.StudentId = "10506";
            students.Email = "vsunflora@gmail.com";
            students.GetNameAndAge();

            Console.ReadKey();


        }
    }
}
