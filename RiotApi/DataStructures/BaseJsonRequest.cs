using RegionalRoutingValues = RiotApi.DataStructures.RegionalRoutingValues;
using PlatformRoutingValues = RiotApi.DataStructures.PlatformRoutingValues;
namespace RiotApi.DataStructures
{
    /**
     * @brief Base Class That Holds The Most Basic Information to All Requests Acceptable Models
     *\class BaseJsonRequest
     *\file BaseJsonRequest.cs
     *\date 27/03/2023
    */
    public class BaseJsonRequest
    {
        public RegionalRoutingValues RegionalRoutingValue { get; set; }
        public PlatformRoutingValues PlatformRoutingValue { get; set; }

        protected BaseJsonRequest(RegionalRoutingValues regionalRoutingValue, PlatformRoutingValues platformRoutingValue) /**< Detailed This Class is NOT Supposed to Be Initialized by it's Own. */
        {
            RegionalRoutingValue = regionalRoutingValue;
            PlatformRoutingValue = platformRoutingValue;
        }
    }
}
