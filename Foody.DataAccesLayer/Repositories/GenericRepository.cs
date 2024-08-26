using Foody.DataAccesLayer.Abstract;
using Foody.DataAccesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly FoodyContext _context;
        private object?[]? id;

        public GenericRepository(FoodyContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
