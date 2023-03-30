using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class SwitchClass : RoadShield
    {
         SwitchClass (NamesOfSignsCircle name_shield, StandardSize size)
        {

        }
        SwitchClass(NamesOfSignsOctagon name_shield)
        {

        }
        SwitchClass(NamesOfSignsRectangl name_shield)
        {

        }
        SwitchClass(NamesOfSignsSquare name_shield)
        {

        }
        SwitchClass(NamesOfSignsTriangle name_shield)
        {

        }

        //ReadsData(name_shield);



        public void SwitchMethod()
        {
           

        }

        protected override double GetAreaCalculation(double heightShield)
        {
            throw new NotImplementedException();
        }

        protected override FormOfShield GetFormOfShield()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
