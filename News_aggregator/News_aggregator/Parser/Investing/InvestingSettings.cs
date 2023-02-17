
namespace News_aggregator.Parser
{
    internal class InvestingSettings : IParserSettings
    {
        public InvestingSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string Name { get; set; } = "Investing";
        public string BaseUrl { get; set; } = "https://ru.investing.com/news/";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; } = 5;
    }
}
