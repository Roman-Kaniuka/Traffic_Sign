using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
   public enum NamesOfSignsOctagon : byte
    {        
        s2_2,
    }
    internal class RoadShieldOctagon : RoadShield
    {
        public RoadShieldOctagon(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size, isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            return (Math.Pow((heightShield) / 2, 2) * 8)  * (Math.Sqrt(2) - 1);
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.octagon;
        }
    }
}
