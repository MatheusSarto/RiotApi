using RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests;
using RiotApi.RiotApiHandler.Requesters.TFT_Requests;

namespace RiotApi.RiotApiRequests
{
    public class API_Handler 
    {
        protected API_Handler()
        {


        }

        protected string GetApiKey() { return API_KEY; }
        
        private readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
    }
    public partial class LoLAPI_Handler : API_Handler
    {
        public LoL_StatusRequests Status;
        public LoL_SummonerRequests Summoner;
        public LoL_MatchRequests Match;
        public ChmapioMasteryRequests ChampionMastery;
        public LoL_SpectatorRequests Spectator;

        public LoLAPI_Handler(string regionalRoutingValue, string platformRoutingValue) 
        {
            Status = new LoL_StatusRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Summoner = new LoL_SummonerRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Match = new LoL_MatchRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            ChampionMastery = new ChmapioMasteryRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Spectator = new LoL_SpectatorRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
        }       
    }
    public partial class ValorantAPI_Handler : API_Handler
    {
        public TFT_StatusRequests Status;
        public TFT_SummonerRequests Summoner;
        public TFT_MatchRequests Match;
        public TFT_LeagueRequests League;

        public ValorantAPI_Handler(string regionalRoutingValue, string platformRoutingValue) 
        {
            Status = new TFT_StatusRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Summoner = new TFT_SummonerRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Match = new TFT_MatchRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            League = new TFT_LeagueRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
        }
    }
    public partial class TFT_API_Handler : API_Handler
    {
        public TFT_API_Handler(string regionalRoutingValue, string platformRoutingValue) 
        { }
    }
}
