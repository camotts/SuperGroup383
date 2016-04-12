using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;
using GamesTore.Repository.Factories;
using GamesTore.Repository.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;

namespace GamesTore.Repository.Repositories
{
    public class UserRepository : IRepository
    {
        public async Task<UserDTO> GetUserById(int id)
        {
            User ret;
            using (var db = new TheaterDbContext())
            {
                ret = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            }
            return new UserFactory().ToDto(ret);
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            List<User> ret;
            using (var db = new TheaterDbContext())
            {
                ret = await db.Users.ToListAsync();
            }
            
            return new UserFactory().ToDto(ret);
        }

        public async void AddUser(UserDTO user)
        {
            using (var db = new TheaterDbContext())
            {
                db.Users.Add(new UserFactory().FromDto(user));
                await db.SaveChangesAsync();
            }
        }

        public async Task<UserDTO> EditUser(UserDTO user)
        {
            using (var db = new TheaterDbContext())
            {
                var old = await db.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
                old.Id = user.Id;
                old.FirstName = user.FirstName;
                old.LastName = user.LastName;
                old.Role = user.Role;
                db.Entry(old).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return new UserFactory().ToDto(old);
            }
        }

        public async void DeleteUser(int id)
        {
            using (var db = new TheaterDbContext())
            {
                var old = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
                if (old == null) return;
                db.Users.Remove(old);
                await db.SaveChangesAsync();
            }
        }
    }
}
