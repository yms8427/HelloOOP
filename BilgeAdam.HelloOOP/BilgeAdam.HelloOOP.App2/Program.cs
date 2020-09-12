using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.HelloOOP.App2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                FirstName = "Can",
                LastName = "Perk",
                BirthDate = new DateTime(2004, 2, 8)
            };

            var s2 = new ExtendedStudent
            {
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                BirthDate = new DateTime(2004, 2, 8)
            };
            Console.WriteLine($"{s1.FullName}, {s1.Age}");
            Console.WriteLine($"{s2.FullName}, {s2.Age}");
            Console.ReadLine();
        }
    }
}
