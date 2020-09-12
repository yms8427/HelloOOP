using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.HelloOOP.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Vehicle("BMW", 12000);
            var mrc = new Vehicle("Mercedes Benz");
            //var honda = new Vehicle(); => Çalışabilmesi için default, parametresiz constructor olmalı

            mrc.Start();
            mrc.Go(5);

            bmw.Start();
            bmw.Go(100);

            Console.WriteLine($"{bmw.GetBrand()} KM .............: {bmw.GetKm()}");
            Console.WriteLine($"{mrc.GetBrand()} KM ........: {mrc.GetKm()}");

            Console.ReadKey();
        }
    }
}
