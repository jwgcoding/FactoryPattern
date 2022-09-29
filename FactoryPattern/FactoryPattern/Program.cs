// See https://aka.ms/new-console-template for more information
using System;
using FactoryPattern;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = true;
            do
            {
                Console.WriteLine("Hi there, We have a limited amount of vehicles that we can make.");
                Console.WriteLine("We make vehicles from the amount of numbers of wheels our customer requests");
                Console.WriteLine("Choose from our list of wheels: 2, 4, 18, 22");
                Console.WriteLine("If you do not choose, your default will be 4.");
                input = int.TryParse(Console.ReadLine(), out numOfWheels);
            }while (input == false);
            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
        }
    }
}
