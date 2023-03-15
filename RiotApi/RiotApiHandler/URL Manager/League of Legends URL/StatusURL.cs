namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class StatusURL : URL
    {
        public StatusURL(string regionalRoutingValue, string paltaformRountingValue, string apikey)
            : base(regionalRoutingValue, paltaformRountingValue,apikey)
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
