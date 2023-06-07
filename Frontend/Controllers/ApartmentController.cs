using Frontend.Dao;
using Frontend.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Frontend.Controllers
{
    public class ApartmentController : Controller
    {
        private IRepository<Apartment> _repository;

        public ApartmentController()
        {
            _repository = new ApartmentRepository();
        }

        public async Task<ActionResult> Index(string searchInput)
        {
            var apartments = await _repository.GetAll();
            ViewData["data_table"] = apartments;
            if (searchInput == null || searchInput.IsNullOrWhiteSpace())
                return View(apartments);

            return View(apartments.Where(a => a.Name.ToLower().StartsWith(searchInput.ToLower())));
        }

        public ActionResult Details(int id)
        {
            var apartment = _repository.GetById(id);

            if (apartment == null)
                return HttpNotFound();

            return View(apartment);
        }
    }
}