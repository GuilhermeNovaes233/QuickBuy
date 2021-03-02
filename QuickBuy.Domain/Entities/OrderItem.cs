namespace QuickBuy.Domain.Entities
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
                AddErrorMessage("N�o foi identificado qual a refer�ncia do produto");

            if (Quantity == 0)
                AddErrorMessage("Quantidade n�o foi informado");
        }
    }
}