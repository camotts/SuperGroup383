
using System.ComponentModel.DataAnnotations.Schema;
using GamesTore.Domain.DTOs;

namespace GamesTore.Repository.Classes
{
    public class User
    {
        [Column]
        public int Id { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column]
        public Role Role { get; set; }
        [Column]
        public string Username { get; set; }
        [Column]
        public string Password { get; set; }
        public virtual Theater Theater { get; set; }

    }

    
}