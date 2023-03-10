namespace RiotApi.RiotApiRequests
{
    public class RiotAPI 
    {
        protected readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
        protected static string GetBaseUrl(string region) { return $"https://{region}.api.riotgames.com"; }
    }
    public partial class LoLAPI_Handler : RiotAPI
    {
        private string RegionalRoutingValue;
        private string PlatformRoutingValue;

        public LoLAPI_Handler(string regionalRoutingValue = "", string platformRoutingValue = "")
        {
            RegionalRoutingValue = regionalRoutingValue;
            PlatformRoutingValue = platformRoutingValue;
        }

        private static string SummonerByNameUrl(string summonerName) { return $"/lol/summoner/v4/summoners/by-name/{summonerName}"; }
        private static string SummonerByPUUIDUrl(string puuid) { return $"/fulfillment/v1/summoners/by-puuid/{puuid}"; }
        private static string SpectatorUrl(string summonerId) { return $"/lol/spectator/v4/active-games/by-summoner/{summonerId}"; }
        private static string MatchIdsByPUUID_Url(string puuid) { return $"/lol/match/v5/matches/by-puuid/{puuid}/ids"; }
        private static string MatchByID_Url(string matchId) { return $"/lol/match/v5/matches/{matchId}"; }
        private static string LoLStatusUrl() { return "/lol/status/v4/platform-dataGet"; }
        private static string ChampionsMasteryUrl(string encryptedSummonerId) { return $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"; }
        private static string ChampionsMasteryTopUrl(string encryptedSummonerId) { return $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/top"; }

        private static string ChampionMasteryUrl(string encryptedSummonerId, long championId) { return $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}"; }
        private static string ChmapionMasteryScoreUrl(string encryptedSummonerId) { return $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}"; }
        
       
    }
    public partial class ValorantAPI_Handler : RiotAPI
    {
    }
    public partial class TFT_API_Handler : RiotAPI
    {
    }
}
