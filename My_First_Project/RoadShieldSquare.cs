﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public enum NamesOfSignsSquare : byte
    {
       
        s2_6,
       
    }
    internal class RoadShieldSquare : RoadShield
    {
        public RoadShieldSquare(object name, StandardSize size, bool isTheHeightTakenIntoAccount) : base(name, size,  isTheHeightTakenIntoAccount)
        {
            
        }
        protected override double GetAreaCalculation(double heightShield)
        {
            return Math.Pow(heightShield, 2);
        }

        protected override FormOfShield GetFormOfShield()
        {
            return FormOfShield.square;
        }
    }
}
