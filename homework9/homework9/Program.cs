using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections;
using System.Net;
using System.Text.RegularExpressions;

namespace homework9
{
    public class Crawler 
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string startUrl = "http://www.baidu.com/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);

            Action[] actions = { new Action(myCrawler.Crawl), myCrawler.Crawl };
            Parallel.Invoke(actions);
            new Thread(myCrawler.Crawl).Start();

        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了....");
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;

                Console.WriteLine("爬行" + current + "页面!");

                string html = DownLoad(current);
                urls[current] = true;
                count++;

                Parse(html);
            }
            Console.WriteLine("爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HERF)[]* = []*[""'][^""'#>] + [""']";
            
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef=match.Value.Substring(match.Value.IndexOf('=')+1).Trim('"', '\"', '#',' ', '>');
                if (strRef.Length == 0) continue;

                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

    }
}
