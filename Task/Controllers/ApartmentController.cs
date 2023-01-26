using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Dao;
using Task.Models;

namespace Task.Controllers
{
    public class ApartmentController : Controller
    {
        private static IRepository<Apartment> repository;
        public ApartmentController()
        {
            repository = GetRepository.GetApartmentRepository();
        }

        public ActionResult Index()
        {
            return View(repository.GetAll());
        }


        public ActionResult Details(int id)
        {
            Apartment apartment = repository.GetById(id);

            if (apartment == null)
                return HttpNotFound();

            return View(apartment);
        }
    }
}