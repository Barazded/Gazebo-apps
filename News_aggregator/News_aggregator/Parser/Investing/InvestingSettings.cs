
namespace News_aggregator.Parser
{
    internal class InvestingSettings : IParserSettings
    {
        public InvestingSettings(int end)
        {
            EndPoint = end;
        }
        public string Name { get; set; } = "Investing";
        public string BaseUrl { get; set; } = "https://ru.investing.com/news/";
        public int EndPoint { get; set; }
    }
}
