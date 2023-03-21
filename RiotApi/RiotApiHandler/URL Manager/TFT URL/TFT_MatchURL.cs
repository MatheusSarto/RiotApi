namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_MatchURL : URL
    {
        public TFT_MatchURL(string regionalRoutingValue, string platformRountingValue, string apikey) : 
            base(platformRountingValue, regionalRoutingValue, apikey)
        {


        }

        public string MatchIDs(string puuid, int start, long endTime, long startTime, int count)
        {
            string endpoint = $"/tft/match/v1/matches/by-puuid/{puuid}/ids";
            string query_parameters = $"{GetApiKeyQuery}&start={start}&endTime={endTime}&startTime={startTime}&count={count}";

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
