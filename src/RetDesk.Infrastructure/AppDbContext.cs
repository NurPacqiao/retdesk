using Microsoft.EntityFrameworkCore;

namespace RetDesk.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}