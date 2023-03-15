using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class SummonerRequests
    {
        public SummonerDTO GetSummonerByName(string summonerName)
        {
            HttpClient client = new HttpClient();

            var endpoint = new Uri(URL.ByName(summonerName));

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        public SummonerDTO GetSummonerByRsoPUUID(string rsopuuid) 
        {
            HttpClient client = new HttpClient();

            var endpoint = new Uri(URL.ByRsoPUUID(rsopuuid));

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        public SummonerDTO GetSummonerByPUUID(string encryptedPUUID)
        {
            HttpClient client = new HttpClient();

            var endpoint = new Uri(URL.ByPUUID(encryptedPUUID));

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

            return responseObj;
        }

        private SummonerURL URL;
    }
}
