using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ReaderDocument
{
    public class XmlReader : IReader
    {
        public IEnumerable<string> Reader(string path)
        {
            var xdoc = XDocument.Load(path);
            var nodes = xdoc.Nodes();

            var elements = nodes.Select(x => x.ToString());

            return elements;
        }

    }
}
