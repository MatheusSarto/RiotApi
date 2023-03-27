namespace RiotApi.DataStructures
{
    /**
     * @brief Holds All Possible Aceptable Parameters to Rescue Match IDs.
     *\class Specifications_MatchIds
     *\file Specifications_MatchIds.cs
     *\date 27/03/2023
    */
    public class Specifications_MatchIds
    {
        public int? Queue { get; set; } /**< Detailed Filter the list of match ids by a specific queue id. This filter is mutually inclusive of the type filter meaning any match ids returned must match both the queue and type filters.*/
        public string? Type { get; set; } /**< Detailed Filter the list of match ids by the type of match. This filter is mutually inclusive of the queue filter meaning any match ids returned must match both the queue and type filters.*/
        public int Count { get; set; } /**< Detailed Defaults to 20. Valid values: 0 to 100. Number of match ids to return.*/
        public int Start { get; set; }  /**< Detailed Defaults to 0. Start index.*/
        public long? StartTime { get; set; }  /**< Detailed Epoch timestamp in seconds. The matchlist started storing timestamps on June 16th, 2021. Any matches played before June 16th, 2021 won't be included in the results if the startTime filter is set.*/
        public long? EndTime { get; set; }  /**< Detailed Epoch timestamp in seconds.*/
    }
}
