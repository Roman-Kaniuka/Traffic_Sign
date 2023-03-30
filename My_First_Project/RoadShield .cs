using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Xml.Linq;

namespace My_First_Project
{
    abstract internal class RoadShield
    {
        public RoadShield()
        {

        }

        public RoadShield(object name, StandardSize size, bool isTheHeightTakenIntoAccount)
        {
            this.name = name;
            this.size = size;
           
            this.isTheHeightTakenIntoAccount = isTheHeightTakenIntoAccount;
            GetsParameters(name, size);
        }
        protected object name;
        protected string group;
        protected StandardSize size;
        protected FormOfShield form;
        protected double heightShield;
        protected double width;
        protected double weightShield;
        protected bool isTheHeightTakenIntoAccount;
        const double oneWeightOfOneSquareMeter = 14.88; //kg
        protected IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        public object Name
        {
            get { return name; }
            //set { name = value; }
        }
        public StandardSize Size
        {
            get { return size; }
            //set { size = value; }
        }
        public object Group
        {
            get { return group; }
            //set { group = value; }
        }
        public bool IsTheHeightTakenIntoAccount
        {
            get { return isTheHeightTakenIntoAccount; }

        }
        public double HeightShield
        {
            get { return heightShield; }

        }
        public void Print(List<db_Shields> shields)
        {
            foreach (var u in shields)
            {
                //Console.WriteLine($"{u.Id}\t{u.name_shield}\t {u.Size_.name_size}\t{u.Group_.name_group}\t{u.Figure_.name_figure}  \t{u.height}\t{u.width}");
                //Console.WriteLine($"{u.Id}\t{u.name_shield}\t {u.size_id}\t{u.group_id}\t{u.figure_id}  \t{u.height}\t{u.width}");
                Console.WriteLine($"id - {u.Id}");                
                Console.WriteLine($"назва щитка - {name}");
                Console.WriteLine($"знак групи - \"{group}\"");
                Console.WriteLine($"типорозмiр щитка - {size}");                
                Console.WriteLine($"форма житка - {form}");
                Console.WriteLine($"висота - {heightShield}");
                Console.WriteLine($"ширина - {width}");
                Console.WriteLine($"вага - {weightShield}");
                Console.WriteLine($"враховується висота щитка? - {isTheHeightTakenIntoAccount}");
                Console.WriteLine();
            }

            /* 
             * Console.WriteLine($"назва щитка - {u.name_shield}");
             * Console.WriteLine($"група знаку - {u.Group_.name_group}");
             * Console.WriteLine($"типорозмiр щитка - {u.Size_.name_size}");
             * Console.WriteLine($"форма житка - {u.Figure_.name_figure}");
             * Console.WriteLine($"висота - {u.height}");
             * Console.WriteLine($"ширина - {u.width}");                
             */
            Console.WriteLine(name);
            Console.WriteLine(group);
            Console.WriteLine(size);
            Console.WriteLine(form);
            Console.WriteLine(heightShield);
            Console.WriteLine(width);
            Console.WriteLine(weightShield);
            Console.WriteLine(isTheHeightTakenIntoAccount);


        }
        protected void GetsParameters(object name, StandardSize size)//--------------------0*
        {
            form = GetFormOfShield();

            string[] a = ConvertsToString(name, size);

            List<db_Shields> Shield_table = ReadsData(a[0], a[1]);

            var u = Shield_table[0];
            
                heightShield =(double)u.height/1000;
                width = (double)u.width/1000;
                weightShield = GetWeight(GetAreaCalculation(heightShield));
                this.name = u.name_shield;
                group = u.Group_.name_group;

            Print(Shield_table);


        }


        abstract protected double GetAreaCalculation(double heightShield);
        abstract protected FormOfShield GetFormOfShield();
        
        protected double GetWeight(double shieldAreaFormula)
        {
            return Math.Round((shieldAreaFormula * oneWeightOfOneSquareMeter), 2);
        }
        
        public static string[] ConvertsToString(object name, StandardSize size) //-----------------3
        {
            var Name = name.ToString().Replace('s', ' ').Replace('_', '.').Trim();
            var Size = size.ToString();

            string[]add= {Name, Size};           
            return add;
        }

         protected List<db_Shields> ReadsData (string name, string size) 
        {
            using var dbContext = new ApplicationContext();

            var Shield_table = dbContext
                .Set<db_Shields>()
                .Include(x => x.Size_)
                .Include(x => x.Figure_)
                .Include(x => x.Group_)
                .Where(x => x.name_shield == name)
                .Where(x => x.Size_.name_size == size)
                .ToList();
            return Shield_table;

            // ВАРІАНТ 2 АЛЕ ПРАЦЮЄ ТІЛЬКИ З SIZE 

            /*
            using (ApplicationContext db = new ApplicationContext())
            {

                //using var dbContext = new ApplicationDbContext();

                var joinedCoursesQueryable = db
                    .shield
                    .Join(
                        // зєднуємо щиткі та типорозміри
                        db.size,
                        // ключ из модели курсов
                        x => x.size_id,
                        // ключ из модели авторов
                        x => x.Id,
                        // создаём новый объект результат
                        (shield, size) => new { Shield = shield, Size = size });

                var joinedCourses = joinedCoursesQueryable.ToList();

                Console.WriteLine("Список об'єктів:");
                foreach (var u in joinedCourses)
                    Console.WriteLine($"{u.Shield.Id}\t{u.Shield.name_shield}\t {u.Size.name_size}\t{u.Shield.size_id}\t{u.Shield.figure_id}\t{u.Shield.height}\t{u.Shield.width}");
            
            }
            */

        }


    }
}
