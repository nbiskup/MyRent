using System.Xml.Linq;

namespace Backend.Dao
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        IList<T> GetAllXml();
        XDocument GetAllAsXmlDocument();
    }
}
