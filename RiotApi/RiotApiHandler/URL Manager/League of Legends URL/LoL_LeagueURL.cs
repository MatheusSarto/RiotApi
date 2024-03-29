﻿using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL
{
    public class LoL_LeagueURL : URL
    {
        public LoL_LeagueURL(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRountingValue, string apikey)
            : base(regionalRoutingValue, platformRountingValue, apikey)
        {

        }

        public string BySummoner(string encryptedSummonerId)
        {
            string endpoint = $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}";
            string query_parameters = $"{GetApiKeyQuery}";

            string url = GetBaseUrl(GetPltaformRoutingValue()) + endpoint + query_parameters;
            
            return url;
        }
    }
}
