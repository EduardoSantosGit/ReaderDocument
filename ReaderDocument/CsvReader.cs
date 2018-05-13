using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReaderDocument
{
    public class CsvReader
    {
        public IEnumerable<string> Reader(string fileName)
        {
            var listAccessKey = new List<string>();
            var file = new StreamReader(fileName);
            string line;

            while ((line = file.ReadLine()) != null)
            {
                if (!string.IsNullOrWhiteSpace(line) && !string.IsNullOrEmpty(line))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        listAccessKey.Add(line);
                    }
                }
            }
            file.Close();
            return listAccessKey;
        }

    }
}
