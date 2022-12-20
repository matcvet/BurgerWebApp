using Microsoft.EntityFrameworkCore;
using DomainModels;

namespace DataAccess
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions<BurgerAppDbContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MenuItem>(x => x.ToTable("MenuItem"));
            builder.Entity<Burger>(x => x.ToTable("Burger"));
            builder.Entity<Size>(x => x.ToTable("Size"));
            builder.Entity<OrderItem>(x => x.ToTable("OrderItem"));
            builder.Entity<Order>(x => x.ToTable("Order")
            .HasMany(y => y.OrderItems)
            .WithOne(z => z.Order)
            .HasForeignKey(t => t.OrderId));

            // Seeding
            builder.Entity<Burger>().HasData(
                    new Burger("Cheeseburger", "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-tall-FS-38.webp")
                    {
                        Id = 1
                    },
                    new Burger("Hamburger", "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.tastingtable.com/img/gallery/heres-how-hamburgers-got-their-name/intro-1653066580.webp")
                    {
                        Id = 2
                    },
                    new Burger("Chickenburger", "Chicken, Onions, Tomatoes, Kethcup, Lettuce", "https://i1.wp.com/gofry.com.fj/wp-content/uploads/2019/04/Chicken_Burger-scaled-e1624614963511.jpg?fit=600%2C583&ssl=1")
                    {
                        Id = 3
                    }
                );

            builder.Entity<Size>().HasData(
                new Size("S", "10cm")
                {
                 Id = 1
                },
                new Size("M", "15cm")
                {
                    Id = 2
                },
                new Size("XL", "20cm")
                {
                    Id = 3
                }
            );

            builder.Entity<MenuItem>().HasData(
                    new MenuItem(1, 1, 100)
                    {
                        Id = 1
                    },
                    new MenuItem(1, 2, 130)
                    {
                        Id = 2
                    },
                    new MenuItem(1, 3, 150)
                    {
                        Id = 3
                    },
                    new MenuItem(2, 1, 120)
                    {
                        Id = 4
                    },
                    new MenuItem(2, 2, 150)
                    {
                        Id = 5
                    },
                    new MenuItem(2, 3, 170)
                    {
                        Id = 6
                    },
                    new MenuItem(3, 1, 110)
                    {
                        Id = 7
                    },
                    new MenuItem(3, 2, 140)
                    {
                        Id = 8
                    },
                    new MenuItem(3, 3, 180)
                    {
                        Id = 9
                    }
                );
        }
    }
}
