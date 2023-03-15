namespace RiotApi.RiotApiRequests
{
    public class API_Handler 
    {
        protected string GetApiKey() { return API_KEY; }
        private readonly string API_KEY = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\RioApiKey.txt");
    }
    public partial class LoLAPI_Handler : API_Handler
    {
        

        public LoLAPI_Handler(string regionalRoutingValue, string platformRoutingValue)
        {
        }       
    }
    public partial class ValorantAPI_Handler : API_Handler
    {
    }
    public partial class TFT_API_Handler : API_Handler
    {
    }
}
