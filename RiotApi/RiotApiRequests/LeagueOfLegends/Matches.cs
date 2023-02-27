using RiotApi.DataStructures;
using RiotApi.EndPoints;
using System;
using System.Runtime.InteropServices;

namespace RiotApi.RiotApiRequests.LeagueOfLegends
{
    public static class Matches
    {
        public static List<string> GetMatchIdsByPUUID(string region, string puuid)
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetMatchIdsByPUUID(puuid)}?api_key={API_KEY.Get_API_KEY()}";
            var uri = new Uri(url);

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content);

            return responseObj;
        }

        public static MatchDto GetMatchByID(string region, string matchId)
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetMatchByID(matchId)}?api_key={API_KEY.Get_API_KEY()}";
            Console.Write("API KEY: " + API_KEY.Get_API_KEY());
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            MatchDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchDto>(content);

            return responseObj;
        }

    }
}
