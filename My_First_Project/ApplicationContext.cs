using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace My_First_Project
{
    public class ApplicationContext : DbContext
    {
        public DbSet<db_Shield> /* зміни в назві*/shield { get; set; } = null!;
        public DbSet<db_Size> /* зміни в назві*/size { get; set; } = null!;  // тут прописав назву балиці "size"
        public DbSet<db_Figure> /* зміни в назві*/figure { get; set; } = null!;

        
        public ApplicationContext()
        {
            //Database.EnsureCreated(); // видаляє попередню базу і створює нову?
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ВАЖЛИВО! Пароль такий самий як при вході в програму MySQL
            optionsBuilder.UseMySql("server = localhost; user=root; password = kaniuka; database = traffic_sign; ", new MySqlServerVersion(new Version(8, 0, 25)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // з використанням проміжної сутності
            // виходить так, що налаштовуємо два відношення one-to-many
            // від одного "Типорозміру" до безлічі проміжних сутностей
            // від одного автора до безлічі проміжних сутностей

            // дуже важливо вказати тут складовий ключ
            // інакше EF Core не зрозуміє що потрібна конфігурація зв'язку між сутностями як many-to-many

            modelBuilder
               .Entity<db_Shield>()
               .HasKey(t => new { t.size_id, t.figure_id});


            modelBuilder
                .Entity<db_Size>()
                
                .HasMany(t => t.Shield_)  // налаштовуємо, що у "Типорозміра" є багато щитків
                
                .WithOne(t => t.Size_)  // налаштовуємо, що у проміжеої сущності є один розмір
                                       
                .HasForeignKey(t => t.size_id)  // задаємо зовнішній ключ проміжної сущності
                                               
                .HasPrincipalKey(t => t.Id);  // вказуємо головний ключ в сущности "Типорозмір"


            modelBuilder
               .Entity<db_Figure>()
               // настраиваем то, что у автора есть множество промежуточных сущностей
               .HasMany(t => t.Shield_)
               // настраиваем то, что у промежуточной сущности есть один автор
               .WithOne(t => t.Figure_)
               // задаем внешний ключ промежуточной сущности
               .HasForeignKey(t => t.figure_id)
               // указываем главный ключ в сущности Автор
               .HasPrincipalKey(t => t.Id);




            /* удал

            modelBuilder
                .Entity<db_Size>()
                .HasMany(t => t.Shield_)
                .WithOne(t => t.Size_)
                .HasForeignKey(t => t.size_id)
                .HasPrincipalKey(t => t.Id);

           
            */





        }


    }
}
