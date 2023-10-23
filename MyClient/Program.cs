using MyCodeLibrary;


Scrape myScrape = new Scrape();
string result = myScrape.ScrapeWebPage("http://msdn.microsoft.com", @"C:\demo\ScrapWebPage.txt");

Console.WriteLine(result);