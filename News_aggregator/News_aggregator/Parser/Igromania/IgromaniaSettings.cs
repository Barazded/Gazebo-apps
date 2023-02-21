
namespace News_aggregator.Parser
{
    class IgromaniaSettings : IParserSettings
    {
        public IgromaniaSettings(int end)
        {
            EndPoint = end;
        }
        public string Name { get; set; } = "Igromania";
        public string BaseUrl { get; set; } = "https://www.igromania.ru/news/";
        public int EndPoint { get; set; }
    }
}
