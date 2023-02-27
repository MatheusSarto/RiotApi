
using Microsoft.AspNetCore.Mvc;
using RiotApi.DataStructures;
using RiotApi.EndPoints;

partial class Program
{
    /// <summary>
    /// Map all League Of Legends Spectator routes
    /// </summary>
    /// <param name="app"></param>
    private static void AddLoLSpectator(WebApplication app)
    {
        app.MapGet("/lol/spectator/by-summonerid/{region}&{encryptedSummonerId}",
        ([FromRoute] string region, [FromRoute] string encryptedSummonerId) =>
        {

        });
    }
}

