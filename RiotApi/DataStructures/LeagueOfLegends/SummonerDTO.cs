namespace RiotApi.DataStructures.LeagueOfLegends
{
    /**
    *\class SummonerDTO
    *\file SummonerDTO.cs
    *\date 25/03/2023
    */
    public class SummonerDTO
    {
        /**
         * @brief Encrypted Account ID. Max Length 56 Characters.
         */
        public string? AccountId { get; set; }

        /**
         * @brief ID of The Summoner Icon Associated With The Summoner.
         */
        public int? ProfileIconId { get; set; }

        /**
         * @brief Date Summoner Was Last Modified Specified as Epoch Milliseconds. The Following Events Will Update This Timestamp: Profile Icon Change, Playing The Tutorial or Advanced Tutorial, Finishing a Game, Summoner Name Change.
         */
        public long? RevisionDate { get; set; }

        /**
         * @brief Summoner Name.
         */
        public string? Name { get; set; }

        /**
         * @brief Encrypted Summoner ID. Max Length 63 Characters.
         */
        public string? Id { get; set; }

        /**
         * @brief Encrypted PUUID. Exact Length of 78 Characters.
         */
        public string? PUUID { get; set; }

        /**
         * @brief Summoner Level Associated With The summoner.
         */
        public long? SummonerLevel { get; set; }
    }
}
