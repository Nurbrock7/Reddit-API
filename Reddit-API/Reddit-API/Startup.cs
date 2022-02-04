using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reddit_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.   

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(routes =>

            services.AddEntityFramework()
                .AddDbContext<Microsoft.EntityFrameworkCore.DbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"])));

            services.AddIdentity<ApplicationsUser, IdentityRole>()
                .AddEntityFrameworkStores<Microsoft.EntityFrameworkCore.DbContext>()
                .AddDefaultTokenProviders();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        { 
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
