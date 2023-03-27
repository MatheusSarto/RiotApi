namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_SummonerURL : URL
    {
        public TFT_SummonerURL(string regionalRoutingValue, string platformRountingValue, string apikey) : 
            base(regionalRoutingValue, platformRountingValue, apikey)
        { 
        
        }

        public string ByName(string summonerName)
        { 
            string endpoint = $"/tft/summoner/v1/summoners/by-name/{summonerName}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url;
        }

        public string ByPUUID(string encryptedPUUID)
        {
            string endpoint = $"/tft/summoner/v1/summoners/by-puuid/{encryptedPUUID}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) +endpoint + query_parameters;

            return url;
        }
    }
}
