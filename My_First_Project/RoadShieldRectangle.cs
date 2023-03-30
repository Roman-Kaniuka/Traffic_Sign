using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    enum NamesOfSignsRectangl : byte
    {
       
        s1_4_1,
        s1_4_2,
        
    }
    internal class RoadShieldRectangle : RoadShield
    {
        public RoadShieldRectangle(object name, StandardSize size, GroupsOfSigns group, bool isTheHeightTakenIntoAccount) : base(name, size, group, isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            
            return heightShield * width / 1000;
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.rectangle;
        }
    }
}
