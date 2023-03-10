using RiotApi.DataStructures.LeagueOfLegends;
using System;
using System.Runtime.InteropServices;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public List<string> GetMatchIdsByPUUID(string puuid)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(RegionalRoutingValue)}{GetMatchIdsByPUUID(puuid)}?api_key={API_KEY}";
            var uri = new Uri(url);
            
            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content);

            return responseObj;
        }

        public List<MatchDto> GetMatchesByID(List<string> matchIds)
        {
            HttpClient client = new HttpClient();
            List<MatchDto> matches = new List<MatchDto>();

            matchIds.ForEach((matchId) => {
                string url = $"{GetBaseUrl(RegionalRoutingValue)}{MatchByID_Url(matchId)}?api_key={API_KEY}";
                var endpoint = new Uri(url);

                var result = client.GetAsync(endpoint).Result;
                var content = result.Content.ReadAsStringAsync().Result;

                MatchDto match = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchDto>(content);
                matches.Add(match);
            });

            return matches;
        }

    }
}
