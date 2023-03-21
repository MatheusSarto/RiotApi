using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_SpectatorRequests
    {
        public LoL_SpectatorRequests(string regionalRoutingValue, string paltaformRountingValue, string apikey)
        {
            URL = new LoL_SpectatorURL(regionalRoutingValue, paltaformRountingValue, apikey);
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
