using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public interface IRepository<T, TKey> where T: class, new() where TKey: struct
    {
        IEnumerable<T> Get();
        T Get(TKey id);

        void Update(TKey id, T entity);

        T Create(T entity);

        void Delete(TKey id);
    }
}
