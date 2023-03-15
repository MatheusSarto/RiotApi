namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class MatchURL : URL
    {
        public MatchURL(string regionalRoutingValue, string paltaformRountingValue, string apikey)
            : base(regionalRoutingValue, paltaformRountingValue, apikey)
        {

        }
        public string MatchIds(string puuid, long startTime, long endTime, 
            string queue,string type, int count, int start) 
        {
            string endpoint = $"/lol/match/v5/matches/by-puuid/{puuid}/ids";
            string query_parameters = @$"{GetApiKeyQuery}&startTime={startTime}&endTime={endTime}
&queue={queue}&type={type}&start={start}&count={count}";

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
