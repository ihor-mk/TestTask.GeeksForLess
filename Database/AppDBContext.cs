using GFL.TestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace GFL.TestTask.Database
{

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions options) : base (options)
    {}
    public DbSet<Folder> Folders {get; set;}
}
}