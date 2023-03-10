using RiotApi.DataStructures.LeagueOfLegends;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public List<ChampionMasteryDto> GetChampsMastery(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();


            string url = $"{GetBaseUrl(PlatformRoutingValue)}{ChampionsMasteryUrl(encryptedSummonerId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;            
        }

        public List<ChampionMasteryDto> GetChampsMasteryTop(string encryptedSummonerId, int count)
        {
            HttpClient client = new HttpClient();


            string url = $"{GetBaseUrl(PlatformRoutingValue)}{ChampionsMasteryTopUrl(encryptedSummonerId)}?api_key={API_KEY}&count={count}";
            var uri = new Uri(url);

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;
        }

        public ChampionMasteryDto GetChampMasteryScore(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(PlatformRoutingValue)}{ChmapionMasteryScoreUrl(encryptedSummonerId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }



        public ChampionMasteryDto GetChampMastery(string encryptedSummonerId, int championId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(PlatformRoutingValue)}{ChampionMasteryUrl(encryptedSummonerId, championId)}?api_key={API_KEY}";
            var uri = new Uri(url);

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }
    }
}
