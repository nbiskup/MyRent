using Newtonsoft.Json;
using Backend.Models;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace Backend.Dao
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        const string PATH_JSON = @"..\..\..\Database\MyRentData.json";
        const string PATH_XML = @"..\..\..\Database\apartments.xml";
        
        List<Apartment> apartments;

        public IList<Apartment> GetAll()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(sCurrentDirectory, PATH_JSON);            
            string fullFilePath = Path.GetFullPath(filePath);

            string json = File.ReadAllText(fullFilePath);
            apartments = JsonConvert.DeserializeObject<List<Apartment>>(json);

            return apartments;
        }

        public IList<Apartment> GetAllXml()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(sCurrentDirectory, PATH_XML);
            string fullFilePath = Path.GetFullPath(filePath);

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fullFilePath);

            XmlSerializer serializer = new XmlSerializer(typeof(ApartmentList));
            using (XmlReader reader = new XmlNodeReader(xmlDocument.DocumentElement))
            {
                var apartmentsList = (ApartmentList)serializer.Deserialize(reader);
                apartments = apartmentsList.Apartments;
            }

            return apartments;
        }

        public XDocument GetAllAsXmlDocument()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(sCurrentDirectory, PATH_XML);
            string fullFilePath = Path.GetFullPath(filePath);

            XDocument xmlDocument = XDocument.Load(fullFilePath);

            return xmlDocument;
        }
    }
}