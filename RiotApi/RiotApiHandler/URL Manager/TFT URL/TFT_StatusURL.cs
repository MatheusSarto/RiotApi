using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_StatusURL : URL
    {
        public TFT_StatusURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue, string apikey)
           : base(regionalRoutingValue, platformRoutingValue, apikey)
        {

        }

        public string Status()
        {
            string endpoint = "/tft/status/v1/platform-data";
            string query_parameters = $"{GetApiKeyQuery}";
            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;

            return url;
        }
    }
}
