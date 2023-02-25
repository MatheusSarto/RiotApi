
using Microsoft.AspNetCore.Mvc;
using RiotApi.EndPoints;

partial class Program
{
    private static void AddLoLWatch(WebApplication app) 
    {
        app.MapGet("lol/match/matches/by-puuid/{region}&{puuid}", 
            ([FromRoute] string region, [FromRoute] string puuid)  => { 
                HttpClient client = new HttpClient();

                string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetMatchIdByPUUID(puuid)}?api_key={API_KEY.Get_API_KEY}";
                var uri = new Uri(url);

                var result = client.GetAsync(uri).Result;
                var content = result.Content.ReadAsStringAsync().Result;

                List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content);

                return responseObj;
            });
    }
}

