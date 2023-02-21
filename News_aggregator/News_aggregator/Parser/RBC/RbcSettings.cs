
namespace News_aggregator.Parser
{
    internal class RbcSettings : IParserSettings
    {
        public RbcSettings(int end)
        {
            EndPoint = end;
        }
        public string Name { get; set; } = "RBC";
        public string BaseUrl { get; set; } = "https://www.rbc.ru/neweconomy/";
        public int EndPoint { get; set; }
    }
}
