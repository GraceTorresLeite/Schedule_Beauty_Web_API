using System.Collections.Generic;
using WebServiceApi.Models;

namespace WebServiceApi.Repository.Generic
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
