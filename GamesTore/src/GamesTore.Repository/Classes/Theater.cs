using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Metadata.Internal;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesTore.Repository.Classes
{
    public class Theater
    {
        public int Id { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; } 
        [ForeignKey("Id")]
        public virtual IEnumerable<User> Employees { get; set; }
        [ForeignKey("Id")]
        public virtual IEnumerable<TheaterRoom> Rooms { get; set; } 
    }

}
