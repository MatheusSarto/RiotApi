using Microsoft.AspNetCore.Mvc;
using RiotApi.DataStructures;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;
partial class Program
{
    /**
    * @brief  RRetrieve League Of Legends State Related Data
    *\class SummonerSummaryJson
    *\file SummonerSummaryJson.cs
    *\date 27/03/2023
    */
    private static void AddLoLStatus(WebApplication app) 
    {
        /**< Detailed Retrieve League Of Legends Current State */
        app.MapGet("/lol/status", 
        ([FromBody]BaseJsonRequest requestData)  => {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestData);

            //PlatformDataDto
            var status = loLAPI_Handler.Status.GetLoLStatus();
            return status;
        });
    }
}

