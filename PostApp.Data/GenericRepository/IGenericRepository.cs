using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Data.GenericRepository
{
    public interface IGenericRepository<T>where T: class
    {

        //sorgulamam işlemleri methdou
        IQueryable<T> GetAll();

        //id göre arama
        T Find(int id);

        //yeni kayıt ekeleme
        void Insert(T model);

        //güncelleme işlemi
        void Update(T model);

        //silme işlemi
        void Delete(T model);



    }
}
