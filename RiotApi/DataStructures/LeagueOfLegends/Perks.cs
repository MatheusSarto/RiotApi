namespace RiotApi.DataStructures.LeagueOfLegends
{
   /**
   * \class Perks
   * \file Perks.cs
   * \date 25/03/2023
   */
    public class Perks
    {
        /**
         * @brief IDs of The Perks/Runes Assigned.
         */
        public List<long> PerkIds { get; set; }

        /**
         * @brief Primary Runes Path.
         */
        public long PerkStyle { get; set; }

        /**
         * @brief Secondary Runes Path.
         */
        public long PerkSubstyle { get; set; }
    }
}
