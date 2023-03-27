namespace RiotApi.DataStructures.LeagueOfLegends
{
   /**
   * \class CurrentGameParticipant
   * \file CurrentGameParticipant.cs
   * \date 25/03/2023
   */
    public class CurrentGameParticipant
    {
        /**
         * @brief The ID of The Champion Played by This Participant.
         */
        public long ChampionId { get; set; }

        /**
         * @brief Perks/Runes Reforged Information.
         */
        public Perks Perks_ { get; set; }

        /**
         * @brief The ID of The Profile Icon Used by This Participant.
         */
        public long ProfileIconId { get; set; }

        /**
         * @brief Flag Indicating Whether or Not This Participant is a Bot.
         */
        public bool Bot { get; set; }

        /**
         * @brief The Team ID of This Participant, Indicating The Participant's Team.
         */
        public long TeamId { get; set; }

        /**
         * @brief The Summoner Name of This Participant.
         */
        public string SummonerName { get; set; }

        /**
         * @brief The Encrypted Summoner ID of This Participant.
         */
        public string SummonerId { get; set; }

        /**
         * @brief The ID of The First Summoner Spell Used by This Participant.
         */
        public long Spell1Id { get; set; }

        /**
         * @brief The ID of The Second Summoner Spell Used by This Participant.
         */
        public long Spell2Id { get; set; }

        /**
         * @brief List of Game Customizations.
         */
        public List<GameCustomizationObject> GameCustomizationObjects { get; set; }

    }
}
