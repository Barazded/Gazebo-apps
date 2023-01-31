namespace Parser_html.Core
{
    internal interface IParserSettings
    {
        string BaseUrl { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
