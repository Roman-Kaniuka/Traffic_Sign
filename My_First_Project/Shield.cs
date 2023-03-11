using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    internal class Shield
    {
        internal string name { get; set; }
        internal string size { get; set; }
        internal string height { get; set; }
        internal string concatenation { get; set; }
        internal string triangle { get; set; }
        internal string octagon { get; set; }
        internal string circle { get; set; }
        internal string square { get; set; }
        internal string rectangle_height { get; set; }
        internal string rectangle_width { get; set; }

        public override string ToString()
        {
            return name + size;
        }

        public static Shield Parse(string line)
        {
            string[] parts = line.Split(" | ");
            return new Shield()
            {
                name = parts[0],
                size = parts[1],
                height = parts[2],
                triangle = parts[3],
                octagon = parts[4],
                circle = parts[5],
                square = parts[6],
                rectangle_height = parts[7],
                rectangle_width = parts[8],
            };
        }
    }
}
