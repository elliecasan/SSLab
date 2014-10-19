using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using SS.Lib.Service;


namespace SS.Lib.Model
{
    public abstract class NameBase:IScreenService
    {
        
        public Name GetName(string input)
        {
            HtmlWeb htmlWeb= new HtmlWeb();
            string url = string.Format(this.Url, input);
            HtmlDocument doc = htmlWeb.Load(url);

            var name = new Name
            {
                FullName = doc.DocumentNode.SelectSingleNode(@"id('hit-list')/li/article/header/div[2]/h2/span/a").InnerHtml,
               
            };

            return name;
        }

        public abstract string Url { get; }


    }
}
