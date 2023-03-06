namespace RiotApi.DataStructures.LeagueOfLegends
{
    public class CurrentGameInfo
    {
        public int GameId { get; set; }
        public string GameType { get; set; }
        public long GameStart { get; set; }
        public long GameLength { get; set; }
        public long MapId { get; set; }
        public string PlatformId { get; set; }
        public string GameMode { get; set; }
        public List<BannedChampion> BannedChampions { get; set; }
        public long GameQueueConfigId { get; set; }
        public Observer Observers { get; set; }
        public List<CurrentGameParticipant> Participants { get; set; }
    }
}
