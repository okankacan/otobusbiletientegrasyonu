
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ObiletEntegrasyonu.Models
{
    public class getSessionResponse
    {
        public string status { get; set; }

        [JsonProperty("data")]
        public getsessionData data { get; set; }

        public string message { get; set; }
        [JsonProperty("user-message")]

        public string userMessage { get; set; }
        [JsonProperty("api-request-id")]
        public string apiRequestId { get; set; }
        public string controller { get; set; }
    }
    public class getsessionData
    {
        [JsonProperty("session-id")]

        public string sessionId { get; set; }
        [JsonProperty("device-id")]

        public string deviceId { get; set; }
    }
}