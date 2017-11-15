using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Services
{
   public interface IDbContext
    {
        bool Persist(object entity);

        T FindBy<T>(int id);

        IEnumerable<T> FindAll<T>();

        IEnumerable<T> FindAll<T>(string where);

        T First<T>();

        T FindFirst<T>(string where);

        void Delete(object entity);

        void DeleteById<T>(int id);
    }
}
