using RiotApi.DataStructures;
using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class LoL_MatchRequests
    {
        public LoL_MatchRequests(string regionalRoutingValue, string platformRoutingValue, string apikey)
        {
            URL = new LoL_MatchURL(regionalRoutingValue, platformRoutingValue, apikey);
        }

        public List<string> GetMatchIds(string encryptedPUUID, Specifications_MatchIds specifications)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.MatchIDs(encryptedPUUID, specifications));

            var result = client.GetAsync(uri).Result;
            var content = result.Content.ReadAsStringAsync().Result;

            List<string> responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(content).ToList<string>();

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

        private LoL_MatchURL URL;
    }
}
