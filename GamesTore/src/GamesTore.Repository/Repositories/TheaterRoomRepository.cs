using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Factories;

namespace GamesTore.Repository.Repositories
{
    public class TheaterRoomRepository
    {

        public async void AddTheaterRoom(TheaterRoomDTO theaterRoom)
        {
            using (var db = new TheaterDbContext())
            {
                db.TheaterRooms.Add(new TheaterRoomFactory().FromDto(theaterRoom));
                await db.SaveChangesAsync();
            }
        }
    }
}
