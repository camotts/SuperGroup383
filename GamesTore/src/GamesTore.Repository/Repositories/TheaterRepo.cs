using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Repository.Classes;
using Microsoft.Extensions.DependencyInjection;

namespace GamesTore.Repository.Repositories
{
    public static class TheaterRepo
    {

        public static Theater GeTheaterById(int id)
        {
            Theater theater;
            using (var db = new TheaterDbContext())
            {
               theater = db.Theaters.FirstOrDefault(x => x.Id == id);
            }

            return theater;
        }

        public static Theater GeTheaterByManager(User manager)
        {
            Theater theater;
            using (var db = new TheaterDbContext())
            {
                theater = db.Theaters.FirstOrDefault(x => x.Manager.Id == manager.Id);
            }

            return theater;
        }
    }
}
