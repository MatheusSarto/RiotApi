namespace RiotApi.DataStructures.LeagueOfLegends
{
    public class TeamDto
    {
        public List<BanDto> Bans { get; set; }
        public ObjectivesDto Objectives { get; set; }
        public int TeamId { get; set; }
        public bool win { get; set; }
    }
}
