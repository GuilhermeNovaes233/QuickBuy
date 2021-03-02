﻿using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Contracts
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
