using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;


partial class Program
{
    // TO DO: WIN RATE CALC SYSTEM 


    /// <summary>
    /// Retrieve All League Of Legends Summoner Info
    /// </summary>
    /// <param name="app"></param>

    private static void AddLoLSummonerInfo(WebApplication app)
    {
        app.MapGet("/lol/{region}/summoner/summary/{summonername}",([FromRoute] string regional,
         [FromRoute] string plataform ,[FromRoute] string summonername) => {

            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(regional, plataform);

            SummonerDTO summonerData = loLAPI_Handler.Summoner.GetSummonerByName(summonername);

            List<string> matchIds = loLAPI_Handler.Match.GetMatchIds(summonerData.PUUID);
            List<MatchDto> matches = loLAPI_Handler.Match.GetMatchesByID(matchIds);

             float winRate = 0;
             int magicDamageChampions = 0;
             int physicalDamageChampions = 0;
             int totalDeaths = 0;
             int totalKills = 0;
             int totalAssits = 0;
             float bestKDA = 0;
             float worstKDA = 10000;
             int redTeamWins = 0;
             Dictionary<string, int> championsWin= new Dictionary<string, int>();
             
             matches.ForEach((match) => {
                ParticipantDto playerMatchData = match.Info.Participants.Find(x => x.SummonerName == summonername);

                 
                 
                 magicDamageChampions = (playerMatchData.MagicDamageDealtToChampions > magicDamageChampions) ? playerMatchData.MagicDamageDealtToChampions : magicDamageChampions;
                 physicalDamageChampions = (playerMatchData.PhysicalDamageDealtToChampions > physicalDamageChampions) ? playerMatchData.PhysicalDamageDealtToChampions : physicalDamageChampions;

                 totalKills += playerMatchData.Kills;
                 totalDeaths += playerMatchData.Deaths;
                 totalAssits += playerMatchData.Assists;

                 float currentKDA = (playerMatchData.Kills + playerMatchData.Assists) / playerMatchData.Deaths;
                 bestKDA = (currentKDA > bestKDA) ? currentKDA : bestKDA;
                 worstKDA = (currentKDA < worstKDA) ? currentKDA : worstKDA;

                 redTeamWins = (playerMatchData.TeamId == 100) ? redTeamWins++ : redTeamWins;

                 if (championsWin.ContainsKey(playerMatchData.ChampionName))
                 {
                     championsWin[playerMatchData.ChampionName] = championsWin[playerMatchData.ChampionName]++;
                 }
                 else 
                 {
                     championsWin.Add(playerMatchData.ChampionName, 1);
                 }
             });

             float totalKDA = (totalKills + totalAssits) / totalDeaths;

             List<ChampionMasteryDto> topMasteries = loLAPI_Handler.ChampionMastery.GetChampionMasteryTop(summonerData.Id, 3);

             return JsonConvert.SerializeObject(
                 new { 
                    summonername = summonername,
                    summonerlvl = summonerData.SummonerLevel,
                    summonericonid = summonerData.ProfileIconId,

                    bestkda = bestKDA,
                    worstkda = worstKDA,
                    totalkda = totalKDA,

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

