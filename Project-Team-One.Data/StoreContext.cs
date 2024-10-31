using Project.Team.One.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Project.Team.One.Domain.Orders;

namespace Project.Team.One.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            {}

            public DbSet<Item> Items { get; set; }

            public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}