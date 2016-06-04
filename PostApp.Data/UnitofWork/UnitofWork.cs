using PostApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly PostAppContext _context;

        public UnitofWork(PostAppContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
           return _context.SaveChanges();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        
    }
}
