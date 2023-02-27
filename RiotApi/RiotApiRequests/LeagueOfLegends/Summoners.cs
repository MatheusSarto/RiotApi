
using RiotApi.DataStructures;
using RiotApi.EndPoints;

namespace RiotApi.RiotApiRequests.LeagueOfLegends
{
    public class Summoners
    {
        public static SummonerDTO GetSummonerByName(string region, string summonerName)
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSummonerByName(summonerName)}?api_key={API_KEY.Get_API_KEY()}";
            Console.WriteLine(url);
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        public static SummonerDTO GetSummonerByPUUID(string region, string rsoPUUID)
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSummonerByPUUID(rsoPUUID)}?api_key={API_KEY.Get_API_KEY()}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }
    }
}
