﻿namespace RiotApi.DataStructures
{
    /**
    * @brief Holds All Possible Aceptable Parameters to The Endpoint Program.SummonerInfo.cs.
    *\class SummonerSummaryJson
    *\file SummonerSummaryJson.cs
    *\date 27/03/2023
    */
    public class SummonerSummaryJson : BaseJsonRequest
    {
        /**< Detailed Constructor */
        public SummonerSummaryJson(string regionalRoutingVallue, string platformRoutingValue) :
            base(regionalRoutingVallue, platformRoutingValue)
        { }
        public Specifications_MatchIds MatchIdSpecifications { get; set; } /**< Detailed Specifications_MatchIds Object */

    }
}
