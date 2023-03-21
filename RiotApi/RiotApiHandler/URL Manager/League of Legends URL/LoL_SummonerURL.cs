namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_SummonerURL : URL
    {
        public LoL_SummonerURL(string regionalRoutingValue, string paltaformRountingValue, string apikey) 
            : base(regionalRoutingValue, paltaformRountingValue, apikey)  
        { 
        
        }

        public string ByName(string summonerName) 
        {
            string endpoint = $"/lol/summoner/v4/summoners/by-name/{summonerName}";
            string query_paramenters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_paramenters;

            return url; 
        }
        public string ByPUUID(string puuid)
        {
            string endpoint = $"/lol/summoner/v4/summoners/by-puuid/{puuid}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameters;

            return url;
        }
        public string ByRsoPUUID(string rsopuuid)
        {
            string endpoint = $"/fulfillment/v1/summoners/by-puuid/{rsopuuid}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameters;

            return url;
        }

    }
}

