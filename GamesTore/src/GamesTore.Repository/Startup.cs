using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamesTore.Repository
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }


    }
}
