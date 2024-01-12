using SQLite;

namespace News_aggregator.Models
{
    [Table("ResoursesTable")]
    public class ResourseSettings
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string TextName { get; set; }
        public byte[] ParserSettingsByte { get; set; }
        public bool isChecked { get; set; }
        public bool canDelit { get; set; }
    }
}