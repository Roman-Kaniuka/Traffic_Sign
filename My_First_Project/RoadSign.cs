using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    internal class RoadSign
    {
        protected Stand marking; //розрахунок
        protected int numberOfPieces = 1;//можливо окрема таблиця зі знаками які потребують 2 стійки
        public WindyArea windyArea;  // можливо через статичний конструктор можна задати для всіх але якщо зміни?? 
        public string PK; 
        public string leftOrRight;  
        protected List<RoadShield> roadsShields;  
        protected double totalHeight;
        public double heightAboveTheGround;  
        public double heightBelowTheGround;  
        protected double heightOfAllSigns; 
        public bool roadCurb = false;
        public bool onTheRack;
        const double distanceBetweenShields = 0.25;  //centimeters 
        const double borderHeight = 0.15;           //centimeters

        public void Print()
        {
            Console.WriteLine($"Маркування стiйок: {marking}");
            Console.WriteLine($"Кiлькiсть стiйок: {numberOfPieces}шт");
            Console.WriteLine($"Вiтровий район: {windyArea}");
            Console.WriteLine($"ПК: {PK}");
            Console.WriteLine($"Розмiщення по ходу руху ПК: {leftOrRight}");
            Console.WriteLine($"Сумарна висота стiйки та шиткiв: {totalHeight}m");
            Console.WriteLine($"Висота стiйки над землею: {heightAboveTheGround}m");
            Console.WriteLine($"Глибина заглиблення стiйки в грунт: {heightBelowTheGround}m");
            Console.WriteLine($"Сума висоти всiх щиткiв: {heightOfAllSigns}m");
            Console.WriteLine($"Чи є  бортовий камiнь: {roadCurb}");
            Console.WriteLine($"Знак розмiщенно на стiйцi:{onTheRack}");

            
            //foreach (RoadShield sh in roadsShields)            
            //    sh.Print();
            
        }

        public void GetWindyArea()
        {
            Console.WriteLine("Введiть вiтровий район \n 1\n 2\n 3\n 4\n 5");

            var a = Convert.ToInt32(Console.ReadLine());
            windyArea = (WindyArea)a;
            Console.Clear();
            GetPK();
        }
        private void GetPK()
        {
            Console.WriteLine("Введiть ПК знаку у форматi __+__");
            PK = Console.ReadLine(); // потрібно додати кучу перевірок і можливість вводити пікети або кілометри
            Console.Clear();
            GetLeftOrRight();
        }

        private void GetLeftOrRight()
        {
            Console.WriteLine("Розмiщення знака по ходу руху пiкетажа (Лiворуч = 1 чи Праворуч = 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                leftOrRight = "Лiворуч";
            else
                leftOrRight = "Праворуч";
            Console.Clear();
            GetOnTheRack();
        }
        private void GetOnTheRack()
        {
            Console.WriteLine("Встановлення знаку на СКМ. опорi? \n Так = 1\n Нi = 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                onTheRack = true;
                Console.Clear();
                GetHeightBelowTheGround();
            }
                
            else
            {
                onTheRack = false;
                Console.Clear();
                heightBelowTheGround = 0;
                heightAboveTheGround = 0;
            }
        }
        private void GetHeightBelowTheGround()
        {
            Console.WriteLine("Глибина закопування знаку \n 1,2m = 1\n 1,5m = 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                heightBelowTheGround = 1.2;
            else
                heightBelowTheGround = 1.5;

            Console.Clear();
            GetHeightAboveTheGround();
        }
        private void GetHeightAboveTheGround()
        {
            Console.WriteLine("Висота знаку над землею \n 1.5m поза мiстом = 1\n 2.0m в мiстi= 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                heightAboveTheGround = 1.5;
            else
                heightAboveTheGround = 2;
            Console.Clear();
            GetRoadCurb();
        }
        private void GetRoadCurb()
        {
            Console.WriteLine("Наявнiсть бордюра \n Так = 1\n Нi = 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                roadCurb = true;
            Console.Clear();
            AddRoadsShields();
        }
        
        private void GetTotalHeight() 
        {
            totalHeight += heightAboveTheGround + heightBelowTheGround + heightOfAllSigns;
            if (roadCurb)
                totalHeight += borderHeight;
        }

        public void AddRoadsShields()
        {
            List<RoadShield> RoadsShields = new List<RoadShield>();
            

            RoadShield roadShield = new RoadShieldOctagon(NamesOfSignsOctagon.s2_2, StandardSize.I, false);
            RoadsShields.Add(roadShield);

            RoadShield roadShield1 = new RoadShieldCircle(NamesOfSignsCircle.s2_5, StandardSize.I, true);
            RoadsShields.Add(roadShield1);

            roadsShields = RoadsShields;
            GetHeightOfAllSigns();
        }
        private void GetHeightOfAllSigns()
        {
            int count = 0;
            foreach (RoadShield a in roadsShields)
            {
                if (a.IsTheHeightTakenIntoAccount)
                {
                    count++;
                    heightOfAllSigns += a.HeightShield;
                }
                if (count > 1)
                {
                    heightOfAllSigns += (count - 1) * distanceBetweenShields;
                    heightOfAllSigns = Math.Round(heightOfAllSigns, 2);
                }
            }
            GetTotalHeight();
        }
    }
    
}
