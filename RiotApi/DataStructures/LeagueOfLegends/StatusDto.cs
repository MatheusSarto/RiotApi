namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * @brief Status Information.
     * \class StatusDto
     * \file StatusDto.cs
     * \date 25/03/2023
     */
    public class StatusDto
    {
        public int Id { get; set; }

        /*
         * @brief Legal Values: Scheduled, In_progress, Complete.
         */
        public string Maintance_Status { get; set; }

        /*
         * @brief Legal Values: Info, Warning, Critical.
         */
        public string Incident_Severty { get; set; }
        public List<ContentDto> Titles { get; set; }
        public List<UpdateDto> Updates { get; set; }
        public string Created_At { get; set; }
        public string Archive_At { get; set; }
        public string Updated_At { get; set; }

        /*
         * @brief Legal Values: Windows, Macos, Android, Ios, Ps4, Xbone, Switch.
         */
        public List<string> Platforms { get; set; }
    }
}
