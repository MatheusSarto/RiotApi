namespace RiotApi.DataStructures
{
    public class PlatformDataDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Locales { get; set; }
        public List<StatusDto> Maintenances { get; set; }
        public List<StatusDto> Incidents { get; set; }
    }
}
