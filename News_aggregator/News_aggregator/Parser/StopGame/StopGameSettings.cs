
namespace News_aggregator.Parser
{
    internal class StopGameSettings : IParserSettings
    {
        public string Name { get; set; } = "StopGame";
        public string BaseUrl { get; set; } = "https://stopgame.ru/news";
        public string Type { get; set; } = "игры";
    }
}
