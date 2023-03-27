namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
    * \class MetadataDto
    * \file MetadataDto.cs
    * \date 25/03/2023
    */
    public class MetadataDto
    {
        /**
         * @brief Match Data Version.
         */
        public string DataVersion { get; set; }

        /**
        * @brief Match Id.
        */
        public string MatchId { get; set; }

        /**
        * @brief A List of Participant PUUIDs.
        */
        public List<string> Participants { get; set; }
    }
}
