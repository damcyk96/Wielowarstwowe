using Microsoft.Extensions.DependencyInjection;
using Onion.Abstract;
using Onion.Dal;
using Onion.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Resolver
{
    public class Registrator
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfwork>();
            services.AddDbContext<VideoContext>();
            services.AddScoped<IVideoService, VideoService>();
        }
    }
}
