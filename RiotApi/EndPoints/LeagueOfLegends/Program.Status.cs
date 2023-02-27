
using Microsoft.AspNetCore.Mvc;

partial class Program
{
    /// <summary>
    /// Map all League Of Legends Status routes
    /// </summary>
    /// <param name="app"></param>
    private static void AddLoLStatus(WebApplication app)
    {
        app.MapGet("/lol/status/v4/platform-data/{region}", ([FromRoute] string region) => { 
            
        });
        
    }
}

