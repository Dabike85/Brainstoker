using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Bram_Stoker_2.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetOne(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetManyBy(Func<bool, T> ent);
        IEnumerable<T> GetOneBy(Func<bool, T> ent);
        void Delete(int id);
        void Save(T ent);
    }
}
