using System.Xml;
using Newtonsoft.Json;

namespace OOPBasics.Adapter.StockApplication
{
    //Stock Adapter to resolve the interface incompatibility
    public class StockAdapter : StockManager, IStockManager
    {
        public override string GetStockData()
        {
            string xmlData = base.GetStockData();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
    
}
