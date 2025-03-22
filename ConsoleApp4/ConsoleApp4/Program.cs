using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = GetLogger("db");
            log.Log();

            ILoggerInterface logger = GetLoggerInterface("cloud");
            logger.Log();
        }
        private static Logger GetLogger(string type)
        {
            if (type == "db")
            {
                return new LogDb();
            }
            else if (type == "cloud")
            {
                return new LogCloud();
            }

            return new LogFile();
        }
        private static ILoggerInterface GetLoggerInterface(string type)
        {
            if (type == "db")
            {
                return new LogDbInterface();
            }
            else if (type == "cloud")
            {
                return new LogCloudInterface();
            }

            return new LogFileInterface();
        }

    }
    
}
