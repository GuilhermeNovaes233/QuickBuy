﻿using QuickBuy.Domain.Entities;

namespace QuickBuy.Domain.Contracts
{
    public interface IUserRepository : IBaseRepository<Product>
    {
        User Get(string email, string password);
        User Get(string email);
    }
}