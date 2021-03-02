using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddErrorMessage("Email não foi informado");

            if (string.IsNullOrEmpty(Password))
                AddErrorMessage("Senha não foi informado");
        }
    }
}