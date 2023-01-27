using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Backend.Models;

namespace Backend.Dao
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        List<Apartment> apartments;

        public IList<Apartment> GetAll()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(sCurrentDirectory, @"..\..\..\Database\MyRentData.json");
            string fullFilePath = Path.GetFullPath(filePath);

            string json = File.ReadAllText(fullFilePath);
            apartments = JsonConvert.DeserializeObject<List<Apartment>>(json);

            return apartments;
        }
    }
}