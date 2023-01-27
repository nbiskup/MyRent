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
            string fileName = @"C:\Users\Nikola\OneDrive - Visoko uciliste Algebra\Desktop\MyRent_Task\MyRent\Backend\Database\MyRentData.json";            

            string json = File.ReadAllText(fileName);
            apartments = JsonConvert.DeserializeObject<List<Apartment>>(json);

            return apartments;
        }
    }
}