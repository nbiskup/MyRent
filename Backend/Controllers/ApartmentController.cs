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

        [HttpGet("Index")]
        public IActionResult Index(string? apartmentName)
        {
            var apartments = _repository.GetAll();
            
            if (string.IsNullOrWhiteSpace(apartmentName))
                return Ok(apartments);

            return Ok(apartments.Where(a => a.Name.ToLower().StartsWith(apartmentName.ToLower())));
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
