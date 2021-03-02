using QuickBuy.Domain.Entities;

namespace QuickBuy.Domain.Contracts
{
    public interface IUserRepository : IBaseRepositorio<Product>
    {
        User Get(string email, string password);
        User Get(string email);
    }
}