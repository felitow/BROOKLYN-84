using Microsoft.EntityFrameworkCore;
using BROOKLYN.SHARED.Entities;

namespace BROOKLYN.API.Data
{
    public class DataContext : DbContext
    {
        // DbSet para cada entidad
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de las relaciones

            modelBuilder.Entity<CartProduct>()
        .HasKey(cp => new { cp.CartId, cp.ProductId });

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Cart)
                .WithMany(c => c.CartProducts)
                .HasForeignKey(cp => cp.CartId);

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CartProducts)
                .HasForeignKey(cp => cp.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cart)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CartId);

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Cart)
                .HasForeignKey(o => o.CartId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.CartProducts)
                .WithOne(cp => cp.Product)
                .HasForeignKey(cp => cp.ProductId);

            modelBuilder.Entity<Delivery>()
                .HasMany(d => d.Orders)
                .WithOne(o => o.Delivery)
                .HasForeignKey(o => o.DeliveryId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithOne(o => o.Employee)
                .HasForeignKey(o => o.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Deliveries)
                .WithOne(d => d.Employee)
                .HasForeignKey(d => d.EmployeeId);

            modelBuilder.Entity<Pay>()
                .HasOne(p => p.Order)
                .WithOne(o => o.Pay)
                .HasForeignKey<Order>(o => o.PayId);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Deliveries)
                .WithOne(d => d.Customer)
                .HasForeignKey(d => d.CustomerId);



        }
    }
}
