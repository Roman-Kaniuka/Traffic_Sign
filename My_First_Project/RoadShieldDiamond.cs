using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
   public enum NamesOfSignsDiamond : byte
    {
        s2_3,
        s2_4,

    }
    internal class RoadShieldDiamond : RoadShield
    {
        public RoadShieldDiamond(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size, isTheHeightTakenIntoAccount)
        {

        }
        protected override double GetAreaCalculation(double heightShield)
        {
            return Math.Pow(heightShield, 2)/2;
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.square;
        }
    }
}
