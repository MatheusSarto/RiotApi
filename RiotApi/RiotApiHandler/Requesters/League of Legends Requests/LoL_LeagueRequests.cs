using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_LeagueRequests
    {
        public LoL_LeagueRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
        {
            URL = new LoL_LeagueURL(regionalRoutingValue, platformRoutingValue, apikey);
        }

        public List<LeagueEntryDTO> BySummoner(string encryptedSummonerId)
        { 
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.BySummoner(encryptedSummonerId));
            
            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<LeagueEntryDTO> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);

            return responseObj;
        }

        private LoL_LeagueURL URL;
    }
}
