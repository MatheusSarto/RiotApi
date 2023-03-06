namespace RiotApi.DataStructures.LeagueOfLegends
{
    public class MetadataDto
    {
        public string DataVersion { get; set; }
        public string MatchId { get; set; }
        public List<string> Participants { get; set; }
    }
}
