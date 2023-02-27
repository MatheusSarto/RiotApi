namespace RiotApi.DataStructures
{
    public class StatusDto
    {
        public int Id { get; set; }
        public string Maintance_Status { get; set; }
        public string Incident_Severty { get; set; }
        public List<ContentDto> Titles { get; set; }
        public List<UpdateDto> Updates { get; set; }
        public string Created_At { get; set; }
        public string Arcguve_At { get; set; }
        public string Updated_At { get; set; }
        public List<string> Plataforms { get; set; }
    }
}
