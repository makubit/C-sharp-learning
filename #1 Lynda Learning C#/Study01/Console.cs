using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    class Console
    {
        public static string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        public static string Ask(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new FormatException("Custom Format Exception");
            }

        }
    }
}
