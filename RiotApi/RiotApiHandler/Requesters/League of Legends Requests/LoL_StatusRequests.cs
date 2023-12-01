using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;
using RiotApi.DataStructures.LeagueOfLegends;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_StatusRequests
    {
        public LoL_StatusRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
        {
            URL = new LoL_StatusURL(regionalRoutingValue, platformRoutingValue, apikey);
        }

        public string GetLoLStatus()
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.Status());

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            PlatformDataDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<PlatformDataDto>(content);

            return content;
        }
        
        private LoL_StatusURL URL;
    }
}
