namespace RiotApi.EndPoints
{
    public static class ApiUrls
    {
        public static string GetBaseUrl(string region) { return $"https://{region}.api.riotgames.com"; }
        #region LoL_Summoner
        public static string GetSummonerByName(string summonerName) { return $"/lol/summoner/v4/summoners/by-name/{summonerName}"; }
        public static string GetSummonerByPUUID(string puuid) { return $"/fulfillment/v1/summoners/by-puuid/{puuid}"; }
        #endregion
        public static string GetSpectator(string summonerId) { return $"/lol/spectator/v4/active-games/by-summoner/{summonerId}"; }
        #region LoL_Match
        public static string GetMatchIdByPUUID(string puuid) { return $"/lol/match/v5/matches/by-puuid/{puuid}/ids"; }
        public static string GetMatchByID(string matchId) { return $"/lol/match/v5/matches/{matchId}"; }
        #endregion
    }

    public static class API_KEY
    {
        public static string Get_API_KEY() { return "RGAPI-9f938707-3677-40bc-9fb2-49c056ff655b"; }
    }

  
     
}
