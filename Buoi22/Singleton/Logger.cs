using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class Logger
    {
        public void LogMessage
        {
            Console.WriteLine("Logging message at " + DateTime.Now);
        }
    }
}


