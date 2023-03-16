namespace My_First_Project
{
    

    internal class Program
    {
       
        static void Main(string[] args)
        {

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



            /*
            RoadSign roadSign = new RoadSign();
            roadSign.GetWindyArea();
            roadSign.Print();
            */

            //RoadShield roadShield = new RoadShieldSquare(NamesOfSignsOctagon.s2_2, StandardSize.I, GroupsOfSigns.попереджувальні, true);
            //roadShield.Print(); 

        }
    }
}