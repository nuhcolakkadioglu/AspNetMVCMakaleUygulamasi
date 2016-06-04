using PostApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Data.GenericRepository
{
   public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        private readonly PostAppContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(PostAppContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(T model)
        {
            _dbSet.Attach(model);
            _dbSet.Remove(model);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Insert(T model)
        {
            _dbSet.Add(model);
        }

        public void Update(T model)
        {
            _dbSet.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }
    }
}
