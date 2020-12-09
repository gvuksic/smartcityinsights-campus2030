using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campus2030
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Properties
    {
    }

    public class Item
    {
        public Geometry geometry { get; set; }
        [JsonProperty("count-cars")]
        public string CountCars { get; set; }
        [JsonProperty("count-pedestrians")]
        public string CountPedestrians { get; set; }
        [JsonProperty("count-bicycles")]
        public string CountBicycles { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Root
    {
        public List<Item> items { get; set; }
    }


}
