using RiotApi.DataStructures.LeagueOfLegends;
using RiotApi.RiotApiHandler.URL_Manager.League_of_Legends_URL;

namespace RiotApi.RiotApiHandler.Requesters.League_of_Legends_Requests
{
    public class MatchRequests
    {
        public List<string> GetMatchIds(string encryptedPUUID, long startTime, long endTime,
            string queue, string type, int count, int start)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(URL.MatchIds(encryptedPUUID, startTime, endTime, queue, type, count, start));

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

        private MatchURL URL;
    }
}
