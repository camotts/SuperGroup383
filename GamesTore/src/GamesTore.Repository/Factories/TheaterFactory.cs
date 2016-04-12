using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;

namespace GamesTore.Repository.Factories
{
    public class TheaterFactory : IFactory<Theater, TheaterDTO>
    {
        public TheaterDTO ToDto(Theater objectIn)
        {
            return (objectIn != null) ?
                new TheaterDTO()
                {
                    Employees = new UserFactory().ToDto(objectIn.Employees),
                    Id = objectIn.Id,
                    Rooms = new TheaterRoomFactory().ToDto(objectIn.Rooms),
                    Tickets = new TicketFactory().ToDto(objectIn.Tickets)
                } :
            null;
        }

        public Theater FromDto(TheaterDTO objectIn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TheaterDTO> ToDto(IEnumerable<Theater> objectIn)
        {
            return objectIn.Select(ToDto);
        }

        public IEnumerable<Theater> FromDto(IEnumerable<TheaterDTO> objectIn)
        {
            throw new NotImplementedException();
        }
    }
}
