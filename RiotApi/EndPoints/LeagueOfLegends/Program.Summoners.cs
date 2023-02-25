using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using RiotApi.EndPoints;
using RiotApi.DataStructures;
using System.Runtime.InteropServices;

partial class Program
{
    /// <summary>
    /// Map all League Of Legends users routes
    /// </summary>
    /// <param name="app"></param>
  

    private static void AddLoLSummoners(WebApplication app)
    {
        // SUMMONER-V4

        app.MapGet("/lol/summoners/by-name/{region}&{summonerName}",
            ([FromRoute] string region, [FromRoute] string summonerName) => {
                HttpClient client = new HttpClient();

                string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSummonerByName(summonerName)}?api_key={API_KEY.Get_API_KEY}";
                var endpoint = new Uri(url);

                var result = client.GetAsync(endpoint).Result;
                var content = result.Content.ReadAsStringAsync().Result;

                SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

                return responseObj;
            });


        app.MapGet("/lol/summoners/by-puuid/{region}&{rsoPUUID}", 
            ([FromRoute] string region,[FromRoute] string rsoPUUID) => {
                HttpClient client = new HttpClient();

                string url = $"{ApiUrls.GetBaseUrl(region)}{ApiUrls.GetSummonerByPUUID(rsoPUUID)}?api_key={API_KEY.Get_API_KEY}";
                var endpoint = new Uri(url);

                var result = client.GetAsync(endpoint).Result;
                var content = result.Content.ReadAsStringAsync().Result;

                SummonerDTO responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SummonerDTO>(content);

                return responseObj;
            });
    }   
       
}

