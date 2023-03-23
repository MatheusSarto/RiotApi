using RiotApi.DataStructures;
using RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests;
using RiotApi.RiotApiHandler.Requesters.TFT_Requests;

namespace RiotApi.RiotApiRequests
{
    public class API_Handler 
    {
        protected API_Handler(BaseJsonRequest baseJson)
        {  }

        protected string GetApiKey() { return API_KEY; }
        
        private readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
    }
    public partial class LoLAPI_Handler : API_Handler
    {
        public LoL_StatusRequests Status;
        public LoL_SummonerRequests Summoner;
        public LoL_LeagueRequests League;
        public LoL_MatchRequests Match;
        public LoL_ChampioMasteryRequests ChampionMastery;
        public LoL_SpectatorRequests Spectator;

        public LoLAPI_Handler(BaseJsonRequest baseJson) : base(baseJson)
        {
            Status = new LoL_StatusRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            Summoner = new LoL_SummonerRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            League = new LoL_LeagueRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            Match = new LoL_MatchRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            ChampionMastery = new LoL_ChampioMasteryRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            Spectator = new LoL_SpectatorRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
        }       
    }

    public partial class TFT_API_Handler : API_Handler
    {
        public TFT_StatusRequests Status;
        public TFT_SummonerRequests Summoner;
        public TFT_MatchRequests Match;
        public TFT_LeagueRequests League;

        public TFT_API_Handler(BaseJsonRequest baseJson) : base(baseJson)
        {
            Status = new TFT_StatusRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            Summoner = new TFT_SummonerRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            Match = new TFT_MatchRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            League = new TFT_LeagueRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
        }
    }

    public partial class ValorantAPI_Handler : API_Handler
    {
        public ValorantAPI_Handler(BaseJsonRequest baseJson) : base(baseJson)
        { 
        
        }
    }
}
