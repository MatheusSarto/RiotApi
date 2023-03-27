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
        public string RegionalRoutingValue { get; set; }
        public string PlatformRoutingValue { get; set; }

        protected BaseJsonRequest(string regionalRoutingValue, string platformRoutingValue) /**< Detailed This Class is NOT Supposed to Be Initialized by it's Own. */
        {
            RegionalRoutingValue = regionalRoutingValue;
            PlatformRoutingValue = platformRoutingValue;
        }
    }
}
