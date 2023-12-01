using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_LeagueURL : URL
    {
        public TFT_LeagueURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRountingValue, string apikey) :
            base(regionalRoutingValue, platformRountingValue, apikey)
        { 
        
        }

        public string BySummonerId(string summonerId)
        {
            string endpoint = $"/tft/league/v1/entries/by-summoner/{summonerId}";
            string query_parameter = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameter;


            return url;
        }
    }
}
