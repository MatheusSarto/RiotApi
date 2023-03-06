using RiotApi.DataStructures.LeagueOfLegends;
using System;
using System.Runtime.InteropServices;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public List<string> GetMatchIdsByPUUID(string region, string puuid)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetMatchIdsByPUUID(puuid)}?api_key={API_KEY}";
            var uri = new Uri(url);
            
            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content);

            return responseObj;
        }

        public MatchDto GetMatchByID(string region, string matchId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetMatchByID(matchId)}?api_key={API_KEY}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            MatchDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchDto>(content);

            return responseObj;
        }

    }
}
