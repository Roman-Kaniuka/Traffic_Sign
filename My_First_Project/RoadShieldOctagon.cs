using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    enum NamesOfSignsOctagon : byte
    {        
        s2_2,
    }
    internal class RoadShieldOctagon : RoadShield
    {
        public RoadShieldOctagon(object name, StandardSize size, GroupsOfSigns group, bool isTheHeightTakenIntoAccount) : base(name, size, group, isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            return (Math.Pow((heightShield) / 2, 2) * 8) / 100 * (Math.Sqrt(2) - 1);
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.octagon;
        }
    }
}
