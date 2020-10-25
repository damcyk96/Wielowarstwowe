using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Dal
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Delete(int id);
        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
    }
}
