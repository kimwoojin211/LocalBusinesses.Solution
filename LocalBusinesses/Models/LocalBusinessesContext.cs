using Microsoft.EntityFrameworkCore;

namespace LocalBusinesses.Models
{
  public class LocalBusinessesContext : DbContext
  {
    public LocalBusinessesContext(DbContextOptions<LocalBusinessesContext> options)
        : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }
  }
}