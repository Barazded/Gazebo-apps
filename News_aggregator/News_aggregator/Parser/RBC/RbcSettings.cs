
namespace News_aggregator.Parser
{
    class RbcSettings : IParserSettings
    {
        public string Name { get; set; } = "RBC";
        public string BaseUrl { get; set; } = "https://www.rbc.ru/neweconomy/";
        public string Type { get; set; } = "экономика";
    }
}
