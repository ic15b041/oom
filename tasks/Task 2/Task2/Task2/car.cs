using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class car
    {

        public car(string brand, decimal fuel, decimal consumption, decimal distance)
        {
            if (string.IsNullOrWhiteSpace(brand)) throw new ArgumentException("Brand must be set!");
            if (fuel <= 0) throw new ArgumentException("Fuel must be greater than 0!");
            if (consumption <= 0) throw new ArgumentException("Consumption must be greater than 0!");
            distance = GetDistance(fuel, consumption);

            Brand = brand;
            Fuel = fuel;
            Consumption = consumption;
            Distance = distance;
        }

        public string Brand { get; }
        public decimal Fuel { get; set; }
        public decimal Consumption { get; }
        public decimal Distance { get; set; }        

        public decimal GetDistance(decimal fuel, decimal consumption)
        {
            return (fuel / consumption)*100;
        }

        public decimal DoubleFuel(decimal fuel)
        {
            return (fuel * 2);
        }
    }
}
