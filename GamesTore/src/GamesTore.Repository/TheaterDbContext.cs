using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Repository.Classes;
using Microsoft.Data.Entity;

namespace GamesTore.Repository
{
    public class TheaterDbContext : DbContext
    {
        private static bool _created = false;

        public TheaterDbContext()
        {
            if (_created) return;
            _created = true;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Theater> Theaters { get; set; }
        public DbSet<TheaterRoom> TheaterRooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }  
        public DbSet<PriceTime> Prices { get; set; }   
    }
}
