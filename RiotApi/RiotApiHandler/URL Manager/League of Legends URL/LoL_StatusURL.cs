namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_StatusURL : URL
    {
        public LoL_StatusURL(string regionalRoutingValue, string platformRoutingValue, string apikey)
            : base(regionalRoutingValue, platformRoutingValue, apikey)
        {

        }

        public string Status() 
        { 
            string endpoint = "/lol/status/v4/platform-dataGet";
            string query_parameters = $"{GetApiKeyQuery}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameters;

            return url; 
        }
    }
}
