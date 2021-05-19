/*
 * Author       : Aamir Shabbir Parre
 * Description  : Lab Sessional-2 for BSSE 7(A,B)
 * Date         : 6th May, 2021
 * Location     : G-11/4 Home, Islamabad
*/

using System.Linq;
using System.Xml.Linq;

namespace OOPBasics.DesignPatterns
{
    //A private univsersity, 10 Years before developed a software that uses xml data format to transfer over the internet.
    //XML, the king of that era was only the choice with no competition in the market for software designers.

    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Students");
            var xAttributes = StudentDataProvider.GetData()
                .Select(s => new XElement("Student",
                                    new XAttribute("Id", s.Id),
                                    new XAttribute("Name", s.Name),
                                    new XAttribute("Email", s.Email)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
