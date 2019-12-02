using Microsoft.EntityFrameworkCore;

public class DatingAppContext : DbContext
{
    public DatingAppContext(DbContextOptions<DatingAppContext> options) : base(options)
    {

    }

    public DbSet<Value> values { get; set; }

}
