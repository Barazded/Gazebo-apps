
namespace News_aggregator.Parser
{
    internal class IXBTGamesSettings : IParserSettings
    {
        public string Name { get; set; } = "IXBTGames";
        public string BaseUrl { get; set; } = "https://ixbt.games/news/";
        public string Type { get; set; } = "игры";
    }
}
