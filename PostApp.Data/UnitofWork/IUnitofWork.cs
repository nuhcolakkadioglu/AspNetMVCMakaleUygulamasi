using PostApp.Data.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Data.UnitofWork
{
    public interface IUnitofWork:IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class;


        int SaveChanges();

        void BeginTransaction();

        void Commit();

        void Rollback();

    }
}
