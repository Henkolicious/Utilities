using GenericFiles.Models;
using GenericFiles.Helpers;
using System;
using System.Collections.Generic;
using GenericFiles.Utilities;

namespace GenericFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericExample();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// This example only supports .csv files at the moment
        /// and also requires that the given directory exists.
        /// </summary>
        public static void GenericExample() 
        {
            List<Person> persons = new List<Person>().AddMockData();
            List<LogEntry> logs = new List<LogEntry>().AddMockData();

            string personFilePath = @"C:\Temp\persons.csv";
            string logsFilePath = @"C:\Temp\logs.csv";

            FileManager.SaveFile(persons, personFilePath);
            FileManager.SaveFile(logs, logsFilePath);

            List<Person> personsFromDisk = FileManager.LoadFile<Person>(personFilePath);
            List<LogEntry> logsFromDisk = FileManager.LoadFile<LogEntry>(logsFilePath);

            personsFromDisk.PrintListContent();
            logsFromDisk.PrintListContent();
        }
    }
}
