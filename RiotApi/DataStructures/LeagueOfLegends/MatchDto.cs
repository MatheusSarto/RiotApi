namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * \class MatchDto
     * \file MatchDto.cs
     * \date 25/03/2023
     */
    public class MatchDto
    {
        /**
         * @brief Match Metadata.
         */
        public MetadataDto Metada { get; set; }

        /**
        * @brief Match Info.
        */
        public InfoDto Info { get; set; }
    }
}
