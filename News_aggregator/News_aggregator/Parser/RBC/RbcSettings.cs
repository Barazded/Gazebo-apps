
namespace News_aggregator.Parser
{
    internal class RbcSettings : IParserSettings
    {
        public RbcSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string Name { get; set; } = "RBC";
        public string BaseUrl { get; set; } = "https://www.rbc.ru/neweconomy/";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; } = 5;
    }
}
