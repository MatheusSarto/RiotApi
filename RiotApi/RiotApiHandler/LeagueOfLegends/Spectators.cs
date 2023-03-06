using RiotApi.DataStructures.LeagueOfLegends;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public CurrentGameInfo GetSpectator(string region, string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(region)}{GetSpectator(encryptedSummonerId)}?api_key={API_KEY}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            CurrentGameInfo responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentGameInfo>(content);

            return responseObj;
        }

    }
}
