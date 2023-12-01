using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;
using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_ChampioMasteryRequests
    {
        public LoL_ChampioMasteryRequests(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
        { 
            URL = new ChampionMasteryURL(regionalRoutingValue, platformRoutingValue, apikey); 
        }


        public List<ChampionMasteryDto> GetChampionMastery(string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.ChampionMastery(encryptedSummonerId));

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            List<ChampionMasteryDto> contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChampionMasteryDto>>(content);

            return contentObj;
        }
        public ChampionMasteryDto GetChampionMastery(string encryptedSummonerId, long? championId)
        {
            HttpClient client = new HttpClient();
            if (championId == null) { championId = 3; }

            var uri = new Uri(URL.ChampionMastery(encryptedSummonerId, championId.Value));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            ChampionMasteryDto contentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ChampionMasteryDto>(content);

            return contentObj;
        }

        public List<ChampionMasteryDto> GetChampionMasteryTop(string encryptedSummonerId, int? count)
        {
            HttpClient client = new HttpClient();

            if (count == null) { count = 3; }

            var uri = new Uri(URL.ChampionMasteryTop(encryptedSummonerId, count.Value));

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
