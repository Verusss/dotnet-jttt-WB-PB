using HtmlAgilityPack;
using System;
using System.Net;
using System.Text;

public class HtmlSample
{
    private readonly string _url;

	public HtmlSample(string url)
	{
        this._url = url;
	}

    public string GetPageHtml()
    {
        using (var wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8;
            var html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(_url));

            return html;
        }
    }

    public string FindByWord(string Word, int count)
    {
        var doc = new HtmlDocument();
        var pageHtml = GetPageHtml();
        doc.LoadHtml(pageHtml);
        var nodes = doc.DocumentNode.Descendants("img");
        string title;
        foreach (var node in nodes)
        {
            title = node.GetAttributeValue("alt", "");
            if (title.Contains(Word))
            {
                Console.WriteLine("Alt value: " + node.GetAttributeValue("alt", ""));
                Console.WriteLine("Src value: " + node.GetAttributeValue("src", ""));
                string fileName = node.GetAttributeValue("alt", "").Replace(" ", "_")+count, myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = node.GetAttributeValue("src", "");
                myWebClient.DownloadFile(myStringWebResource, fileName);
                return fileName;
            }  
        }
        return "";
    }
}
