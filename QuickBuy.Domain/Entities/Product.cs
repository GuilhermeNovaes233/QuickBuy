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
                AddErrorMessage("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Description))
                AddErrorMessage("Descrição não foi informado");
        }
    }
}