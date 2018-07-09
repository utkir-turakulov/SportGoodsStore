using HRDesk.Data;
using HRDesk.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace HRDesk
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("Account/Register");
                });

            /* services.AddAuthorization(opts => {
                 opts.AddPolicy("Delete", policy => {
                     policy.RequireClaim("role", "admin","user", "director");
                 });
             });*/

            /*services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = true;

            });*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();            
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action }/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "Vacancies",
                    template: "{controller=Vacancies}/{action=GetVacancies }/{id?}");

                routes.MapRoute(
                   name: "Create users",
                   template: "{controller=Users}/{action }/{id?}");

                routes.MapRoute(
                    name: "Roles",
                    template: "{controller = Roles}/{action = Create}/{id?}"
                    );
                routes.MapRoute(
                    name: "Settings",
                    template: "{controller = Settings}/{action}/{id?}"
                    );
            });

            app.Run(async (context) =>
            {
                context.Response.Redirect("Home/Index");
            });


        }
    }
}
