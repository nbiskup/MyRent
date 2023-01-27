using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Frontend.Dao
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        T GetById(int id);
    }
}