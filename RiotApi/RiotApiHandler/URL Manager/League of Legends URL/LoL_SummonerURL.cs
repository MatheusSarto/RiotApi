using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_SummonerURL : URL
    {
        public LoL_SummonerURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey) 
            : base(regionalRoutingValue, platformRoutingValue, apikey)  
        { 
        
        }

        public string ByName(string summonerName) 
        {
            string endpoint = $"/lol/summoner/v4/summoners/by-name/{summonerName}";
            string query_paramenters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_paramenters;
            Console.WriteLine($"Url: {url}");
            return url; 
        }
        public string ByPUUID(string puuid)
        {
            string endpoint = $"/lol/summoner/v4/summoners/by-puuid/{puuid}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url;
        }
        public string ByRsoPUUID(string rsopuuid)
        {
            string endpoint = $"/fulfillment/v1/summoners/by-puuid/{rsopuuid}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url;
        }

    }
}

