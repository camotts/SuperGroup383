using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;

namespace GamesTore.Repository.Factories
{
    internal class UserFactory : IFactory<User, UserDTO>
    {
        public UserDTO ToDto(User objectIn)
        {
            
            return (objectIn != null) ?
                new UserDTO()
            {
                FirstName = objectIn.FirstName,
                LastName = objectIn.LastName,
                Role = objectIn.Role,
                Id = objectIn.Id
            }:
            null;
        }

        public User FromDto(UserDTO objectIn)
        {
            return (objectIn != null)?
                new User()
            {
                FirstName = objectIn.FirstName,
                LastName = objectIn.LastName,
                Role = objectIn.Role,
                Id = objectIn.Id
            }:
            null;
        }

        public IEnumerable<UserDTO> ToDto(IEnumerable<User> objectIn)
        {
            return objectIn.Select(ToDto);
        }

        public IEnumerable<User> FromDto(IEnumerable<UserDTO> objectIn)
        {
            throw new NotImplementedException();
        }
    }
}
