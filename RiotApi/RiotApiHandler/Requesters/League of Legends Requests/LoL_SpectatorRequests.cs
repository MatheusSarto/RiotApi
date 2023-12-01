using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_SpectatorRequests
    {
        public LoL_SpectatorRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
        {
            URL = new LoL_SpectatorURL(regionalRoutingValue, platformRoutingValue, apikey);
        }

        public CurrentGameInfo GetSpectator(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            var endpoint = new Uri(URL.Spectator(encryptedSummonerId));

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            CurrentGameInfo responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentGameInfo>(content);

            return responseObj;
        }

        private LoL_SpectatorURL URL;
    }
}
