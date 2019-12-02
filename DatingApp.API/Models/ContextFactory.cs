using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MyProject
{
    public class DatingAppContextFactory : IDesignTimeDbContextFactory<DatingAppContext>
    {
        public DatingAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatingAppContext>();
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\v11.0;Database=DatingApp;Trusted_Connection=True;MultipleActiveResultSets=true");
            //Microsoft.Extensions.Configuration.ConfigurationSection("DatingAppDB"));

            return new DatingAppContext(optionsBuilder.Options);
        }
    }
}