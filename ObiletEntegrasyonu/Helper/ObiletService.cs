using Newtonsoft.Json;
using ObiletEntegrasyonu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ObiletEntegrasyonu.Helper
{
    public class ObiletService
    {
        public static async Task<getSessionResponse> GetSession(getSessionRequest model)
        {
            var responseResult = new getSessionResponse();
            using (var _httpClient = new HttpClient())
            {

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic ZEdocGMybHpZV0p5WVc1a2JtVjNZbWx1");
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                string responseContent = null;
                var request = await _httpClient.PostAsync("https://v2-api.obilet.com/api/client/getsession", httpContent);
                responseContent = await request.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<getSessionResponse>(responseContent);
            }
            return responseResult;
        }

        public static async Task<GetBusLocationResponse> GetBusLocations(GetBusLocationRequest model)
        {
            var responseResult = new GetBusLocationResponse();
            using (var _httpClient = new HttpClient())
            {

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic ZEdocGMybHpZV0p5WVc1a2JtVjNZbWx1");
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                string responseContent = null;
                var request = await _httpClient.PostAsync("https://v2-api.obilet.com/api/location/getbuslocations", httpContent);
                responseContent = await request.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<GetBusLocationResponse>(responseContent);
            }
            return responseResult;
        }
            public static async Task<getbusjourneyResponse> GetJourney(getbusjourneyRequest model)
            {
                var responseResult = new getbusjourneyResponse();
                using (var _httpClient = new HttpClient())
                {

                    _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic ZEdocGMybHpZV0p5WVc1a2JtVjNZbWx1");
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                    string responseContent = null;
                    var request = await _httpClient.PostAsync("https://v2-api.obilet.com/api/journey/getbusjourneys", httpContent);
                    responseContent = await request.Content.ReadAsStringAsync();
                    responseResult = JsonConvert.DeserializeObject<getbusjourneyResponse>(responseContent);


                }
                return responseResult;
            }
        }
    }