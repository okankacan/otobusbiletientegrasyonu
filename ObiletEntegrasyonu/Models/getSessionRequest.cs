using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObiletEntegrasyonu.Models
{
    public class getSessionRequest
    {
        public int type { get; set; }

        [JsonProperty("connection")]
        public connettionData connection { get; set; }
        [JsonProperty("browser")]
        public applicationData browser { get; set; }

    }

    public class connettionData
    {

        [JsonProperty("ip-address")]
        public string ipAddress { get; set; }


        [JsonProperty("port")]
        public string port { get; set; }
    }

    public class applicationData
    {
        [JsonProperty("version")]
        public string version { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
    }
}