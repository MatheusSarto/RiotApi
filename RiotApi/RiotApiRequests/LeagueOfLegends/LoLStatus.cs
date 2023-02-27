using RiotApi.DataStructures;
using RiotApi.EndPoints;

namespace RiotApi.RiotApiRequests.LeagueOfLegends
{
    public class LoLStatus
    {
        public static PlatformDataDto GetLoLStatus(string region) 
        { 
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetLoLStatus()}?{API_KEY.Get_API_KEY()}";
            var uri = new Uri(url);

            var response = client.GetAsync(uri).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            PlatformDataDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<PlatformDataDto>(content);

            return responseObj;
        }
    }
}
