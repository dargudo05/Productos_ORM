using Microsoft.EntityFrameworkCore;
using Productos_ORM.Models.Entities;

namespace Productos_ORM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Producto> Productos {  get; set; }
    }
}
