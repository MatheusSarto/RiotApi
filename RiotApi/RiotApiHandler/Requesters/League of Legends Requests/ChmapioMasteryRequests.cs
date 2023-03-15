using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class ChmapioMasteryRequests
    {
        public List<ChampionMasteryDto> GetChampionMastery(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ChampionMastery(encryptedSummonerId));

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;
        }
        public ChampionMasteryDto GetChampionMastery(string encryptedSummonerId, int championId)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ChampionMastery(encryptedSummonerId, championId));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }

        public List<ChampionMasteryDto> GetChampionMasteryTop(string encryptedSummonerId, int count)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ChampionMasteryTop(encryptedSummonerId, count));

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;
        }

        public ChampionMasteryDto GetChampionMasteryScore(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ChampionMasteryScore(encryptedSummonerId));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }

        private ChampionMasteryURL URL;
    }
}
