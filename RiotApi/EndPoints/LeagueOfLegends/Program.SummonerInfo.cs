﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RiotApi.DataStructures;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;


partial class Program
{
    /**
    * @brief  Retrieve All League Of Legends Summoner Info.
    *\class SummonerSummaryJson
    *\file SummonerSummaryJson.cs
    *\date 27/03/2023
    */
    private static void AddLoLSummonerInfo(WebApplication app) 
    {
        /**< Detailed Enpoint Responsible For Returning a Custom Summoner Summary to The Client */
        app.MapGet("/lol/summoner/summary/{summonername}"
        , ([FromRoute] string summonername, [FromBody] SummonerSummaryJson requestJson) => {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.Summoner.GetSummonerByName(summonername);

            List<string> matchIds = loLAPI_Handler.Match.GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);
            List<MatchDto> matches = loLAPI_Handler.Match.GetMatchesByID(matchIds);

            List<ChampionMasteryDto> topMasteries = loLAPI_Handler.ChampionMastery.GetChampionMasteryTop(summonerData.Id, 3);

            LeagueEntryDTO rankedInfo = loLAPI_Handler.League.BySummoner(summonerData.PUUID);

            float winRate = 0;
            float redTeamWinRate = 0;
            float blueTeamWinRate = 0;
            int wins = 0;
            int redTeamWins = 0;
            int blueTeamWins = 0;
            
            int totalDeaths = 0;
            int totalKills = 0;
            int totalAssits = 0;

            double avarageKDA = 0;
            double bestKDA = 0;
            double worstKDA = 10000;

            string matchQueue = "";

            List<ChampionWins> chmapionsWins = new List<ChampionWins>();
   
             matches.ForEach((match) => {
                ParticipantDto playerMatchData = match.Info.Participants.Find(x => x.SummonerName == summonername);
            
                 totalKills += playerMatchData.Kills;
                 totalDeaths += playerMatchData.Deaths;
                 totalAssits += playerMatchData.Assists;

                 float currentKDA = (playerMatchData.Deaths == 0) ? (playerMatchData.Kills + playerMatchData.Assists) : (playerMatchData.Kills + playerMatchData.Assists) / playerMatchData.Deaths;
                 bestKDA = (currentKDA > bestKDA) ? currentKDA : bestKDA;
                 worstKDA = (currentKDA < worstKDA) ? currentKDA : worstKDA;

                 if (chmapionsWins.Any(x => x.ChampionName == playerMatchData.ChampionName) == false)
                 {
                     chmapionsWins.Add(new ChampionWins { ChampionName = playerMatchData.ChampionName, Wins = 0 });
                 }

                 if (playerMatchData.Win == true)
                 {
                     int index = chmapionsWins.FindIndex(x => String.Equals(x.ChampionName, playerMatchData.ChampionName));
                     chmapionsWins[index].Wins++;

                     if (playerMatchData.TeamId == 100) { redTeamWins = redTeamWins + 1; }
                     else { blueTeamWins = blueTeamWins + 1; }
                 }
             });

            avarageKDA = (totalKills + totalAssits) / totalDeaths;

            winRate = (redTeamWins + blueTeamWins) / requestJson.MatchIdSpecifications.Count;
            redTeamWinRate = (redTeamWins / (redTeamWins + blueTeamWins) * 100);
            blueTeamWinRate = (blueTeamWins / (redTeamWins + blueTeamWins) * 100);

            if (requestJson.MatchIdSpecifications.Queue == 420) { matchQueue = "RANKED_SOLO_5v5"; }
            else if (requestJson.MatchIdSpecifications.Queue == 440) { matchQueue = "RANKED_FLEX_SR"; }
            else { matchQueue = "NON SPECIFIED"; }


            return JsonConvert.SerializeObject(
                new {
                    summonername = summonername,
                    summonerlvl = summonerData.SummonerLevel,
                    summonericonid = summonerData.ProfileIconId,

                    rank = rankedInfo.Rank,
                    leaguePoint = rankedInfo.LeaguePoints,
                    veteran = rankedInfo.Veteran,
                    freshBlood = rankedInfo.FreshBlood,
                    inactive = rankedInfo.Inactive,

                    queue = matchQueue,

                    bestkda = bestKDA,
                    worstkda = worstKDA,
                    totalkda = avarageKDA,

                    totalWinRate = winRate,
                    redTeamWinRate = redTeamWinRate,
                    blueTeamWinsRate = blueTeamWinRate,

                    totalWins = wins,
                    totalRedTeamWins = redTeamWins,
                    totalBlueTeamWins = blueTeamWins,

                    championsWinRate = chmapionsWins,

                    top1mastery = new {
                       chestgranted = topMasteries[0].ChestGranted,
                       championlvl = topMasteries[0].ChampionLevel,
                       championid = topMasteries[0].ChampionId
                    },
                    top2mastery = new
                    {
                       chestgranted = topMasteries[1].ChestGranted,
                       championlvl = topMasteries[1].ChampionLevel,
                       championid = topMasteries[1].ChampionId
                    },
                    top3mastery = new
                    {
                       chestgranted = topMasteries[2].ChestGranted,
                       championlvl = topMasteries[2].ChampionLevel,
                       championid = topMasteries[2].ChampionId
                    },

                });
        });
    }
}



