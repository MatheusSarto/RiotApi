using RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests;

namespace RiotApi.RiotApiRequests
{
    public class API_Handler 
    {
        protected string GetApiKey() { return API_KEY; }
        private readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
    }
    public partial class LoLAPI_Handler : API_Handler
    {
        public StatusRequests Status;
        public SummonerRequests Summoner;
        public MatchRequests Match;
        public ChmapioMasteryRequests ChampionMastery;
        public SpectatorRequests Spectator;

        public LoLAPI_Handler(string regionalRoutingValue, string platformRoutingValue)
        {
            Status = new StatusRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Summoner = new SummonerRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Match = new MatchRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            ChampionMastery = new ChmapioMasteryRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
            Spectator = new SpectatorRequests(regionalRoutingValue, platformRoutingValue, GetApiKey());
        }       
    }
    public partial class ValorantAPI_Handler : API_Handler
    {
    }
    public partial class TFT_API_Handler : API_Handler
    {
    }
}
