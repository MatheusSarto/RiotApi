using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.TFT_URL;

namespace RiotApi.RiotApiHandler.Requesters.TFT_Requests
{
    public class TFT_MatchRequests
    {
        public TFT_MatchRequests(string regionalRoutingValue, string platformRoutingValue, string apikey)
        {
            URL = new TFT_MatchURL(regionalRoutingValue, platformRoutingValue, apikey);
        }
        public List<string> GetMatchIds(string encryptedPUUID, long startTime = -1, long endTime = -1,
           int count = 20, int start = 0)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.MatchIDs(encryptedPUUID, start, endTime, startTime, count));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content);

            return responseObj;
        }

        public List<MatchDto> GetMatchesByID(List<string> matchIds)
        {
            HttpClient client = new HttpClient();
            List<MatchDto> matches = new List<MatchDto>();

            matchIds.ForEach((matchId) => {
                var endpoint = new Uri(URL.MatchByID(matchId));

                var result = client.GetAsync(endpoint).Result;
                var content = result.Content.ReadAsStringAsync().Result;

                MatchDto match = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchDto>(content);
                matches.Add(match);
            });

            return matches;
        }


        private TFT_MatchURL URL;
    }
}
