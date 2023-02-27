using RiotApi.DataStructures;
using RiotApi.EndPoints;

namespace RiotApi.RiotApiRequests.LeagueOfLegends
{
    public class Spectators
    {
        public static CurrentGameInfo GetSpectator(string region, string encryptedSummonerId)
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSpectator(encryptedSummonerId)}?api_key={API_KEY.Get_API_KEY()}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            CurrentGameInfo responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentGameInfo>(content);

            return responseObj;
        }

    }
}
