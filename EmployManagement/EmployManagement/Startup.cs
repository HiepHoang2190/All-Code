using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployManagement
{
    public class Startup
    {
        private readonly IConfiguration config;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option=>option.EnableEndpointRouting=false);
            services.AddMvc(o =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                o.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("EmployeeDbConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseStatusCodePages();
                //app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }
            else
            {
                 //app.UseStatusCodePages();
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }

            app.UseStaticFiles();// hiển thị ảnh,file tĩnh
            app.UseAuthentication();
            //app.UseMvc();
            app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes => 
            //{
            //    routes.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
