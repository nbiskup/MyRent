using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.Models;

namespace Backend.Dao
{
    public static class RepositoryFactory
    {
        private static IRepository<Apartment> repository = new ApartmentRepository();
        public static IRepository<Apartment> GetApartmentRepository() => repository;
    }
}