using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Fiver.Mvc.StatusError
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseStatusCodePagesWithReExecute("/Errors/Index", "?statusCode={0}");
            //app.UseStatusCodePagesWithRedirects("/Errors/Index?statusCode={0}");

            app.UseMvcWithDefaultRoute();
        }
    }
}
