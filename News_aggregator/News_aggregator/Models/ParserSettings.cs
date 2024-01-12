using System;

namespace News_aggregator.Models
{
    [Serializable]
    public class ParserSettings
    {
        public string NameResourse { get; set; }
        public string UrlResourse { get; set; }
        public ResourseType TypeResourse { get; set; }
        public string TitleSelector { get; set; }
        public string LinkSelector { get; set; }
        public string InfoSelector { get; set; }
        public string DateSelector { get; set; }
    }
}
