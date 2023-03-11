using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace My_First_Project
{
      internal class _RoadShield // not relevant. DELETE
    {
        //public _RoadShield(NamesOfSigns name, StandardSize size, GroupsOfSigns group, bool isTheHeightTakenIntoAccount)
        //{
        //    this.name = name;
        //    this.size = size;
        //    this.group = group;
        //    this.isTheHeightTakenIntoAccount = isTheHeightTakenIntoAccount;
        //    WeightСalculation(name, size);
        //}

        //protected GroupsOfSigns group;
        //protected NamesOfSigns name;
        //protected StandardSize size;
        //protected FormOfShield form;
        //protected double height;
        //protected double width;
        //protected double weight;
        //protected bool isTheHeightTakenIntoAccount;

        //private void Print()
        //{
        //    Console.WriteLine(new string('_', 50));
        //    Console.WriteLine($"назва щитка - {name.ToString().Replace('s', ' ').Replace('_', '.').Trim()}");
        //    Console.WriteLine($"типорозмiр - {size}");
        //    Console.WriteLine($"висота  - {height}");
        //    Console.WriteLine($"вага  - {weight}");
        //    Console.WriteLine($"висота впливає на розмiр стiки  - {isTheHeightTakenIntoAccount}");
        //    Console.WriteLine(new string('_', 50));
        //}

        //public NamesOfSigns Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public StandardSize Size
        //{
        //    get { return size; }
        //    set { size = value; }
        //}
        //public GroupsOfSigns Group
        //{
        //    get { return group; }
        //    set { group = value; }
        //}

        //public void WeightСalculation(NamesOfSigns name, StandardSize size)
        //{
        //    IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        //    const double oneWeightOfOneSquareMeter = 14.88;


        //    var a = ToTest(@"D:\myProjeck\Test.txt", name, size);

        //    height = Convert.ToDouble(a.Min(x => x.height), formatter);

        //    if (a.Min(x => x.octagon) != "-")
        //    {
        //        form = FormOfShield.octagon;
        //        double shieldAreaFormula = (Math.Pow((height) / 2, 2) * 8) / 100 * (Math.Sqrt(2) - 1);
        //        weight = Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);
        //    }

        //    else if (a.Min(x => x.circle) != "-")
        //    {
        //        form = FormOfShield.circle;
        //        double shieldAreaFormula = (Math.PI * Math.Pow(height, 2) / 100) / 4;
        //        weight = Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);
        //    }

        //    else if (a.Min(x => x.square) != "-")
        //    {
        //        form = FormOfShield.square;
        //        double shieldAreaFormula = Math.Pow(height, 2);
        //        weight = Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);                
        //    }

        //    else if (a.Min(x => x.rectangle_height) != "-")
        //    {
        //        form = FormOfShield.rectangle;
        //        double shieldAreaFormula = height * (Convert.ToDouble(a.Min(x => x.rectangle_width), formatter)) / 1000; ;
        //        weight = Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);               
        //    }
        //    else if (a.Min(x => x.triangle) != "-")
        //    {
        //        form = FormOfShield.triangle;
        //        double shieldAreaFormula = Math.Pow(((Convert.ToDouble(a.Min(x => x.triangle), formatter)) / 1000), 2) * (Math.Sqrt(3) / 4);
        //        weight = Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);               
        //    }
        //    Print();
        //}
        //public static List<Shield> ToTest(string LinkToTest, NamesOfSigns name, StandardSize size)
        //{
        //    var Name = name.ToString().Replace('s', ' ').Replace('_', '.').Trim();
        //    var Size = size.ToString();

        //    var list = File.ReadAllLines(LinkToTest);
        //    var a = list.Skip(1);
        //    var b = a.Select(x => Shield.Parse(x));
        //    var c = b.Where(Signs => Signs.name == Name);
        //    var d = c.Where(Signs => Signs.size == Size);
        //    var e = d.ToList();
        //    return e;
        //}

    }
}
