using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class Apartment
    {
        [JsonProperty(PropertyName = "id")]
        public int IDApartment { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "bedrooms")]
        public int Bedrooms { get; set; }

        [JsonProperty(PropertyName = "bathrooms")]
        public int Bathrooms { get; set; }

        [JsonProperty(PropertyName = "can_sleep_max")]
        public int CanSleepMax { get; set; }

        [JsonProperty(PropertyName = "from")]
        public DateTime From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public DateTime To { get; set; }

    }
}