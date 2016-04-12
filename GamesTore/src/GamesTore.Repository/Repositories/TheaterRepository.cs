using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;
using GamesTore.Repository.Factories;
using Microsoft.Data.Entity;

namespace GamesTore.Repository.Repositories
{
    public class TheaterRepository
    {
        public async Task<TheaterDTO> GetTheaterById(int id)
        {
            Theater ret;
            using (var db = new TheaterDbContext())
            {
                ret = await db.Theaters.FirstOrDefaultAsync(x => x.Id == id);
            }

            return new TheaterFactory().ToDto(ret);
        }

        public async Task<IEnumerable<TheaterDTO>> GetAllTheaters()
        {
            List<Theater> ret;
            using (var db = new TheaterDbContext())
            {
                ret = await db.Theaters.ToListAsync();
            }

            return new TheaterFactory().ToDto(ret);
        }

    }
}
