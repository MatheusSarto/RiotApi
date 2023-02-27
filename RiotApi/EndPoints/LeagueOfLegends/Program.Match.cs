
using Microsoft.AspNetCore.Mvc;
using RiotApi.RiotApiRequests.LeagueOfLegends;
partial class Program
{
    /// <summary>
    /// Map all League Of Legends Watch routes
    /// </summary>
    /// <param name="app"></param>
    private static void AddLoLWatch(WebApplication app) 
    {
        // Get List of match id's - strings
        app.MapGet("/lol/match/v5/matches/by-puuid/{region}&{puuid}", 
            ([FromRoute] string region, [FromRoute] string puuid)  => { 
                
            });

        app.MapGet("/lol/match/v5/matches/{region}&{matchid}",
            ([FromRoute] string region, [FromRoute] string matchid) => {
                var response = Matches.GetMatchByID(region, matchid);
                return response;
            });
    }
}

