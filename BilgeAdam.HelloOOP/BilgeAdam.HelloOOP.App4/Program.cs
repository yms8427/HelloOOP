using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.HelloOOP.App4
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vehicle("Mercedes", "CLA 200");
            var v2 = new Vehicle("BMW", "5.25");

            Vehicle.DefaultCC = 1600;

            var v3 = new Vehicle("Honda", "Civic");
            var v4 = new Vehicle("Toyota", "Corolla");

            Vehicle.DefaultCC = 1800;

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            var b = Vehicle.GetModel(v1);

            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            CC = DefaultCC;
        }
        public int CC { get; set; }
        public static string Brand { get; set; }
        public string Model { get; set; }

        public static int DefaultCC { get; set; } = 2000;

        public static string GetModel(Vehicle vehicle)
        {
            return vehicle.Model.ToUpper();
        }

        public override string ToString()
        {
            return $"{Brand} {Model} - {CC}cc";
        }
    }
}
