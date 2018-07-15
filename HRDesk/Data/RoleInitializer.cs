using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using HRDesk.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HRDesk.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string adminEmail = configuration["firstUser:login"].ToString();
            string adminPassword = configuration["firstUser:password"].ToString();

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if(await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }

            if (await roleManager.FindByNameAsync("master") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("master"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User()
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                };
                IdentityResult result = await userManager.CreateAsync(admin,adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }

    }
}
