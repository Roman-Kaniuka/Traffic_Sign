using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
   public enum NamesOfSignsTriangle : byte
    {
        s1_1,
        s1_2,
        
    }
    internal class RoadShieldTriangle : RoadShield
    {
        public RoadShieldTriangle(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size,  isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            
            return (Math.Pow(heightShield, 2) * (Math.Sqrt(3)) / 4);
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.triangle;
        }
    }
}
