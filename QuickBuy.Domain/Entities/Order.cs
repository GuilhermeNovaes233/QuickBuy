using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderData { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
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

        public override void Validate()
        {
            CleanMessagesValidation();

            if (!OrderItens.Any())
                AddErrorMessage("Error - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(ZipCode))
                AddErrorMessage("Error - CEP deve estar preenchido");

            if (PaymentMethodId == 0)
                AddErrorMessage("Error - Não foi informado a forma de pagamento");
        }
    }
}