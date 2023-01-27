﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Dao
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
    }
}
