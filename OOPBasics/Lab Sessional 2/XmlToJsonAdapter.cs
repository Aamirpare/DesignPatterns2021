/*
 * Author       : Aamir Shabbir Parre
 * Description  : Lab Sessional-2 for BSSE 7(A,B)
 * Date         : 6th May, 2021
 * Location     : G-11/4 Home, Islamabad
*/
using System;
using System.Linq;

namespace OOPBasics.DesignPatterns
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        XmlConverter XmlConverter { get; }
        public XmlToJsonAdapter( XmlConverter xmlConverter)
        {
            XmlConverter = xmlConverter;
        }
        public string ConvertXmlToJson()
        {
            var students = XmlConverter.GetXML()
                 .Element("Students")
                 .Elements("Student")
                 .Select(s => new Student 
                 { 
                    Id = Convert.ToInt32(s.Attribute("Id").Value),
                    Name = s.Attribute("Name").Value,
                    Email = s.Attribute("Email").Value
                 });
            var jsonConverter = new JsonConverter(students);
            return jsonConverter.ToJson();
        }
    }
}
