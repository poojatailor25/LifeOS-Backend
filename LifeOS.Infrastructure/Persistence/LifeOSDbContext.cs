using LifeOS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeOS.Infrastructure.Persistence;

public class LifeOSDbContext : DbContext
{
    public LifeOSDbContext(DbContextOptions<LifeOSDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}