namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_SpectatorURL : URL
    {
        public LoL_SpectatorURL(string regionalRoutingValue, string platformRoutingValue, string apikey)
            : base(regionalRoutingValue, platformRoutingValue, apikey)
        {

        }
        public string Spectator(string encryptedSummonerId)
        {
            string endpoint = $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}";
            string query_parameters = $"{GetApiKeyQuery()}";

            string url = GetBaseUrl(GetPlataformRoutingValue()) + endpoint + query_parameters;

            return url; 
        }
    }
}
