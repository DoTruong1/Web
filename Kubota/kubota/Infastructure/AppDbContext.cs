using Kubota.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kubota.Infastructure
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleType> ArticleTypes { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
    }
}