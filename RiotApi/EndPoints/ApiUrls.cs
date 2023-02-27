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
        public static string GetMatchIdsByPUUID(string puuid) { return $"/lol/match/v5/matches/by-puuid/{puuid}/ids"; }
        public static string GetMatchByID(string matchId) { return $"/lol/match/v5/matches/{matchId}"; }
        public static string GetLoLStatus() { return "/lol/status/v4/platform-dataGet";  }
        #endregion
    }

    public static class API_KEY
    {
        /// <summary>
        /// This method holds your Riot Api Key, you should not share it.
        /// By default it's expecting to find a "RiotApiKey.txt" with the Api Key, on your Desktop.
        /// </summary>
        public static string Get_API_KEY() { return File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt"); }
    }
  
}
