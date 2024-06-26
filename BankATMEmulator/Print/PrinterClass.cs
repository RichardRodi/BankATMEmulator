﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATMEmulator.Print
{
    public static class PrinterClass
    {
        public static string IndentAndReadLine(string prompt, int indentLevel)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            string indent = new string(' ', indentLevel);
            Console.Write(indent + prompt + " ");
            return Console.ReadLine();
        }
    }
}
