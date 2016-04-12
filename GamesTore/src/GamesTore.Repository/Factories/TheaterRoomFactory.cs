using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;

namespace GamesTore.Repository.Factories
{
    public class TheaterRoomFactory : IFactory<TheaterRoom, TheaterRoomDTO>
    {
        public TheaterRoomDTO ToDto(TheaterRoom objectIn)
        {
            throw new NotImplementedException();
        }

        public TheaterRoom FromDto(TheaterRoomDTO objectIn)
        {
            return (objectIn != null) ?
                new TheaterRoom() 
                {
                    Id = objectIn.Id,
                    SeatsJSON = objectIn.SeatsJSON
                } :
            null;
        }

        public IEnumerable<TheaterRoomDTO> ToDto(IEnumerable<TheaterRoom> objectIn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TheaterRoom> FromDto(IEnumerable<TheaterRoomDTO> objectIn)
        {
            throw new NotImplementedException();
        }
    }
}
