using ASPNET6_MVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET6_MVC.Data
{
  public class MVCDemoDbContext : DbContext
  {
    public MVCDemoDbContext(DbContextOptions options) : base(options)
    {
      
    }

    public DbSet<Employee> Employees { get; set; }
  }
}
