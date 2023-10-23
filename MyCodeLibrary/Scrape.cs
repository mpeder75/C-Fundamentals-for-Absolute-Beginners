using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {

        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);           
        }

        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }


        // Private method der opsætter WebClient, som downloader en webpage via url
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

    }
}