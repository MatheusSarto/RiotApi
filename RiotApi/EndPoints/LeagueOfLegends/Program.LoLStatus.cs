using Microsoft.AspNetCore.Mvc;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;
partial class Program
{
    /// <summary>
    /// Retrieve League Of Legends Current State
    /// </summary>
    /// <param name="app"></param>
    private static void AddLoLStatus(WebApplication app) 
    {

        app.MapGet("/lol/status", 
        ([FromRoute] string plataform)  => {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(plataform);

            PlatformDataDto status = loLAPI_Handler.GetLoLStatus();
            return status;
        });
    }
}

