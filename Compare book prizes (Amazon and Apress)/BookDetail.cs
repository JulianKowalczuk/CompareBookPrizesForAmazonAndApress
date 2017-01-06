namespace CompareBookPrizesForAmazonAndApress
{
    using System;
    public class BookDetail
    {
        public bool Found { get; set; } = false;
        public double PriceUSD { get; set; }
        public string Title { get; set; } = " -";
        public string BuyLink { get; set; }
        public string GetFullPrize(double? rate)
        {
            if (Found)
            {
                var fullPrize = PriceUSD + " $";
                if (rate.HasValue)
                {
                    fullPrize += " (" + Math.Round(PriceUSD * (double)rate, 2) + " zł)";
                }
                return fullPrize;
            }
            return " -";
        }

        public void SetTitle(string title)
        {
            if (title.Length > 95)
            {
                Title = title.Substring(0, 92) + "...";
                return;
            }
            Title = title;
        }
    }
}
