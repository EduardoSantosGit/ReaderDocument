using System;
using System.Collections.Generic;
using System.Text;

namespace ReaderDocument
{
    public interface IReader
    {
        IEnumerable<string> Reader(string path);
    }
}
