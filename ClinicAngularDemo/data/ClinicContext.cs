using ClinicAngularDemo.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace ClinicAngularDemo.data
{
    public class ClinicContext:IdentityDbContext<ApplicationUsers>
    {
        private readonly IConfiguration config;

        public ClinicContext(IConfiguration _config)
        {
            config = _config;
        }
        public DbSet<Country> countries { get; set; }

        public DbSet<Patients> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("clinicConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
