namespace RiotApi.DataStructures
{
    public class MetadataDto
    {
        public string DataVersion { get; set; }
        public string MatchId { get; set; }
        public List<string> Participants { get; set; }
    }
}
