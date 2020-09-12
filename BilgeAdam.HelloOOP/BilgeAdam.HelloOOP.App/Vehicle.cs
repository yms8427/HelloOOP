using System;

namespace BilgeAdam.HelloOOP.App
{
    class Vehicle
    {
        private readonly string brand;
        private int km;
        private bool isStarted;

        public Vehicle(string brand)
        {
            this.brand = brand;
        }

        public Vehicle(string brand, int km)
        {
            this.brand = brand;
            this.km = km;
        }

        public int GetKm()
        {
            return km;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void Start()
        {
            isStarted = true;
        }

        public void Go(int distance)
        {
            if (distance < 0)
            {
                throw new Exception("Distance should be more than zero '{0}'");
            }
            if (!isStarted)
            {
                throw new Exception("Vehicle should be launched");
            }
            km += distance;
        }
    }
}
