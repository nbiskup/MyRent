using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Dao;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApartmentController : ControllerBase
    {
        private IRepository<Apartment> _repository;
        public ApartmentController()
        {
            _repository = new ApartmentRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var apartments = _repository.GetAll();

            return Ok(apartments);
        }

        [HttpGet("XML")]
        public IActionResult IndexXml()
        {
            var apartments = _repository.GetAllXml();

            return Ok(apartments);
        }

        [HttpGet("AsXmlDocument")]
        public ContentResult IndexXmlDocument()
        {
            var xmlDocument = _repository.GetAllAsXmlDocument();
            string xmlString = xmlDocument.ToString();

            return Content(xmlString, "application/xml");
        }
    }
}
