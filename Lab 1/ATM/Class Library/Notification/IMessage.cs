using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public interface IMessage
    {
        public string? Header { get; set; }
        public string Content { get; set; }
    }
}
