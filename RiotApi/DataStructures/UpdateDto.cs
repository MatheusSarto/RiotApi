namespace RiotApi.DataStructures
{
    public class UpdateDto
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public bool Publish { get; set; }
        public List<string> Publish_Locations { get; set; }
        public List<ContentDto> Translations { get; set; }
        public string Created_At { get; set; }
        public string Updated_At { get; set; }
    }
}
