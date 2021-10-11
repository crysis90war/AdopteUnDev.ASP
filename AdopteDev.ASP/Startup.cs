using AdopteDev.ASP.Infrastructure;
using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Repositories;
using AdopteUnDev.DAL.Interfaces;
using AdopteUnDev.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AdopteDev.ASP
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
            services.AddControllersWithViews();

            services.AddHttpContextAccessor();
            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "AdopteUnDev.Cookie";
                options.IdleTimeout = TimeSpan.FromHours(1);
            });

            // Dev
            services.AddScoped<IDeveloppeurDalRepository, DeveloppeurDalRepository>();
            services.AddScoped<IDeveloppeurBllRepository, DeveloppeurBllRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserBllRepository, UserBllRepository>();

            // CLient
            services.AddScoped<IClientDalRepository, ClientDalRepository>();
            services.AddScoped<IClientBllRepository, ClientBllRepository>();

            // Asp
            services.AddScoped<ISessionManager, SessionManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
