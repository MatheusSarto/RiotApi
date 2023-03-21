using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;
using RiotApi.RiotApiHandler.URL_Manager.TFT_URL;
using RiotApi.DataStructures.LeagueOfLegends;
using Microsoft.AspNetCore.Mvc.Routing;

namespace RiotApi.RiotApiHandler.Requesters.TFT_Requests
{
    public class TFT_StatusRequests
    {
        

        public TFT_StatusRequests(string regionalRoutingValue, string platformRountingValue, string apikey)
        {
            URL = new TFT_StatusURL(regionalRoutingValue, platformRountingValue, apikey);
        }

        public PlatformDataDto GetTFTStatus()
        { 
            HttpClient httpClient = new HttpClient();

            var uri = new Uri(URL.Status());

            var response = httpClient.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            PlatformDataDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<PlatformDataDto>(content);

            return responseObj;
        }

        private TFT_StatusURL URL;
    }
}
