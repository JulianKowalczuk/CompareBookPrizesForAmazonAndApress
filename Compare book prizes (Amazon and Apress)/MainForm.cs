namespace CompareBookPrizesForAmazonAndApress
{
    #region namespaces
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Windows.Forms;
    using HtmlAgilityPack;
    using System.Net;
    using System.Threading.Tasks;
    using System.IO.Compression;
    using System.IO;
    using System.Globalization;
    using System.Drawing;
    using Newtonsoft.Json.Linq;
    using System.Text.RegularExpressions;
    using System.Text;
    using System.Threading;
    using System.Net.NetworkInformation;
    #endregion

    public partial class MainForm : Form
    {
        private const int isbnCodeLenght = 13;
        private const string amazonFindByIsbnFormat = "https://www.amazon.com/s/search/ref=sr_adv_b/?"
                         + "search-alias=stripbooks&field-isbn={0}&field-p_n_condition-type=1294423011";
        private const string apressGetByIsbnFormat = "http://www.apress.com/us/book/{0}";
        private static readonly Color lightRed = Color.FromArgb(255, 128, 128);
        private static readonly Color lightGreen = Color.FromArgb(128, 255, 128);

        private BookDetail amazonBook, apressBook;
        private ServersCommunication serversCommunication;
        private BookParser bookParser;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            serversCommunication = new ServersCommunication();
            bookParser = new BookParser();
            amazonStoreButton.Click += delegate
            {
                openLink(amazonBook.BuyLink);
            };
            apressStoreButton.Click += delegate
            {
                openLink(apressBook.BuyLink);
            };
        }

        private async void isbnButtonClick(object sender, EventArgs e)
        {
            await processBookComparing();
        }

        private async Task processBookComparing()
        {
            Cursor = Cursors.WaitCursor;
            var number = isbnEntry.Text;
            if (!isInputValidIsbn(ref number))
            {
                MessageBox.Show("Type valid ISBN number", "Invalid ISBN");
                return;
            }
            amazonBook = await serversCommunication.GetResponseFromServer(number, "Amazon", amazonFindByIsbnFormat,
                                "//li[@id='result_0']", bookParser.AmazonParseContent);
            apressBook = await serversCommunication.GetResponseFromServer(number, "Apress", apressGetByIsbnFormat,
                                "//div[@id='content']", bookParser.ApressParseContent);
            // buylink for Amazon is setting in AmazonParseContent
            apressBook.BuyLink = string.Format(apressGetByIsbnFormat, number);
            fillFieldsAndCompare();
            Cursor = Cursors.Default;
        }

        private async void fillFieldsAndCompare()
        {
            var usdRate = await serversCommunication.GetUsdRate();
            isbnResetButton.Enabled = true;
            amazonTitleLabel.Text = amazonBook.Title;
            amazonPriceLabel.Text = amazonBook.GetFullPrize(usdRate);
            amazonStoreButton.Enabled = amazonBook.Found;
            apressTitleLabel.Text = apressBook.Title;
            apressPriceLabel.Text = apressBook.GetFullPrize(usdRate);
            apressStoreButton.Enabled = apressBook.Found;
            if (amazonBook.Found && apressBook.Found)
            {
                if (amazonBook.PriceUSD == apressBook.PriceUSD)
                {
                    amazonPanel.BackColor = apressPanel.BackColor = lightGreen;
                    return;
                }
                var isAmazonBookCheaper = amazonBook.PriceUSD < apressBook.PriceUSD;
                amazonPanel.BackColor = isAmazonBookCheaper ? lightGreen : lightRed;
                apressPanel.BackColor = isAmazonBookCheaper ? lightRed : lightGreen;
                amazonStoreButton.Enabled = apressStoreButton.Enabled = true;
                return;
            }
            if (amazonBook.Found != apressBook.Found)
            {
                amazonPanel.BackColor = amazonBook.Found ? lightGreen : lightRed;
                apressPanel.BackColor = apressBook.Found ? lightGreen : lightRed;
                amazonStoreButton.Enabled = amazonBook.Found;
                apressStoreButton.Enabled = apressBook.Found;
                return;
            }
            amazonPanel.BackColor = apressPanel.BackColor = lightRed;
            amazonStoreButton.Enabled = apressStoreButton.Enabled = false;
        }

        private bool isInputValidIsbn(ref string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            s = s.Replace(" ", string.Empty).Replace("-", string.Empty);
            if (s.Length != isbnCodeLenght || !s.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        private void isbnResetButtonClick(object sender, EventArgs e)
        {
            isbnEntry.Text = string.Empty;
            amazonPanel.BackColor = apressPanel.BackColor = Color.FromKnownColor(KnownColor.Control);
            amazonTitleLabel.Text = amazonPriceLabel.Text
            = apressTitleLabel.Text = apressPriceLabel.Text = " -";
            amazonStoreButton.Enabled = apressStoreButton.Enabled = false;
            isbnResetButton.Enabled = false;
        }

        private void openLink(string url)
        {
            if (url != null)
            {
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
