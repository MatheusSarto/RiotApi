namespace RiotApi.DataStructures.LeagueOfLegends
{
    /// <summary>
    /// Summoner Summary can be thought as the "Home Page" of summoner's information ( Contains Custom Data Types )
    /// </summary>
    public class SummonerSummary
    {
        public string SummonerName { get; set; }
        public int SumomnerLevel { get; set; }
        public List<Rank_> RanksInfo { get; set; }
        public List<ChampionMasteryDto> TopMasteries { get; set; }
    }
}
