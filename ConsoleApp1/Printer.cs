﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.ResetColor();
            Console.WriteLine(value);
        }
    }
}
