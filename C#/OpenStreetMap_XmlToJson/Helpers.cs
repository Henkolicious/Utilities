using System;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace XMLtoJSON.Helpers
{
    public static class Extentions
    {
        public static string XmlToJson(this string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
        }

        public static string PrettyJson(this string json)
        {
            dynamic parsedJson = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            return Newtonsoft.Json.JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
        }        
    }
}