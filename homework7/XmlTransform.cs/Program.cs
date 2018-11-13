using System;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.IO;


namespace XmlTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\a.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\a.xslt");

                FileStream outFileStream = File.OpenWrite(@"..\..\BoolList.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);

            }
            catch(XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch(XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }
    }
}
