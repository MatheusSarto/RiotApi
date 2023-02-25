
using Microsoft.AspNetCore.Mvc;
using RiotApi.DataStructures;
using RiotApi.EndPoints;

partial class Program
{
    private static void AddLoLSpectator(WebApplication app)
    {
        app.MapGet("/lol/spectator/by-summonerid/{region}&{encryptedSummonerId}",
        ([FromRoute] string region, [FromRoute] string encryptedSummonerId) =>
        {
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSpectator(encryptedSummonerId)}?api_key={API_KEY.Get_API_KEY}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            CurrentGameInfo responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentGameInfo>(content);

            return responseObj;
        });

        app.MapGet("/lol/match/v5/matches/{region}&{matchId}", 
        ([FromRoute] string region, [FromRoute] string matchId) => { 
            HttpClient client = new HttpClient();

            string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetMatchByID(matchId)}?api_key={API_KEY.Get_API_KEY}";
            var endpoint = new Uri(url);

            var result = client.GetAsync(endpoint).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            MatchDto responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchDto>(content);

            return responseObj;
        });
    }
}

