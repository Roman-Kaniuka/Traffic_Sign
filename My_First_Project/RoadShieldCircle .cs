using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    
    enum NamesOfSignsCircle : byte
    {       
        s2_5,
    }
    internal class RoadShieldCircle : RoadShield
    {
        public RoadShieldCircle(object name, StandardSize size, GroupsOfSigns group, bool isTheHeightTakenIntoAccount) : base(name, size, group, isTheHeightTakenIntoAccount)
        {
            
        }

        protected override double GetAreaCalculation(double heightShield)
        {
            return (Math.PI * Math.Pow(heightShield, 2) / 100) / 4;
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.circle;
        }
    }
}
