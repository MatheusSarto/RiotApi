namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
    * \class BannedChampion
    * \file BannedChampion.cs
    * \date 25/03/2023
    */
    public class BannedChampion
    {
        /**
         * @brief The Turn During Which The Champion Was Banned.

         */
        public int PickTurn { get; set; }

        /**
         * @brief The ID of The Banned Champion.

         */
        public long ChampionId { get; set; }

        /**
         * @brief The ID of The Team That Banned The Champion.
         */
        public long TeamId { get; set; }
    }
}
