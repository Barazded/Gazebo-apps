using NewsAggregator.Models;
using System.Collections.Generic;

namespace NewsAggregator.Pages
{
    public partial class OutputPage : ContentPage
    {
        public OutputPage(List<Card> cards)
        {
            InitializeComponent();
            var infoCards = "";
            for (int i = 0; i < cards.Count; i++)
            {
                var card = $"Card{i + 1}\r\n{{\r\n\ttitle = \"{cards[i].Title}\",\r\n\tlink = \"{cards[i].Link}\",\r\n\tinfo =" +
                    $" \"{cards[i].Info}\",\r\n\tdate = \"\",\r\n}};";
                infoCards += "\n" + card;
            }
            output_editor.Text = infoCards;
        }
    }
}