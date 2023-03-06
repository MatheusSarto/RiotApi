using RiotApi.DataStructures.LeagueOfLegends;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public List<ChampionMasteryDto> GetChampsMasteryBySummonerID(string region, string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();


            string url = $"{GetBaseUrl(region)}{GetChampionsMasteryBySummonerID(encryptedSummonerId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;            
        }

        public ChampionMasteryDto GetChampMasteryScoreBySummonerID(string region, string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetChmapionMasteryScoreBySummonerID(encryptedSummonerId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }

        public ChampionMasteryDto GetChampMasteryScoreBySummonerID(string region, string encryptedSummonerId, int championId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetChampionMasteryBySummonerID(encryptedSummonerId, championId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }
    }
}
