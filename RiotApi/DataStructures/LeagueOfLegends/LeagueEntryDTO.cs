namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * \class LeagueEntryDTO
     * \file LeagueEntryDTO.cs
     * \date 24/03/2023
     */
    public class LeagueEntryDTO
    {
        /**
         * @brief Summoner's Current League ID.
         */
        public string LeagueId { get; set; }

        /**
         * @brief Player's SummonerId (Encrypted).
         */
        public string SummonerId { get; set; }

        /**
         * @brief Summoner Name.
         */
        public string SummonerName { get; set; }

        /**
         * @brief Queue Type (SoloDuo / Flex).
         */
        public string QueueType { get; set; }

        /**
         * @brief Division Tier.
         */
        public string Tier { get; set; }

        /**
         * @brief The Player's Division Within a Tier.
         */
        public string Rank { get; set; }

        /**
         * @brief Summoner's Current League Points.
         */
        public int LeaguePoints { get; set; }

        /**
         * @brief Winning Team On Summoners Rift. First Placement In Teamfight Tactics.
         */
        public int Wins { get; set; }

        /**
         * @brief Losing Team On Summoners Rift. Second Through Eighth Placement Ín Teamfight Tactics.
         */
        public int Losses { get; set; }

        /**
         * @brief Hot Streak.
         */
        public bool HotStreak { get; set; }

        /**
         * @brief Veteran.
         */
        public bool Veteran { get; set; }

        /**
         * @brief Fresh Blood.
         */
        public bool FreshBlood { get; set; }

        /**
         * @brief Inactive.
         */
        public bool Inactive { get; set; }

        /**
         * @brief MiniSeriesDTO Object.
         */
        public MiniSeriesDTO MiniSeries { get; set; }
    }
}
