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
        public DbSet<db_Shields> /* зміни в назві*/shields { get; set; } = null!;
        public DbSet<db_Sizes> /* зміни в назві*/sizes { get; set; } = null!;  // тут прописав назву балиці "size"
        public DbSet<db_Figures> /* зміни в назві*/figures { get; set; } = null!;
        public DbSet<db_Groups> /* зміни в назві*/groups { get; set; } = null!;


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
               .Entity<db_Shields>()
               .HasKey(t => new { t.size_id, t.figure_id, t.group_id});


            modelBuilder
                .Entity<db_Sizes>()
                
                .HasMany(t => t.Shield_)  // налаштовуємо, що у "Типорозміра" є багато щитків
                
                .WithOne(t => t.Size_)  // налаштовуємо, що у проміжної сущності є один розмір
                                       
                .HasForeignKey(t => t.size_id)  // задаємо зовнішній ключ проміжної сущності
                                               
                .HasPrincipalKey(t => t.Id);  // вказуємо головний ключ в сущности "Типорозмір"


            modelBuilder
               .Entity<db_Figures>()
               
               .HasMany(t => t.Shield_)  // налаштовуємо, що у "Фігури" є багато щитків

               .WithOne(t => t.Figure_) // налаштовуємо, що у проміжної сущності є одну "фігуру"

               .HasForeignKey(t => t.figure_id) // задаємо зовнішній ключ проміжної сущності

               .HasPrincipalKey(t => t.Id); // вказуємо головний ключ в сущности "Фігура"

            modelBuilder
              .Entity<db_Groups>()
              
              .HasMany(t => t.Shield_) // налаштовуємо, що у "Групи" є багато щитків

              .WithOne(t => t.Group_) // налаштовуємо, що у проміжної сущності є одна "група"

              .HasForeignKey(t => t.group_id) // задаємо зовнішній ключ проміжної сущності

              .HasPrincipalKey(t => t.Id); // вказуємо головний ключ в сущности "Група"




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
