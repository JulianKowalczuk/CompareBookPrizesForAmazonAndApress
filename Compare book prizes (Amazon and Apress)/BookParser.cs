namespace CompareBookPrizesForAmazonAndApress
{
    using HtmlAgilityPack;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    class BookParser
    {
        private const string apressPriceRegexPattern = @"(\$)[0-9]+(\.)?[0-9]?[0-9]?";

        public BookDetail AmazonParseContent(HtmlNode node)
        {
            var book = new BookDetail();
            var detailLink = node.SelectSingleNode("//a[@class[contains(., 's-access-detail-page')]]");
            var priceWhole = node.SelectSingleNode("//span[@class='sx-price-whole']");
            var priceFractional = node.SelectSingleNode("//sup[@class='sx-price-fractional']");
            if (detailLink == null || priceWhole == null || priceFractional == null)
            {
                return null;
            }
            book.SetTitle(detailLink.InnerText);
            book.BuyLink = detailLink.GetAttributeValue("href", "");
            book.PriceUSD = Double.Parse(priceWhole.InnerHtml + "." + priceFractional.InnerHtml,
                                CultureInfo.InvariantCulture);
            book.Found = true;
            return book;
        }

        public BookDetail ApressParseContent(HtmlNode node)
        {
            var book = new BookDetail();
            var title = node.SelectSingleNode("//div[@class[contains(., 'main-information')]]//h1");
            var renditions = node.SelectNodes("//dt[@class[contains(., 'buy-rendition')]]");
            if (title == null || !renditions.Any())
            {
                return null;
            }
            var cover = renditions.FirstOrDefault(x => x.InnerText.Contains("Softcover"));
            if (cover == null)
            {
                cover = renditions.FirstOrDefault(x => x.InnerText.Contains("Hardcover"));
                if (cover == null)
                {
                    return null;
                }
            }
            book.SetTitle(title.InnerText);
            var match = Regex.Match(cover.InnerText, apressPriceRegexPattern).Value;
            book.PriceUSD = Double.Parse(match.Substring(1, match.Length - 1), CultureInfo.InvariantCulture);
            book.Found = true;
            return book;
        }
    }
}
