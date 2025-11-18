using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class KoszykContext : DbContext
    {
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Produkt> Produkty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Koszyk.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria { Id = 1, Nazwa = "Wszystko" },
                new Kategoria { Id = 2, Nazwa = "Odzież" },
                new Kategoria { Id = 3, Nazwa = "Książki" },
                new Kategoria { Id = 4, Nazwa = "Elektronika" }
            );

            modelBuilder.Entity<Produkt>().HasData(
                new Produkt { Id = 3, Nazwa = "Koszulka", Cena = 50.00f, KategoriaId = 2 },
                new Produkt { Id = 4, Nazwa = "Spodnie", Cena = 120.00f, KategoriaId = 2 },
                new Produkt { Id = 5, Nazwa = "Programowanie C#", Cena = 80.00f, KategoriaId = 3 },
                new Produkt { Id = 1, Nazwa = "Laptop", Cena = 2500.00f, KategoriaId = 4 },
                new Produkt { Id = 2, Nazwa = "Smartfon", Cena = 1200.00f, KategoriaId = 4 }
            );
        }
    }
}
