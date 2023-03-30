using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public enum NamesOfSignsRectangle : byte
    {
       
        s1_4_1,
        s1_4_2,
        s5_1,
        s5_2,
        s6_1,
        s7_1_1,

    }
    internal class RoadShieldRectangle : RoadShield
    {
        public RoadShieldRectangle(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size,  isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            
            return heightShield * width;
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.rectangle;
        }
    }
}
