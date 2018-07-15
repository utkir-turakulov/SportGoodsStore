using Microsoft.EntityFrameworkCore;
using HRDesk.Models;

namespace HRDesk.Data
{
    public class HRDeskContexts
    {
      /*  public HRDeskContext(DbContextOptions<HRDeskContext> context) :
            base(context)
        {
            
        }
        */
       public DbSet<Vacancy> Vacancies { get; set; }
       public DbSet<Interview> Interviews { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connection = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
