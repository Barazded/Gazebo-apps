namespace News_aggregator.Parser
{
    internal interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Name { get; set; }
        string Type { get; set; }//еconomy games
    }
}
