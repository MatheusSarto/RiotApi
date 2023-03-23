using RiotApi.DataStructures;

namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_MatchURL : URL
    {
        public LoL_MatchURL(string regionalRoutingValue, string platformRountingValue, string apikey)
            : base(regionalRoutingValue, platformRountingValue, apikey)
        {

        }
        public string MatchIDs(string puuid, Specifications_MatchIds specifications) 
        {
            string endpoint = $"/lol/match/v5/matches/by-puuid/{puuid}/ids";

            string query_parameters = $"{GetApiKeyQuery}&start={specifications.Start}&count={specifications.Count}";
            if (specifications.StartTime != -1) { query_parameters += $"&startTime ={specifications.StartTime}"; }
            if (specifications.EndTime != -1) { query_parameters += $" &endTime={specifications.EndTime};"; }
            if (specifications.Queue != -1) { query_parameters += $"&queue={specifications.Queue}"; }
            if (specifications.Type != String.Empty) { query_parameters += $"&type={specifications.Type}"; }
         

            string url = GetBaseUrl(GetRegionalRoutingValue()) + endpoint + query_parameters;
            
            return url; 
        }
        public string MatchByID(string matchId)
        {
            string endpoint = $"/lol/match/v5/matches/{matchId}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetRegionalRoutingValue()) + endpoint + query_parameters;

            return url; 
        }
    }
}
