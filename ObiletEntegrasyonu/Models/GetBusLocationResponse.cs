using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObiletEntegrasyonu.Models
{
    public class GetBusLocationResponse
    {
        public string Status { get; set; }
        public List<GetBusLocation> data { get; set; }
    }

    public class GetBusLocation
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? rank { get; set; }
    }
}