﻿using System;
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
    }
}
