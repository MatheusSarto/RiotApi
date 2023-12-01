using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class ChampionMasteryURL : URL
    {
        public ChampionMasteryURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
            : base(regionalRoutingValue, platformRoutingValue, apikey)
        {

        }


        public string ChampionMastery(string encryptedSummonerId) 
        {
            string endpoint = $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;
            
            return url;
        }
        public string ChampionMastery(string encryptedSummonerId, long championId) 
        {
            string endpoint = $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}";
            string query_parameters = $"{GetApiKeyQuery()}";
            
            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url; 
        }
        public string ChampionMasteryTop(string encryptedSummonerId, int count) 
        {
            string endpoint = $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/top";
            string query_parameters = $"{GetApiKeyQuery()}&count={count}";
            
            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url;
        }
        public string ChampionMasteryScore(string encryptedSummonerId) 
        {
            string endpoint = $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}";
            string query_paramenters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_paramenters;

            return url; 
        }
    }
}
