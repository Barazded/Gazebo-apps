using SQLite;

namespace NewsAggregator.Models
{
    [Table("Resourses")]
    public class ResourseItem
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string NameItem { get; set; }
        public string Text { get; set; }
        public bool isChecked { get; set; }
    }
}
