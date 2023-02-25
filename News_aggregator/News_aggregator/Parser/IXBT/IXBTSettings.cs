
namespace News_aggregator.Parser
{
    internal class IXBTSettings : IParserSettings
    {
        public string Name { get; set; } = "IXBT";
        public string BaseUrl { get; set; } = "https://www.ixbt.com/news/?show=tape";
        public string Type { get; set; } = "наука и технологии";
    }
}
