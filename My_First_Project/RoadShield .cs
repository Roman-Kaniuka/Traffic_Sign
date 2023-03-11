using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace My_First_Project
{
    abstract internal class RoadShield
    {
        public RoadShield(object name, StandardSize size, GroupsOfSigns group, bool isTheHeightTakenIntoAccount)
        {
            this.name = name;
            this.size = size;
            this.group = group;
            this.isTheHeightTakenIntoAccount = isTheHeightTakenIntoAccount;
            WeightСalculation(name, size);
        }
        protected object name;
        protected GroupsOfSigns group;        
        protected StandardSize size;
        protected FormOfShield form;
        protected double heightShield;
        protected double width;
        protected double weightShield;
        protected bool isTheHeightTakenIntoAccount;
        const double oneWeightOfOneSquareMeter = 14.88; //kg
        protected IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

         public  object Name
        {
            get { return name; }
            set { name = value; }
        }
        public StandardSize Size
        {
            get { return size; }
            set { size = value; }
        }
        public GroupsOfSigns Group
        {
            get { return group; }
            set { group = value; }
        }
        public bool IsTheHeightTakenIntoAccount
        {
            get { return isTheHeightTakenIntoAccount; }
            
        }
        public double HeightShield
        {
            get { return heightShield; }

        }
        public void Print()
        {
            Console.WriteLine(new string('_', 50));
            Console.WriteLine($"назва щитка - {name.ToString().Replace('s', ' ').Replace('_', '.').Trim()}");
            Console.WriteLine($"типорозмiр - {size}");
            Console.WriteLine($"висота  - {heightShield}");
            Console.WriteLine($"вага  - {weightShield}");
            Console.WriteLine($"висота впливає на розмiр стiки  - {isTheHeightTakenIntoAccount}");
            Console.WriteLine($"тип форми  - {form}");
            Console.WriteLine(new string('_', 50));
        }

       
        abstract protected double GetAreaCalculation(double heightShield);
        abstract protected FormOfShield GetFormOfShield();
        protected List<Shield> GetTheConnectionString (object name, StandardSize size)
        {
            
            return GetShieldParameter(@"D:\myProjeck\Traffic_Sign\Test.txt", name, size);
        }
        protected double GetWeight(double shieldAreaFormula)
        {
            return Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2); 
        }
        public void WeightСalculation(object name, StandardSize size)
        {
            
            var a = GetTheConnectionString( name, size);

            heightShield = Convert.ToDouble(a.Min(x => x.height), formatter)/10;

                form = GetFormOfShield();
                double shieldArea = GetAreaCalculation(heightShield);
                weightShield = GetWeight(shieldArea);
        }
        public static List<Shield> GetShieldParameter(string LinkToTest, object name, StandardSize size)
        {
            var Name = name.ToString().Replace('s', ' ').Replace('_', '.').Trim();
            var Size = size.ToString();

            var list = File.ReadAllLines(LinkToTest);
            var a = list.Skip(1);
            var b = a.Select(x => Shield.Parse(x));
            var c = b.Where(Signs => Signs.name == Name);
            var d = c.Where(Signs => Signs.size == Size);
            var e = d.ToList();
            return e;
        }

    }
}
