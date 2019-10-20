using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObiletEntegrasyonu.Models
{
    public class getbusjourneyResponse
    {
        public string status { get; set; }

        public List<busJourneyResponse> data { get; set; }

    }

    public class busJourneyResponse
    {
        public int id { get; set; }
        [JsonProperty("partner-id")]
        public int patnerId { get; set; }
        [JsonProperty("partner-name")]
        public string patnerName { get; set; }
        [JsonProperty("route-id")]

        public int routeId { get; set; }

        [JsonProperty("bus-type")]
        public string busType { get; set; }

         public journey journey { get; set; }

        [JsonProperty("origin-location")]
        public string originLocation { get; set; }

        [JsonProperty("destination-location")]
        public string destinationLocation { get; set; }
        [JsonProperty("origin-location-id")]
        public string originLocationId { get; set; }
        [JsonProperty("destination-location-id")]
        public string destinationLocationId { get; set; }

    }

    public class journey
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime? departure { get; set; }
        public DateTime? arrival { get; set; }

        public string currency { get; set; }
        [JsonProperty("original-price")]

        public double? orginalPrice { get; set; }
        [JsonProperty("internet-price")]
        public double? internetPrice { get; set; }
       
    }

}