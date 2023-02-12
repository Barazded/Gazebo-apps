using SQLite;

namespace News_aggregator.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }
}
