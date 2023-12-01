using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_MatchURL : URL
    {
        public TFT_MatchURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRountingValue, string apikey) : 
            base(regionalRoutingValue, platformRountingValue, apikey)
        {


        }

        public string MatchIDs(string puuid, int start, long endTime, long startTime, int count)
        {
            string endpoint = $"/tft/match/v1/matches/by-puuid/{puuid}/ids";
            string query_parameters = $"{GetApiKeyQuery}&start={start}&count={count}";
            if (startTime != -1) { query_parameters += $"&startTime ={startTime}"; }
            if (endTime != -1) { query_parameters += $" &endTime={endTime};"; }

            string url = GetBaseUrl(GetRegionalRoutingValue()) + endpoint + query_parameters;

            return url;
        }

        public string MatchByID(string matchId)
        {
            string endpoint = $"/tft/match/v1/matches/{matchId}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetRegionalRoutingValue()) + endpoint + query_parameters;

            return url;
        }
    }
}
