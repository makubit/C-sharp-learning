using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study01
{
    class Logger
    {
        private const string DefaultSystemName = "School Tracker"; //constant is static by default
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system, priority, msg);
        }
    }
}
