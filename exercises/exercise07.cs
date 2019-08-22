// Name: C# Exercise 07
// Author: James Smelser
// Date: August 17, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                new Utility();
                while (Console.KeyAvailable == false)
                    Thread.Sleep(250);
                    cki = Console.ReadKey(true);
            }
            while (cki.Key != ConsoleKey.Spacebar);
        }
    }
}

