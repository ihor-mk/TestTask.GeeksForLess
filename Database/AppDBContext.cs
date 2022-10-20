using GFL.TestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace GFL.TestTask.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Folder> Folders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Folder> initFolderList = new List<Folder>()
            {
                new Folder () {Id = 1, Title = "Creating Digital Images"},
                new Folder () {Id = 2, Title = "Resources", ParentId = 1},
                new Folder () {Id = 3, Title = "Evidence", ParentId = 1},
                new Folder () {Id = 4, Title = "Graphic Products", ParentId = 1},
                new Folder () {Id = 5, Title = "Primary Sources", ParentId = 2},
                new Folder () {Id = 6, Title = "Secondary Sources", ParentId = 2},
                new Folder () {Id = 7, Title = "Process", ParentId = 4},
                new Folder () {Id = 8, Title = "Final Producty", ParentId = 4},
            };

            modelBuilder.Entity<Folder>().HasData(initFolderList);
        }
    }
}