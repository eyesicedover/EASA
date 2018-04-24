using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EASA.Models
{
    public class Fuel
    {
        public double DryWeight { get; set; }
        public double FinalSpeed { get; set; }

        public Fuel(double weight, double speed)
        {
            DryWeight = weight;
            FinalSpeed = speed;
        }

        public double CalcFuelWeight()
        {
            var result = Math.Ceiling(DryWeight * Math.Pow(2.718, (FinalSpeed / 3)) - DryWeight);
            return result;
        }
    }
}
