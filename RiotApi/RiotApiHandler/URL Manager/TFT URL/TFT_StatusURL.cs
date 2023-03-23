using Microsoft.AspNetCore.DataProtection.KeyManagement;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.URL_Manager.TFT_URL
{
    public class TFT_StatusURL : URL
    {
        public TFT_StatusURL(string regionalRoutingValue, string platformRoutingValue, string apikey)
           : base(regionalRoutingValue, platformRoutingValue, apikey)
        {

        }

        public string Status()
        {
            string endpoint = "/tft/status/v1/platform-data";
            string query_parameters = $"{GetApiKeyQuery}";
            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameters;

            return url;
        }
    }
}
