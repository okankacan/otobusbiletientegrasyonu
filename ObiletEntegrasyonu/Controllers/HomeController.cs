using ObiletEntegrasyonu.Helper;
using ObiletEntegrasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ObiletEntegrasyonu.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string computerName = Dns.GetHostName();
            var model = new getSessionRequest();
            model.type = 1;
            model.connection = new connettionData { ipAddress = Dns.GetHostByName(computerName).AddressList[0].ToString(), port = "5117" };
            model.browser = new applicationData { name = "Chrome", version = "47.0.0.12" };
            var sessionGet = await ObiletService.GetSession(model);

            var getBusLocation = new GetBusLocationRequest
            {
                date = DateTime.UtcNow,
                getsessionData = sessionGet.data,
                language = "tr-TR"
            };

               var getBusLocations = await ObiletService.GetBusLocations(getBusLocation);
         
            return View(getBusLocations);
        }

        public async Task<ActionResult> Seferler(string originDestination, string depactureTime)
        {
            string computerName = Dns.GetHostName();
            var model = new getSessionRequest();
            model.type = 1;
            model.connection = new connettionData { ipAddress = Dns.GetHostByName(computerName).AddressList[0].ToString(), port = "5117" };
            model.browser = new applicationData { name = "Chrome", version = "47.0.0.12" };
            var sessionGet = await ObiletService.GetSession(model);
            var journey = new getbusjourneyRequest
            {
                getsessionData = sessionGet.data,
                language = "tr-TR",
                date = DateTime.UtcNow,
                data = new journeyData
                {
                    origin = int.Parse(originDestination.Split('-')[0].ToString()),
                    destination = int.Parse(originDestination.Split('-')[1].ToString()),
                    departure = DateTime.Parse(depactureTime)
                }

            };
            var journeyGet = await ObiletService.GetJourney(journey);
            return View(journeyGet);
        }
    }
}