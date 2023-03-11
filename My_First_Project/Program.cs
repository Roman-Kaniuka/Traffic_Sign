namespace My_First_Project
{
    

    internal class Program
    {
       
        static void Main(string[] args)
        {
            

            RoadSign roadSign = new RoadSign();
            roadSign.GetWindyArea();
            //roadSign.Print();

            RoadShield roadShield = new RoadShieldSquare(NamesOfSignsOctagon.s2_2, StandardSize.I, GroupsOfSigns.попереджувальні, true);
            roadShield.Print(); 

        }
    }
}