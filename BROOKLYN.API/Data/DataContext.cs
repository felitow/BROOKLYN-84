using Microsoft.EntityFrameworkCore;
using BROOKLYN.SHARED.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
/*using BROOKLYN.SHARED.DTOs*/


namespace BROOKLYN.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //public DbSet<LoginDTO> LoginDTO { get; set; }
        //public DbSet<TokenDTO> TokenDTO { get; set; }
        //public DbSet<User> User { get; set; }
        //public DbSet<UserDTO> USerDTO { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().HasIndex(c => c.Order).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(c => c.EmailCustom).IsUnique();
            modelBuilder.Entity<Delivery>().HasIndex(c => c.Employee).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(c => c.AddressEmpl).IsUnique();
            modelBuilder.Entity<Order>().HasIndex(c => c.Employee).IsUnique();
            modelBuilder.Entity<Pay>().HasIndex(c => c.MethodPay).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(c => c.NameProd).IsUnique();
            

        }

    }
}
