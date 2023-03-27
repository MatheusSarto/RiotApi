namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
     * \class InfoDto
     * \file InfoDto.cs
     * \date 25/03/2023
     */
    public class InfoDto
    {
        /**
         * @brief Unix Timestamp For When The Game is Created on The Game Server (i.e., The Loading Screen).
         */
        public long GameCreation { get; set; }

        /**
         * @brief Prior to Patch 11.20, This Field Returns The Game Length in Milliseconds Calculated From GameEndTimestamp - GameStartTimestamp. Post Patch 11.20, This Field Returns The Max TimePlayed of Any Participant in The Game in Seconds, Which Makes The Behavior of This Field Consistent With That of Match-v4. The Best Way to Handling The Change in This Field is to Treat The Value as Milliseconds if The GameEndTimestamp Field Isn't in The Response And to Treat The Value as Seconds if GameEndTimestamp is in The Response.
         */
        public long GameDuration { get; set; }

        /**
         * @brief Unix Timestamp For When Match Ends on The Game Server. This Timestamp Can Occasionally be Significantly Longer Than When The Match "Cnds". The Most Reliable Way of Determining The Timestamp For The End of Ghe Match Would be to Add The Max Time Played of Any Participant to The GameStartTimestamp. This Field Was Added to Match-v5 in Patch 11.20 on Oct 5th, 2021.
         */
        public long GameEndTimestamp { get; set; }
        public long GameId { get; set; }

        /**
         * @brief Refer to the Game Constants documentation.
         */
        public string GameMode { get; set; }
        public string GameName { get; set; }

        /**
         * @brief Unix Timestamp For When Match Starts on The Game Server.
         */
        public long GameStartTimestamp { get; set; }
        public string GameType { get; set; }

        /**
         * @brief The First Two Parts Can be Used to Determine The Patch a Game Was Played on.
         */
        public string GameVersion { get; set; }

        /**
         * @brief Refer to The Game Constants Documentation.
         */
        public int MapId { get; set; }
        public List<ParticipantDto> Participants { get; set; }

        /**
         * @brief Platform Where The Match Was Played.
         */
        public string PlataformId { get; set; }

        /**
         * @brief Refer to The Game Constants Documentation.
         */
        public int QueueId { get; set; }
        public List<TeamDto> Teams { get; set; }

        /**
        * @brief Tournament Code Used to Generate The Match. This Field Was Added to Match-v5 in Patch 11.13 on June 23rd, 2021.
        */
        public string TournamentCode { get; set; }
    }
}
