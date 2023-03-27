namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * @brief Server And Game Information.
     * \class PlatformDataDto
     * \file PlatformDataDto.cs
     * \date 25/03/2023
     */
    public class PlatformDataDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Locales { get; set; }
        public List<StatusDto> Maintenances { get; set; }
        public List<StatusDto> Incidents { get; set; }
    }
}
