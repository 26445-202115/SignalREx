using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalREx.Models
{
    public class ChatMessage
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public DateTimeOffset TimeStamp { get; set; }

    }
}
