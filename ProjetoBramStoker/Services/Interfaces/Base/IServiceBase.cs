using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        T GetOne(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetManyBy(Func<T, bool> ent);
        T GetOneBy(Func<T, bool> ent);
        void Delete(int id);
        void Save(T ent);
    }
}
