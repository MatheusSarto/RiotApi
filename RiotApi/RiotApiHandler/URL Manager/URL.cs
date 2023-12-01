using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler
{
    public class URL
    {
        public URL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues paltaformRountingValue,string apikey) 
        {
            RegionalRoutingValue = regionalRoutingValue;
            PlataformRoutingValue = paltaformRountingValue;
            APIKEY_QUERY = apikey;
        }
      
        protected string GetBaseUrl(string region) { return $"https://{region}.api.riotgames.com"; }
        protected string GetPltaformRoutingValue() { return PlataformRoutingValue.ToString(); }
        protected string GetRegionalRoutingValue() { return RegionalRoutingValue.ToString(); }
        protected string GetApiKeyQuery() { return $"?api_key={APIKEY_QUERY}"; }

        private PlatformRoutingValues PlataformRoutingValue;
        private RegionalRoutingValues RegionalRoutingValue;
        private string APIKEY_QUERY;
    }
}
