using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;

namespace GamesTore.Repository.Factories
{
    public class TicketFactory : IFactory<Ticket, TicketDTO>
    {
        public TicketDTO ToDto(Ticket objectIn)
        {
            throw new NotImplementedException();
        }

        public Ticket FromDto(TicketDTO objectIn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TicketDTO> ToDto(IEnumerable<Ticket> objectIn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> FromDto(IEnumerable<TicketDTO> objectIn)
        {
            throw new NotImplementedException();
        }
    }
}
