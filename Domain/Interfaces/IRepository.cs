using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T? GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
