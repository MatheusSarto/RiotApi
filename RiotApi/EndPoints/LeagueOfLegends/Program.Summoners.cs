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
                
            });


        app.MapGet("/lol/summoners/by-puuid/{region}&{rsoPUUID}", 
            ([FromRoute] string region,[FromRoute] string rsoPUUID) => {
               
            });
    }   
       
}

