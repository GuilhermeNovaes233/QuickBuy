using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderData { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderItem> OrderItens { get; set; }
    }
}