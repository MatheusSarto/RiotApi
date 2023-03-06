namespace RiotApi.RiotApiRequests
{
    public class RiotAPI 
    {
        protected readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
        protected string GetBaseUrl(string region) { return $"https://{region}.api.riotgames.com"; }
    }
    public partial class LoLAPI_Handler : RiotAPI
    {
        private string GetSummonerByName(string summonerName) { return $"/lol/summoner/v4/summoners/by-name/{summonerName}"; }
        private string GetSummonerByPUUID(string puuid) { return $"/fulfillment/v1/summoners/by-puuid/{puuid}"; }
        private string GetSpectator(string summonerId) { return $"/lol/spectator/v4/active-games/by-summoner/{summonerId}"; }
        private string GetMatchIdsByPUUID(string puuid) { return $"/lol/match/v5/matches/by-puuid/{puuid}/ids"; }
        private string GetMatchByID(string matchId) { return $"/lol/match/v5/matches/{matchId}"; }
        private string GetLoLStatus() { return "/lol/status/v4/platform-dataGet"; }
        private string GetChampionsMasteryBySummonerID(string encryptedSummonerId) { return $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"; }
        private string GetChampionMasteryBySummonerID(string encryptedSummonerId, long championId) { return $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}"; }
        private string GetChmapionMasteryScoreBySummonerID(string encryptedSummonerId) { return $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}"; }
    }
    public partial class ValorantAPI_Handler : RiotAPI
    {
    }
    public partial class TFT_API_Handler : RiotAPI
    {
    }
}
