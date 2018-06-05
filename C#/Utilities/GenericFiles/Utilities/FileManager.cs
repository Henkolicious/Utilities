using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericFiles.Utilities
{    
    public static class FileManager
    {
        #region Public Methods
        public static List<T> LoadFile<T>(string filePath, char dilimiter = ',') where T : class, new()
        {
            try
            {
                var fileContent = System.IO.File.ReadAllLines(filePath).ToList();
                List<T> output = new List<T>();
                T entry = new T();
                var columns = entry.GetType().GetProperties();

                if (fileContent == null || fileContent.Count < 2)
                {
                    throw new IndexOutOfRangeException("The file was either missing or empty.");
                }

                var headers = fileContent[0].Split(dilimiter);
                fileContent.RemoveAt(0);

                foreach (var row in fileContent)
                {
                    entry = new T();
                    var values = row.Split(dilimiter);

                    for (int i = 0; i < headers.Length; i++)
                    {
                        foreach (var column in columns)
                        {
                            if (column.Name == headers[i])
                            {
                                column.SetValue(entry, Convert.ChangeType(values[i], column.PropertyType));
                            }
                        }                        
                    }
                    output.Add(entry);
                }
                
                return output;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void SaveFile<T>(List<T> data, string filePath) where T : class
        {
            try
            {
                List<string> lines = new List<string>();
                StringBuilder line = new StringBuilder();

                if (data == null || data.Count < 1)
                {
                    throw new ArgumentNullException("Data is null or empty", "No data given.");
                }

                var columns = data[0].GetType().GetProperties();

                foreach (var column in columns)
                {
                    line.Append(column.Name).Append(",");
                }

                lines.Add(line.ToString().Substring(0, line.Length - 1));

                foreach (var row in data)
                {
                    line = new StringBuilder();

                    foreach (var column in columns)
                    {
                        line.Append(column.GetValue(row)).Append(",");
                    }
                    lines.Add(line.ToString().Substring(0, line.Length - 1));
                }

                System.IO.File.WriteAllLines(filePath, lines);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        #endregion Public Methods
    }
}
