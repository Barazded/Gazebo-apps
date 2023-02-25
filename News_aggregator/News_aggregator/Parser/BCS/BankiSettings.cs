
namespace News_aggregator.Parser
{
    internal class BankiSettings : IParserSettings
    {
        public string Name { get; set; } = "Banki";
        public string BaseUrl { get; set; } = "https://www.banki.ru/news/lenta/main/?filterType=all";
        public string Type { get; set; } = "экономика";
    }
}
