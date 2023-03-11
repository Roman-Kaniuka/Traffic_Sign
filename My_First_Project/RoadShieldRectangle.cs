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
            var a = GetTheConnectionString(name, size); // temporary variable
            return heightShield * (Convert.ToDouble(a.Min(x => x.rectangle_width), formatter)) / 1000; 
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.rectangle;
        }
    }
}
