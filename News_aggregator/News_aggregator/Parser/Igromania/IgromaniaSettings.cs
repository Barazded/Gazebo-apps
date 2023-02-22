
namespace News_aggregator.Parser
{
    class IgromaniaSettings : IParserSettings
    {
        public string Name { get; set; } = "Igromania";
        public string BaseUrl { get; set; } = "https://www.igromania.ru/news/";
    }
}
