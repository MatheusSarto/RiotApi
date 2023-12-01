using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.TFT_URL;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.TFT_Requests
{
    public class TFT_SummonerRequests
    {
        public TFT_SummonerRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
        {
            URL = new TFT_SummonerURL(regionalRoutingValue, platformRoutingValue, apikey);
        }


        public SummonerDTO GetSummonerByName(string summonerName) 
        { 
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ByName(summonerName));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }
        public SummonerDTO GetSummonerByPUUID(string puuid)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ByPUUID(puuid));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        private TFT_SummonerURL URL;
    }
}
