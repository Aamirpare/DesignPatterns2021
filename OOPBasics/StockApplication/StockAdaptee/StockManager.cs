using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace OOPBasics.Adapter.StockApplication
{
    public class StockManager
    {
        List<StockData> StockData { get; set; } = new List<StockData>() 
        { 
            new StockData{ SharePrice = 90, Company = "Red Gates"},
            new StockData{ SharePrice = 120, Company = "Microsoft"},
            new StockData{ SharePrice = 100, Company = "Google"},
            new StockData{ SharePrice = 65, Company = "Facebook"},
        };
        public virtual string GetStockData()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            XmlSerializer xmlSerializer = new XmlSerializer(StockData.GetType());
            var settings = new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true};
            
            //var stream = new MemoryStream(); //File.Create("D:/stockData.xml");

            using (var stream = new StringWriter())
            {
                using (var writter = XmlWriter.Create(stream, settings))
                {
                    xmlSerializer.Serialize(writter, StockData, emptyNamespaces);
                }
                return stream.ToString();
            }
        }
    }
}
