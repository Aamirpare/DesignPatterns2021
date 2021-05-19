/*
 * Author       : Aamir Shabbir Parre
 * Description  : Lab Sessional-2 for BSSE 7(A,B)
 * Date         : 6th May, 2021
 * Location     : G-11/4 Home, Islamabad
*/

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OOPBasics.DesignPatterns
{
    //Over the time the JSON (Java Script Object Notation) data format option became available
    //and put a strong competition in deciding between XML and JSON.
    //The sofware industry embraced the JSON and started converting XML to JSON
    //because it's light weight and saves a lot of bandwidth in case of internet transfers. 
    public class JsonConverter
    {
        IEnumerable<Student> Students;
        public JsonConverter(IEnumerable<Student> students)
        {
            Students = students;
        }
        public string ToJson()
        {
            var jsonResult = JsonConvert.SerializeObject(Students, Formatting.Indented);
            return jsonResult;
        }
    }
}
