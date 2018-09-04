using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft;
using XMLtoJSON.Helpers;

namespace XMLtoJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Purpos
                // Converting XML data from Open Street Map to JSON

                // 1.6M rows with pretty print ~= 50s
                // 1.6M rows without pretty print ~= 12s and takes about half the disk size

                Stopwatch sw = Stopwatch.StartNew();
                string outputFileName = @"C:\temp\map.json"; // define output file name and path
                string xml = GetXmlDataFromFile("map"); // extract uppsala-map.rar first
                string contents = xml.XmlToJson().PrettyJson(); // remove pretty json extention for faster execution
                SaveToFile(outputFileName, contents);
                sw.Stop();
                Console.WriteLine($"Done! Duration: {sw.ElapsedMilliseconds / 1000}s");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static string GetXmlDataFromFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            var lines = File.ReadAllLines(fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                sb.Append(lines[i]);
            }
            return sb.ToString();
        }

        private static void SaveToFile(string fileName, string contents)
        {
            System.IO.File.WriteAllText(fileName, contents);
        }
    }
}
