using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3.NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carToAdd = Console.ReadLine().Split('|').ToArray();
                cars.Add(carToAdd[0], new int[2] { int.Parse(carToAdd[1]), int.Parse(carToAdd[2]) });
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] carActions = command.Split(" : ").ToArray();
                string action = carActions[0];
                if (action == "Drive")
                {
                    string car = carActions[1];
                    int distance = int.Parse(carActions[2]);
                    int fuel = int.Parse(carActions[3]);
                    Drive(cars, car, distance, fuel);
                }
                else if (action == "Refuel")
                {
                    string car = carActions[1];
                    int fuel = int.Parse(carActions[2]);
                    Refuel(cars, car, fuel);
                }
                else if (action == "Revert")
                {
                    string car = carActions[1];
                    int kilometres = int.Parse(carActions[2]);
                    Revert(cars, car, kilometres);
                }
                
                command = Console.ReadLine();
            }
            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
        static Dictionary<string, int[]> Drive(Dictionary<string, int[]> cars, string car, int distance, int fuel)
        {

            if (cars[car][1] < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                cars[car][0] += distance;
                cars[car][1] -= fuel;
                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (cars[car][0] >= 100000)
                {
                    cars.Remove(car);
                    Console.WriteLine($"Time to sell the {car}!");
                }
            }
            return cars;
        }
        static Dictionary<string, int[]> Refuel(Dictionary<string, int[]> cars, string car, int fuel)
        {
            int refueledTank = cars[car][1] + fuel;
            if (refueledTank>75)
            {
                int fuelTaken = 75 - cars[car][1];
                cars[car][1] = 75;               
                Console.WriteLine($"{car} refueled with {fuelTaken} liters");
            }
            else
            {
                cars[car][1] = refueledTank;
                Console.WriteLine($"{car} refueled with {fuel} liters");
            }
            return cars;
        }
        static Dictionary<string, int[]> Revert(Dictionary<string, int[]> cars, string car, int kilometres)
        {
            cars[car][0] -= kilometres;
            
            if (cars[car][0]<10000)
            {
                cars[car][0] = 10000;
                return cars;
            }
            Console.WriteLine($"{car} mileage decreased by {kilometres} kilometers");
            return cars;
        }
    }
}
