/*
 * Author       : Aamir Shabbir Parre
 * Description  : Lab Sessional-2 for BSSE 7(A,B)
 * Date         : 6th May, 2021
 * Location     : G-11/4 Home, Islamabad
*/
using System;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.DesignPatterns
{
    public static class Demo
    {
        //After Adapter Implementation. 
        public static void Main_(string[] args)
        {
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            var json = adapter.ConvertXmlToJson();
            Console.WriteLine(json);
            Console.ReadKey();
        }

        //Without Adapter Pattern
        public static void Main__(string[] args)
        {
            var xml = new XmlConverter();
            Console.WriteLine(xml.GetXML());

            Console.WriteLine();

            var students = StudentDataProvider.GetData();
            var json = new JsonConverter(students);

            Console.WriteLine(json.ToJson());

            Console.ReadKey();
        }

    }
}
