namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class SpectatorURL : URL
    {
        public SpectatorURL(string regionalRoutingValue, string paltaformRountingValue, string apikey)
            : base(regionalRoutingValue, paltaformRountingValue, apikey)
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
