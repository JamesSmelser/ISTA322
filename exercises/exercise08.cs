// Name: C# Exercise 08
// Author: James Smelser
// Date: August 19, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> thoUsand = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                thoUsand.Add(i);
            }
            Console.WriteLine($"For Human Player Select (1), For Computer Player Select (2)");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                IGuess newplay = new Human();
                newplay.HighLow(thoUsand);
            }
            else if (answer == 2)
            {
                IGuess newplay = new Computer();
                newplay.HighLow(thoUsand);
            }
        }
    }
}
