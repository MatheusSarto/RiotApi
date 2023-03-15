namespace RiotApi.RiotApiHandler
{
    public class URL
    {
        public URL(string regionalRoutingValue, string paltaformRountingValue,string apikey) 
        {
            RegionalRoutingValue = regionalRoutingValue;
            PlataformRoutingValue = paltaformRountingValue;
            APIKEY_QUERY = APIKEY_QUERY.Equals(apikey) ? apikey : APIKEY_QUERY;
        }
      
        protected string GetBaseUrl(string region) { return $"https://{region}.api.riotgames.com"; }
        protected string GetPlataformRoutingValue() { return PlataformRoutingValue; }
        protected string GetRegionalRoutingValue() { return RegionalRoutingValue; }
        protected string GetApiKeyQuery() { return $"?api_key={APIKEY_QUERY}"; }

        private string PlataformRoutingValue;
        private string RegionalRoutingValue;
        private static string APIKEY_QUERY;
    }
}
