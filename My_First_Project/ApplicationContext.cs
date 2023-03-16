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
        public DbSet<db_Shield> shield { get; set; } = null!;
        public DbSet<db_Size> size { get; set; } = null!;  // тут прописав назву балиці "shield_size"
        public DbSet<db_Figure> figures { get; set; } = null!;

        // public DbSet<Shield_size> Shield_sizes => Set<Shield_size>();
        /*
            або так
            public DbSet<User> Users => Set<User>();
        */
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ВАЖЛИВО! Пароль такий самий як при вході в програму MySQL
            optionsBuilder.UseMySql("server = localhost; user=root; password = kaniuka; database = traffic_sign; ", new MySqlServerVersion(new Version(8, 0, 25)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<db_Size>()
                .HasMany(t => t.Shield_)
                .WithOne(t => t.Size_)
                .HasForeignKey(t => t.size_id)
                .HasPrincipalKey(t => t.Id);
        }


    }
}
