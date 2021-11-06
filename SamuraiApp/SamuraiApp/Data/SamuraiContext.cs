using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiApp.Domain;
namespace SamuraiApp.Data
{
    public  class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais  { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Clan>  Clans { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0KLUTMR\\SQLEXPRESS;Database=Samurai;Trusted_Connection=True;");

        }
    }

  
}
