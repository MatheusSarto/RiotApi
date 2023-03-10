using RiotApi.DataStructures.LeagueOfLegends;

namespace RiotApi.RiotApiRequests
{
    public partial class LoLAPI_Handler
    {
        public PlatformDataDto GetLoLStatus() 
        { 
            HttpClient client = new HttpClient();

            string url = $"{GetBaseUrl(PlatformRoutingValue)}{GetLoLStatus()}?{API_KEY}";
            var uri = new Uri(url);

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            PlatformDataDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<PlatformDataDto>(content);

            return responseObj;
        }
    }
}
