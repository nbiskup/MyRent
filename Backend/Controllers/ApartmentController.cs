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

        [HttpGet("XML")]
        public IActionResult IndexXml()
        {
            var apartments = repository.GetAllXml();

            return Ok(apartments);
        }

        [HttpGet("AsXmlDocument")]
        public ContentResult IndexXmlDocument()
        {
            var xmlDocument = repository.GetAllAsXmlDocument();
            string xmlString = xmlDocument.ToString();

            return Content(xmlString, "application/xml");
        }
    }
}
