using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesTore.Domain.DTOs
{
    public class TheaterDTO
    {
        public int Id { get; set; }
        public IEnumerable<TicketDTO> Tickets { get; set; }
        public IEnumerable<UserDTO> Employees { get; set; }
        public IEnumerable<TheaterRoomDTO> Rooms { get; set; }

    }
}
