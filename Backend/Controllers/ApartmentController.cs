using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Dao;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApartmentController : ControllerBase
    {
        private IRepository<Apartment> repository;
        public ApartmentController()
        {
            repository = RepositoryFactory.GetApartmentRepository();
        }



        [HttpGet]
        public IActionResult Index()
        {
            var apartments = repository.GetAll();

            return Ok(apartments);
        }                      

    }
}
