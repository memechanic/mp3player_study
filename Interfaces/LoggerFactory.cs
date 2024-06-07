using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(char type)
        {
            switch (type){
                case 'f':
                    return new FileLogger();
                case 'c':
                    return new ConsoleLogger();
                default:
                    throw new Exception("No arguments given, requaried 1", new ArgumentNullException());
            }
        }
    }
}
