using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Message : IMessage
    {
        public string? Header { get; set; }
        public string Content { get; set; }

        public Message(string header, string content)
        {
            Header = header;
            Content = content;
        }
    }
}
