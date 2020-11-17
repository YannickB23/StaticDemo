using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class Helper
    {
        public static void ShowStudents(Student student)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
        }
    }
}
