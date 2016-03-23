using System;
using System.Collections.Generic;

namespace GamesTore.Repository.Classes
{
    public class Ticket
    {
        public int Id { get; set; }

        public List<PriceTime> Times { get; set; }

        public string Name { get; set; }
    }
}