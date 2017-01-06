namespace CompareBookPrizesForAmazonAndApress
{
    using HtmlAgilityPack;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Net;
    using System.Net.Http;
    using System.Net.NetworkInformation;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class ServersCommunication
    {
        private const string usdPlnRateFixerUrl = "http://api.fixer.io/latest?symbols=USD,PLN";
        private HttpClient httpClient;
        public ServersCommunication()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");
        }

        public async Task<BookDetail> GetResponseFromServer(string number, string serverName,
             string pathFormat, string xPathMainNode, Func<HtmlNode, BookDetail> parseAction)
        {
            var path = string.Format(pathFormat, number);
            if (!await isServerConnectionAlive(path))
            {
                MessageBox.Show("Couldn't connect to " + serverName + " server.");
                return new BookDetail();
            }
            var document = new HtmlAgilityPack.HtmlDocument();
            var content = await getContentLikeBrowser(path);
            if (content != null)
            {
                document.LoadHtml(content);
                var result = document.DocumentNode.SelectSingleNode(xPathMainNode);
                if (result != null)
                {
                    return parseAction(result);
                }
            }
            return new BookDetail();
        }

        private async Task<string> getContentLikeBrowser(string url)
        {
            var response = await httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            using (var responseStream = await response.Content.ReadAsStreamAsync())
            using (var decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
            using (var streamReader = new StreamReader(decompressedStream))
            {
                return await streamReader.ReadToEndAsync();
            }
        }

        private async Task<bool> isServerConnectionAlive(string path)
        {
            var ping = new Ping();
            var uri = new Uri(path);
            var ipAdress = await Dns.GetHostAddressesAsync(uri.Host);
            try
            {
                var reply = ping.Send(ipAdress[0]);
                return reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<double?> GetUsdRate()
        {
            if (!await isServerConnectionAlive(usdPlnRateFixerUrl))
            {
                return default(double);
            }
            var response = await httpClient.GetAsync(usdPlnRateFixerUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(content);
                return (double)json["rates"]["PLN"] / (double)json["rates"]["USD"];
            }
            else
            {
                MessageBox.Show("Couldn't get current USD rate from Fixer.io");
                return null;
            }
        }
    }
}
