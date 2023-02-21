namespace News_aggregator.Parser
{
    internal interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Name { get; set; }
        int EndPoint { get; set; }
    }
}
