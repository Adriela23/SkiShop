using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext // DbContext derives from Entity class
    {
        public StoreContext(DbContextOptions options) : base(options) // this constructor pass some options to DbContext class so we can connect with db
        {
        }

        public DbSet<Product> Products { get; set; } // property of Product type, this represents a table from the db
    }
}