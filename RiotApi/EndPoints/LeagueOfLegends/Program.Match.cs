
using Microsoft.AspNetCore.Mvc;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;
partial class Program
{
    /// <summary>
    /// Map all League Of Legends history data
    /// </summary>
    /// <param name="app"></param>
    private static void AddLoLWatch(WebApplication app) 
    {

        app.MapGet("/lol/match/match-history/{region}&{puuid}/ids", 
        ([FromRoute] string region, [FromRoute] string puuid)  => {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler();

            List<string> matchIds = loLAPI_Handler.GetMatchIdsByPUUID(region, puuid);

            return matchIds;
        });

        app.MapGet("/lol/match/playerData/{region}&{puuid}",
       ([FromRoute] string region, [FromRoute] string puuid) => {

       });
    }
}

