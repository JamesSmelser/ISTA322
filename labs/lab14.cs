// Name: C# Lab14
// Author: James Smelser
// Date: August 12, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
