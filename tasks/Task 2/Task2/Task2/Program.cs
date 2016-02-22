using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            var cars = new[]
            {
                new car("VW", 35, 8, 0),
                new car("Opel", 10, 10, 0)
            };


            foreach (var c in cars)
            {
                Console.WriteLine("Brand: {0} Current Fuel: {1} Liters Consumption: {2} Liters/100km Distance: {3}", c.Brand, c.Fuel, c.Consumption, c.Distance);
            }

            Console.WriteLine();
            Console.WriteLine("Distance after doubling the fuel");
            Console.WriteLine();

            foreach (var c in cars)
            {
                c.Fuel = c.DoubleFuel(c.Fuel);
                c.Distance = c.GetDistance(c.Fuel, c.Consumption);
               
                Console.WriteLine("Brand: {0} Current Fuel: {1} Liters Consumption: {2} Liters/100km Distance: {3}", c.Brand, c.Fuel, c.Consumption, c.Distance);
            }
            
        }
    }
}
