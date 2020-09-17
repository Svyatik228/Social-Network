using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Social_Network.ServiceExtension
{
    public static class ServiceExtension
    {
        public static void AddMongoSettings(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            
        }
    }
}
