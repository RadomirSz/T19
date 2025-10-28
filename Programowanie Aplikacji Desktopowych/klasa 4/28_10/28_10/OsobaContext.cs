using Microsoft.EntityFrameworkCore;

namespace _28_10
{
    class OsobaContext : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=kurczak.db;");
        }
    }
}
