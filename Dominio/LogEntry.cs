using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }

        public LogEntry()
        {
            
        }
        public LogEntry(string message)
        {
            Timestamp = DateTime.Now;

            Message = message;

        }

    }
}

