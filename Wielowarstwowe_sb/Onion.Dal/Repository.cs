using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Dal
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private VideoContext _context;
        private DbSet<T> _set;

        public Repository(VideoContext context)
        {
            _context = context;
            _set = _context.Set<T>();

        }

        public void Create(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _set;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
