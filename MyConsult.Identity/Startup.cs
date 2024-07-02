using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MyConsult.Identity.Helper;

namespace MyConsult.Identity
{
    public class Startup
    {
        public void ConfigureServices( IServiceCollection services)
        {
            services.AddIdentityServer()
                .AddInMemoryApiResources(Config.ApiResources)
                .AddInMemoryIdentityResources(Config.IdentityResources)
                .AddDeveloperSigningCredential();

        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseIdentityServer();
        }
    }
}