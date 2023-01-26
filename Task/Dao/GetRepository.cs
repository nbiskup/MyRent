using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Dao
{
    public static class GetRepository
    {
        private static IRepository<Apartment> repository = new ApartmentRepository();
        public static IRepository<Apartment> GetApartmentRepository() => repository;
    }
}