using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.TFT_URL;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.TFT_Requests
{
    public class TFT_LeagueRequests
    {

        public TFT_LeagueRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRountingValue, string apikey)
        {
            URL = new TFT_LeagueURL(regionalRoutingValue, platformRountingValue, apikey);
        }

        public LeagueEntryDTO GetSummonerLeague(string summonerId)
        { 
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.BySummonerId(summonerId));
            
            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            LeagueEntryDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<LeagueEntryDTO>(content);

            return responseObj;
        }

        private TFT_LeagueURL URL;
    }
}
