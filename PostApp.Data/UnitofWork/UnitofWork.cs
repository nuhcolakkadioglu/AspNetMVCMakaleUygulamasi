using PostApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostApp.Data.GenericRepository;

namespace PostApp.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly PostAppContext _context;
        private bool disposed = false;
        DbContextTransaction transaction;


        public UnitofWork(PostAppContext context)
        {
            Database.SetInitializer<PostAppContext>(null);

            if (context == null)
                throw new ArgumentException("context boş");

            _context = context;
        }

        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void BeginTransaction()
        {
            transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
    }
}
