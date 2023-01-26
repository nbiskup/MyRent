using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Dao
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        List<Apartment> apartments;

        public IList<Apartment> GetAll()
        {
            string fileName = "C:\\Users\\Nikola\\source\\repos\\Apartments\\Frontend\\App_Data\\MyRentData.json";


            //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"App_Data\", "MyRentData.json");
            string json = File.ReadAllText(fileName);//@"../App_Data/MyRentData.json");
            apartments = JsonConvert.DeserializeObject<List<Apartment>>(json);

            return apartments;
        }

        public Apartment GetById(int id)
        {
            return apartments.SingleOrDefault(a => a.IDApartment == id);
        }
    }
}