using RiotApi.DataStructures.LeagueOfLegends;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public SummonerDTO GetSummonerByName(string region, string summonerName)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetSummonerByName(summonerName)}?api_key={API_KEY}";
            Console.WriteLine(url);
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        public SummonerDTO GetSummonerByPUUID(string region, string rsoPUUID)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetSummonerByPUUID(rsoPUUID)}?api_key={API_KEY}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }
    }
}
