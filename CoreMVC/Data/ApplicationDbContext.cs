using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoreMVC.Models;
using CoreAPI.Models;

namespace CoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CoreMVC.Models.ToBuy> ToBuy { get; set; } = default!;
        public DbSet<CoreAPI.Models.Product> Product { get; set; } = default!;
        public DbSet<ProductModel> Products { get; set; }

    }
}
