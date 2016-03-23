using System;

namespace GamesTore.Repository.Classes
{
    public class PriceTime
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }
    }
}