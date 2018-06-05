using GenericFiles.Models;
using System;
using System.Collections.Generic;

namespace GenericFiles.Helpers
{
    public static class Extentions
    {
        #region Public Methods
        public static void PrintListContent<T>(this List<T> source) where T : class
        {
            if (source is List<Person> persons)
            {
                Console.WriteLine("#### Printing people entries ###");
                PrintPersons(ref persons);
                Console.WriteLine();
            }

            if (source is List<LogEntry> logs)
            {
                Console.WriteLine("### Printing log entries ###");
                PrintLogs(ref logs);
                Console.WriteLine();
            }
        }

        public static List<T> AddMockData<T>(this List<T> source) where T : class
        {
            if (source is List<Person> persons)
            {
                persons = AddMockPersons(ref persons);
            }

            if (source is List<LogEntry> logs)
            {
                logs = AddMockLogs(ref logs);
            }

            return source;
        }
        #endregion Public Methods

        #region Private Methods
        private static void PrintPersons(ref List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        private static void PrintLogs(ref List<LogEntry> logs)
        {
            foreach (var log in logs)
            {
                Console.WriteLine($"Date {log.Date}\nContent: {log.Content}");
                Console.WriteLine();
            }
        }        

        private static List<Person> AddMockPersons(ref List<Person> source)
        {
            source.Add(new Person { FirstName = "Person", LastName = "1" });
            source.Add(new Person { FirstName = "Person", LastName = "2" });
            source.Add(new Person { FirstName = "Person", LastName = "3" });
            return source;
        }

        private static List<LogEntry> AddMockLogs(ref List<LogEntry> source)
        {
            source.Add(new LogEntry { Date = DateTime.Now.ToString(), Content = "Log entry 1" });
            source.Add(new LogEntry { Date = DateTime.Now.ToString(), Content = "Log entry 2" });
            source.Add(new LogEntry { Date = DateTime.Now.ToString(), Content = "Log entry 3" });
            return source;
        }
        #endregion Private Methods
    }
}
