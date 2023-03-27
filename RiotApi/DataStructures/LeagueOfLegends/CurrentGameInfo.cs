namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
    * \class CurrentGameInfo
    * \file CurrentGameInfo.cs
    * \date 25/03/2023
    */
    public class CurrentGameInfo
    {
        /**
         * @brief The ID of The Game.
         */
        public int GameId { get; set; }

        /**
         * @brief The Game Type.
         */
        public string GameType { get; set; }

        /**
         * @brief The Game Start Time Represented in Epoch Milliseconds.
         */
        public long GameStart { get; set; }

        /**
         * @brief The ID of The Map.
         */
        public long GameLength { get; set; }

        /**
         * @brief The Amount of Time in Seconds That Has Passed Since The Game Started.
         */
        public long MapId { get; set; }

        /**
         * @brief The ID of The Platform on Which The Game is Being Played.
         */
        public string PlatformId { get; set; }

        /**
         * @brief The Game Mode.
         */
        public string GameMode { get; set; }

        /**
         * @brief Banned Champion Information.
         */
        public List<BannedChampion> BannedChampions { get; set; }

        /**
         * @brief The Queue Type (Queue Types Are Documented on The Game Constants Page).
         */
        public long GameQueueConfigId { get; set; }

        /**
         * @brief The Observer Information.
         */
        public Observer Observers { get; set; }

        /**
         * @brief The Participant Information.
         */
        public List<CurrentGameParticipant> Participants { get; set; }
    }
}
