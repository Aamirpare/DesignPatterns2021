using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOPBasics.Adapter.StockApplication
{
    //Adapter Interface
    public interface IStockManager
    {
        string GetStockData();
    }

    //Stock Adapter to resolve the interface incompatibility
    public class StockAdapter : StockManager, IStockManager
    {
        public override string GetStockData()
        {
            string xmlData = base.GetStockData();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            
            return Newtonsoft.Json.JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
    
}
