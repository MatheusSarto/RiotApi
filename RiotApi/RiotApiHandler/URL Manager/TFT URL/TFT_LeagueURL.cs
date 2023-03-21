namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_LeagueURL : URL
    {
        public TFT_LeagueURL(string regionalRoutingValue, string platformRountingValue, string apikey) :
            base(regionalRoutingValue, platformRountingValue, apikey)
        { 
        
        }

        public string BySummonerId(string summonerId)
        {
            string endpoint = $"/tft/league/v1/entries/by-summoner/{summonerId}";
            string query_parameter = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameter;


            return url;
        }
    }
}
