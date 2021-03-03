using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ValueObject;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItens { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

    }
}
