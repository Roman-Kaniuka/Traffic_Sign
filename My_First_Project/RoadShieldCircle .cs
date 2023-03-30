using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    
    public enum NamesOfSignsCircle : byte
    {       
        s2_5,
        s3_1,
        s3_2,
        s4_1,
        s4_2,
    }
    internal class RoadShieldCircle : RoadShield
    {
        public RoadShieldCircle(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size, isTheHeightTakenIntoAccount)
        {
            
        }

        protected override double GetAreaCalculation(double heightShield)
        {
            return (Math.PI * Math.Pow(heightShield, 2)* 1/ 4);
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.circle;
        }
    }
}
