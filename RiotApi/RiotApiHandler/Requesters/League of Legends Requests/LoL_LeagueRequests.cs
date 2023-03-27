using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_LeagueRequests
    {
        public LoL_LeagueRequests(string regionalRoutingValue, string platformRoutingValue, string apikey)
        {
            URL = new LoL_LeagueURL(regionalRoutingValue, platformRoutingValue, apikey);
        }

        public LeagueEntryDTO BySummoner(string encryptedSummonerId)
        { 
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.BySummoner(encryptedSummonerId));
            
            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            LeagueEntryDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<LeagueEntryDTO>(content);

            return responseObj;
        }

        private LoL_LeagueURL URL;
    }
}
