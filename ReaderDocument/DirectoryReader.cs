using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReaderDocument
{
    public class DirectoryReader : IReader
    {

        public IEnumerable<string> Reader(string path)
        {
            List<String> files = new List<String>();
            foreach (string f in Directory.GetFiles(path))
            {
                files.Add(f);
            }
            foreach (string d in Directory.GetDirectories(path))
            {
                files.AddRange(Reader(d));
            }
            return files;
        }

    }
}
