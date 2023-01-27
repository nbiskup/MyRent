using Frontend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace Frontend.Dao
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        public List<Apartment> apartments;
        public async Task<IList<Apartment>> GetAll()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5078/apartment");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                apartments = JsonConvert.DeserializeObject<List<Apartment>>(await reader.ReadToEndAsync());
                return apartments;
            }
        }

        public Apartment GetById(int id)
        {
            return apartments.SingleOrDefault(a => a.IDApartment == id);
        }
    }
}