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
        public LoL_StatusRequests GetStatus() { return m_Status; }
        public LoL_SummonerRequests GetSummoner() { return m_Summoner; }
        public LoL_LeagueRequests GetLeague() { return m_League; }
        public LoL_MatchRequests GetMatch() { return m_Match; }
        public LoL_ChampioMasteryRequests GetChampionMastery() { return m_ChampionMastery; }
        public LoL_SpectatorRequests GetSpectator() { return m_Spectator; }

        public LoLAPI_Handler(BaseJsonRequest baseJson) : base(baseJson)
        {
            m_Status = new LoL_StatusRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_Summoner = new LoL_SummonerRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_League = new LoL_LeagueRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_Match = new LoL_MatchRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_ChampionMastery = new LoL_ChampioMasteryRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_Spectator = new LoL_SpectatorRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
        }

        private LoL_StatusRequests m_Status;
        private LoL_SummonerRequests m_Summoner;
        private LoL_LeagueRequests m_League;
        private LoL_MatchRequests m_Match;
        private LoL_ChampioMasteryRequests m_ChampionMastery;
        private LoL_SpectatorRequests m_Spectator;
    }

    public partial class TFT_API_Handler : API_Handler
    {
        public TFT_StatusRequests GetStatus() { return m_Status; }
        public TFT_SummonerRequests GetSummoner() { return m_Summoner; }
        public TFT_LeagueRequests GetLeague() { return m_League; }
        public TFT_MatchRequests GetMatch() { return m_Match; }

        public TFT_API_Handler(BaseJsonRequest baseJson) : base(baseJson)
        {
            m_Status = new TFT_StatusRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_Summoner = new TFT_SummonerRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_Match = new TFT_MatchRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
            m_League = new TFT_LeagueRequests(baseJson.RegionalRoutingValue, baseJson.PlatformRoutingValue, GetApiKey());
        }

        private TFT_StatusRequests m_Status;
        private TFT_SummonerRequests m_Summoner;
        private TFT_MatchRequests m_Match;
        private TFT_LeagueRequests m_League;
    }

    public partial class ValorantAPI_Handler : API_Handler
    {
        public ValorantAPI_Handler(BaseJsonRequest baseJson) : base(baseJson)
        { 
        
        }
    }
}
