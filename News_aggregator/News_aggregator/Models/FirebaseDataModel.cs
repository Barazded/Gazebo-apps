
namespace News_aggregator.Models
{
    public class FirebaseDataModel
    {
        public string Id { get; set; }
        public int Rating { get; set; }
        public ParserSettings ApiSettings { get; set; }
    }
}
