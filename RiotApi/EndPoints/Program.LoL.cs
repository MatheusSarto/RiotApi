using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RiotApi.DataStructures;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiRequests;
using System.Security.Cryptography.X509Certificates;
using static Program;

partial class Program
{
    public class JsonRequest<T> where T : BaseJsonRequest
    {
        public T Json { get; set; }
    }

    /**
    * @brief  Retrieve All League Of Legends Summoner Info.
    *\class SummonerSummaryJson
    *\file SummonerSummaryJson.cs
    *\date 27/03/2023
    */
    private static void AddLolEndPoints(WebApplication app) 
    {

        // TODO KDA Médio.
        // TODO Tratamento de erros.


        // Get Ranked Info
        app.MapGet("/lol/summoner/rank/{summonername}", ([FromRoute] string summonername, [FromBody] BaseJsonRequest requestJson) =>
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<LeagueEntryDTO> leagueData =  loLAPI_Handler.GetLeague().BySummoner(summonerData.PUUID);

            var filterList = leagueData.Select(i => new { i.QueueType, i.Tier, i.Rank, i.LeaguePoints, i.Wins, i.Losses}).ToArray();
            string jsonString = JsonConvert.SerializeObject(filterList, Formatting.Indented);

            return jsonString;
        });


        // Get All Matches Info
        app.MapGet("/lol/summoner/matches/{summonername}", ([FromRoute] string summonername, [FromBody] MatchIdsJson requestJson) =>
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<String> matchIds = loLAPI_Handler.GetMatch().GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);

            List<MatchDto> matchesData = loLAPI_Handler.GetMatch().GetMatchesByID(matchIds);
            string jsonString = JsonConvert.SerializeObject(matchesData, Formatting.Indented);

            return jsonString;
        });


        // Get Time Spend in league of legends Matches
        app.MapGet("/lol/summoner/matches/{summonername}", ([FromRoute] string summonername, [FromBody] MatchIdsJson requestJson) =>
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<String> matchIds = loLAPI_Handler.GetMatch().GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);

            List<MatchDto> matchesData = loLAPI_Handler.GetMatch().GetMatchesByID(matchIds);
            double totalTimePlayed = matchesData.Sum(i => i.Info.GameDuration) / 1000.0;

            string jsonString = JsonConvert.SerializeObject(totalTimePlayed, Formatting.Indented);

            return jsonString;
        });


        // Get Most Played Player
        app.MapGet("/lol/summoner/matches/{summonername}", ([FromRoute] string summonername, [FromBody] MatchIdsJson requestJson) =>
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<String> matchIds = loLAPI_Handler.GetMatch().GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);

            List<MatchDto> matchesData = loLAPI_Handler.GetMatch().GetMatchesByID(matchIds);

            List<ParticipantDto> participants = new List<ParticipantDto>();
            matchesData.ForEach(match => {
                match.Info.Participants.ForEach(participant => {
                    if(participant.SummonerName != summonername)
                        participants.Add(participant);
                });
            });

            ParticipantDto? participant = getMostRepeatedElement<ParticipantDto>(participants);

            string jsonString = JsonConvert.SerializeObject(participant, Formatting.Indented);

            return jsonString;
        });


        // Get Player WinRate
        app.MapGet("/lol/summoner/matches/{summonername}", ([FromRoute] string summonername, [FromBody] MatchIdsJson requestJson) =>
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);

            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<String> matchIds = loLAPI_Handler.GetMatch().GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);

            List<MatchDto> matchesData = loLAPI_Handler.GetMatch().GetMatchesByID(matchIds);

            List<ParticipantDto> participants = new List<ParticipantDto>();
            matchesData.ForEach(match => {
                match.Info.Participants.ForEach(participant => {
                    if (participant.SummonerName == summonername)
                        participants.Add(participant);
                });
            });

            int wins = participants.Where(x => x.Win == true).Count();
            int losses = participants.Count() - wins;

            double winRate = participants.Count() / wins;

            string jsonString = JsonConvert.SerializeObject(new { Wins = wins, Losses = losses, WinRate = winRate }, Formatting.Indented);

            return jsonString;
        });

        // Get Most Played Role
        app.MapGet("/lol/summoner/matches/{summonername}", ([FromRoute] string summonername, [FromBody] MatchIdsJson requestJson) => 
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestJson);
            
            SummonerDTO summonerData = loLAPI_Handler.GetSummoner().GetSummonerByName(summonername);
            List<String> matchIds = loLAPI_Handler.GetMatch().GetMatchIds(summonerData.PUUID, requestJson.MatchIdSpecifications);

            List<MatchDto> matchesData = loLAPI_Handler.GetMatch().GetMatchesByID(matchIds);

            List<string> participants = new List<string>();
            matchesData.ForEach(match => {
                match.Info.Participants.ForEach(participant => {
                    if (participant.SummonerName == summonername)
                        participants.Add(participant.Role);
                });
            });

            var role = getMostRepeatedElement<string>(participants);

            string jsonString = JsonConvert.SerializeObject(role, Formatting.Indented);

            return jsonString;

        });

        // Get LoL Status
        app.MapGet("/lol/status",
        ([FromBody] BaseJsonRequest requestData) => 
        {
            LoLAPI_Handler loLAPI_Handler = new LoLAPI_Handler(requestData);

            var status = loLAPI_Handler.GetStatus().GetLoLStatus();
            return status;
        });
        

        T getMostRepeatedElement<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty");
            }

            T? element = list
              .GroupBy(element => element)
              .OrderByDescending(group => group.Count())
              .Select(group => group.Key)
              .FirstOrDefault();

            if (element == null)
            {
                throw new ArgumentNullException("Element can't be null");
            }

            return element;
        }

    }

}



