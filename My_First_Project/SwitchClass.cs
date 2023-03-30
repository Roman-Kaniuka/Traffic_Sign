using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    public class SwitchClass
    {
        public SwitchClass(NamesOfSignsCircle name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldCircle(name_shield, size, true);
        }

        public SwitchClass(NamesOfSignsOctagon name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldOctagon(name_shield, size, true);
        }

        public SwitchClass(NamesOfSignsRectangle name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldRectangle(name_shield, size, true);
        }

        public SwitchClass(NamesOfSignsSquare name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldSquare(name_shield, size, true);
        }

        public SwitchClass(NamesOfSignsTriangle name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldTriangle(name_shield, size, true);
        }
        public SwitchClass(NamesOfSignsDiamond name_shield, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            RoadShield roadShield = new RoadShieldDiamond(name_shield, size, true);
        }

        //ReadsData(name_shield);







    }

}
