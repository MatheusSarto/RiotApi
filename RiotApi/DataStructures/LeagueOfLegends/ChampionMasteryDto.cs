namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * @brief This object contains single Champion Mastery information for player and champion combination.
     * \class ChampionMasteryDto
     * \file ChampionMasteryDto.cs
     * \date 24/03/2023
     */
    public class ChampionMasteryDto
    {
        /**
         * @brief Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.
         */
        public long ChampionPointsUntilNextLevel { get; set; }

        /**
         * brief Is chest granted for this champion or not in current season.
         */
        public bool ChestGranted { get; set; }

        /**
         * @brief Champion ID for this entry.
         */
        public long ChampionId { get; set; }

        /**
         * @brief Last time this champion was played by this player - in Unix milliseconds time format.
         */
        public long LastPlayTime { get; set; }

        /**
         * @brief Champion level for specified player and champion combination.
         */
        public int ChampionLevel { get; set; }

        /**
         * @brief Summoner ID for this entry. (Encrypted)
         */
        public string SummonerId { get; set; }

        /**
         * @brief Total number of champion points for this player and champion combination - they are used to determine championLevel.
         */
        public int ChampionPoints { get; set; }

        /**
         * @brief Number of points earned since current level has been achieved.
         */
        public long ChampionPointsSinceLastLevel { get; set; }

        /**
         * @brief The token earned for this champion at the current championLevel. When the championLevel is advanced the tokensEarned resets to 0.
         */
        public int TokensEarned { get; set; }
    }
}
