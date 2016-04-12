using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Classes;
using GamesTore.Repository.Interfaces;
using GamesTore.Repository.Repositories;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;

namespace GamesTore.Repository
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<TheaterDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MoviesDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"));
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            using (var context = new TheaterDbContext())
            {
                if (env.IsDevelopment())
                {
                    //Add seed code here

                    context.Users.AddRange(SeedUsers());
                    //etc

                    context.SaveChanges();
                }
            }
        }

        private IEnumerable<User> SeedUsers()
        {
            var Users = new List<User>();
            for (var i = 0; i < 12; i++)
            {
                Users.Add(CreateUser());
            }
            return Users;
        }

        private static User CreateUser() => new User
        {
            FirstName = "Cameron",
            LastName = "Otts",
            Role = Role.Admin
        };
    }
}
