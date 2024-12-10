using Microsoft.EntityFrameworkCore;
using ProjectInventoryAPI.Models;

namespace ProjectInventoryAPI.Data
{
    public class ProjectInventoryContext : DbContext
    {
        public ProjectInventoryContext(DbContextOptions<ProjectInventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } // Represents the Items table
    }
}
