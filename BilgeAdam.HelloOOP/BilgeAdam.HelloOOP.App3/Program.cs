using System;

namespace BilgeAdam.HelloOOP.App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pd;
            Employee ed;
            var p1 = new Person { FullName = "Can Perk", Age = 23 };
            var p2 = new Person { FullName = "Turan Perk", Age = 21 };
            var e1 = new Employee { FullName = "Alp Perk", Age = 33 };
            var e2 = new Employee { FullName = "Mevlüt Perk", Age = 33 };

            pd = p1;
            ed = e1;


            p1.FullName = p2.FullName;
            p1.Age = 40;

            pd.FullName = "Remzi Yılmaz";
            pd.Age = 55;

            e1.FullName = "İbrahim Kaya";
            e1.Age = 18;

            Console.WriteLine($"{p1.FullName}, {p1.Age}");
            Console.WriteLine($"{pd.FullName}, {pd.Age}");
            Console.WriteLine("==============================================");
            Console.WriteLine($"{e1.FullName}, {e1.Age}");
            Console.WriteLine($"{ed.FullName}, {ed.Age}");

            Console.ReadLine();
        }
    }

    class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }

    struct Employee
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
