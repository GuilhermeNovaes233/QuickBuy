using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderData { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryForecast { get; set; }

        //TODO - Separar em uma classe de endereço
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string NumberAddress { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } 


        public ICollection<OrderItem> OrderItens { get; set; }
    }
}