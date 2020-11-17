using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First name pls?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Second name pls.");
            string lastName = Console.ReadLine();

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;

            Helper.ShowStudents(student);
        }
    }
}
