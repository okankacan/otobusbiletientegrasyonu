using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObiletEntegrasyonu.Models
{
    public class GetBusLocationRequest
    {
        [JsonProperty("device-session")]
        public getsessionData getsessionData { get; set; }
        public DateTime date { get; set; }
        public string language { get; set; }
    }
}