using System;

namespace NewsAggregator.Models
{
    [Serializable]
    public class ParserSettings
    {
        public int? Rating { get; set; }
        public string? NameResourse { get; set; }
        public string? UrlResourse { get; set; }
        public string? TitleSelector { get; set; }
        public string? LinkSelector { get; set; }
        public string? InfoSelector { get; set; }
        public string? DateSelector { get; set; }
        //new (user params)
        public string? TypeResourse { get; set; }
        public (string?, string?) UsernameCreator { get; set;}
        public string? DateCreate { get; set; }
        public string? AboutResourse { get; set; }
        public string? LanguageResourse { get; set; }
    }
}
