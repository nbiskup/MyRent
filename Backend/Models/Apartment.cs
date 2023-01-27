using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Apartment
    {
        [JsonProperty(PropertyName = "idapartment")]
        public int IDApartment { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "bedrooms")]
        public int Bedrooms { get; set; }

        [JsonProperty(PropertyName = "bathrooms")]
        public int Bathrooms { get; set; }

        [JsonProperty(PropertyName = "cansleepmax")]
        public int CanSleepMax { get; set; }
                       
        [JsonProperty(PropertyName = "from")]
        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                From_ShortDate = from.ToShortDateString();
            }
        }
        private DateTime from;
        public string? From_ShortDate { get; private set; }
                
        [JsonProperty(PropertyName = "to")]
        public DateTime To {
            get { return to; }
            set
            {
                to = value;
                To_ShortDate = to.ToShortDateString();
            }
        }

        private DateTime to;
        public string? To_ShortDate { get; private set; }

    }
}