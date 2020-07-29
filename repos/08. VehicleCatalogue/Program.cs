using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();
            while (input != "end")
            {
                List<string> inputProp = input.Split('/').ToList();
                if (inputProp[0] == "Car")
                {
                    Car newCar = new Car(inputProp[1], inputProp[2], inputProp[3]);
                    allCars.Add(newCar);
                }
                else if(inputProp[0]=="Truck")
                {
                    Truck newTruck = new Truck(inputProp[1], inputProp[2], inputProp[3]);
                    allTrucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }
            allCars = allCars.OrderBy(o => o.Brand).ToList();
            allTrucks = allTrucks.OrderBy(p => p.Brand).ToList();
            if (allCars.Count>0)
            {
                Console.WriteLine("Cars: ");
                for (int i = 0; i < allCars.Count; i++)
                {
                    Car current = allCars[i];
                    Console.WriteLine($"{current.Brand}: {current.Model} - {current.HorsePower}hp");
                }
            }
            if (allTrucks.Count>0)
            {
                Console.WriteLine("Trucks: ");
                for (int i = 0; i < allTrucks.Count; i++)
                {
                    Truck current = allTrucks[i];
                    Console.WriteLine($"{current.Brand}: {current.Model} - {current.Weight}kg");
                }
            }
            
        }
    }
    public class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;

        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

    }
    
}
