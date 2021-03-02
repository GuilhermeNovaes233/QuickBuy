namespace QuickBuy.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddErrorMessage("Nome do produto n�o foi informado");

            if (string.IsNullOrEmpty(Description))
                AddErrorMessage("Descri��o n�o foi informado");
        }
    }
}