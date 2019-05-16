using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.IO;
namespace Openssl_study
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlData = File.ReadAllText(@"C:\Users\choi\Desktop\setup.xml");
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xmlData);

        }
    }
}
