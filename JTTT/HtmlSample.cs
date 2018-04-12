using HtmlAgilityPack;
using System;
using System.IO;
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
            string html = "";
            wc.Encoding = Encoding.UTF8;
            try
            {
                html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(_url));
            }
            catch (System.Net.WebException)
            {
                html = "";
            }

            return html;
        }
    }

    public string FindByWord(string Word, string Path, string Url)
    {
        var doc = new HtmlDocument();
        var pageHtml = GetPageHtml();
        if (pageHtml == "")
            return "";
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
                WebClient myWebClient = new WebClient();
                string myStringWebResource = null;
                myStringWebResource = node.GetAttributeValue("src", null);
                if (myStringWebResource != null)
                {
                    if (!myStringWebResource.Contains("http"))
                        myStringWebResource = Url + myStringWebResource;
                    myWebClient.DownloadFile(myStringWebResource, Path);
                    if (File.Exists(Path))
                        return Path;
                }                    
            }  
        }
        return "";
    }
}
