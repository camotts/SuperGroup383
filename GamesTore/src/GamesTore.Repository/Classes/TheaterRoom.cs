using System.Linq;

namespace GamesTore.Repository.Classes
{
    public class TheaterRoom
    {
        public int Id { get; set; }
        public bool[][] Seats { get; set; }

        public int Count()
        {
            return Seats.Sum(row => row.Length);
        }

        public int AvailableSeats()
        {
            return Seats.Sum(row => row.ToList().Count(x => x));
        }
    }
}