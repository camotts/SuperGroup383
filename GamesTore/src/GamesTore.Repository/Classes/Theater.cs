using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GamesTore.Repository.Classes
{
    public class Theater
    {
        public int Id { get; set; }

        public IEnumerable<TheaterRoom> Rooms { get; set; } 

        public User Manager { get; set; }

        public List<User> Employees { get; set; }

        public List<Ticket> Tickets { get; set; } 

    }

}
