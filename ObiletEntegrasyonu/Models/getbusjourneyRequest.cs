using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObiletEntegrasyonu.Models
{
    public class getbusjourneyRequest
    {
        [JsonProperty("device-session")]
        public getsessionData getsessionData { get; set; }
        [JsonProperty("date")]
        public DateTime date { get; set; }

        public string language { get; set; }
        [JsonProperty("data")]
        public journeyData data { get; set; }
    }

    public class journeyData
    {
        [JsonProperty("origin-id")]
        public int origin { get; set; }

        [JsonProperty("destination-id")]
        public int destination { get; set; }

        [JsonProperty("departure-date")]
        public DateTime departure { get; set; }
    }
}