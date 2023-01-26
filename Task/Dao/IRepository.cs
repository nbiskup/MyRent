using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Dao
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetById(int id);
    }
}
