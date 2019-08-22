// Name: C# Exercise 08c
// Author: James Smelser
// Date: August 19, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise08
{
    class Computer : IGuess
    {
        void IGuess.HighLow(List<int> thoUsand)
        {
            int acc = 0;
            Console.WriteLine($"Select a number from 1-{thoUsand.Count}");
            int nUm = int.Parse(Console.ReadLine());
            int iG = thoUsand[(thoUsand.Count - 1) / 2];
            while (iG != nUm)
            {
                iG = thoUsand[(thoUsand.Count - 1) / 2];
                if (iG < nUm)
                {
                    Console.WriteLine($"{iG} Too Low...Guess Again!");
                    thoUsand.RemoveRange(0, (thoUsand.Count - 1) - thoUsand.IndexOf(iG));
                }
                else if (iG > nUm)
                {
                    Console.WriteLine($"{iG} Too High...Guess Again!");
                    thoUsand.RemoveRange(thoUsand.IndexOf(iG), (thoUsand.Count - 1) - thoUsand.IndexOf(iG));
                }
                acc++;
            }
            if (iG == nUm)
                Console.WriteLine($"{iG} Congratulations...You Guessed Correctly");
                Console.WriteLine($"It Took You {acc} Guesses");
        }
    }
}
