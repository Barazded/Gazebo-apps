
namespace News_aggregator.Parser
{
    class IgromaniaSettings : IParserSettings
    {
        public IgromaniaSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://www.igromania.ru/news/";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; } = 5;
    }
}
