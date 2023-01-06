using System;
using SQLite;

namespace News_aggregator.Models
{
    [Table("Resourses")]
    public class ResourseItem
    {
        [PrimaryKey]
        public int ID { get; set; }
        [Unique]
        public string NameItem { get; set; }
        public string UriResourse { get; set; }
        public string Text { get; set; }
        public bool isChecked { get; set; }
    }
}
