using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;

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
    }
}
