using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Task.Models;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task.Dao
{
    public class ApartmentRepository : IRepository<Apartment>
    {
        List<Apartment> apartments;
        string folder_path = "App_Data\\";
        
        public IList<Apartment> GetAll()
        {
            string fileName = "C:\\Users\\Nikola\\OneDrive - Visoko uciliste Algebra\\Desktop\\MyRent_Task\\MyRent\\Task\\";
            //string fileName = "C:\\Users\\Nikola\\OneDrive - Visoko uciliste Algebra\\Desktop\\MyRent_Task\\MyRent\\Task\\App_Data\\MyRentData.json";

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