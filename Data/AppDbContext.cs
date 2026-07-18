using DevTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace DevTrack.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Technology> Technologies { get; set; } = null!;
}