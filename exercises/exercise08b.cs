// Name: C# Exercise 08b
// Author: James Smelser
// Date: August 19, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise08
{
    class Human : IGuess
    {
        void IGuess.HighLow(List<int> thoUsand)
        {
            int acc = 0;
            Random r = new Random();
            int comNum = r.Next(thoUsand.Count);
            Console.WriteLine($"Enter A Number Between 1-{thoUsand.Count}");
            int myVar = int.Parse(Console.ReadLine());
            while (myVar != comNum)
            {
                if (myVar < comNum)
                {
                    Console.WriteLine($"{myVar} Too Low...Guess Again!");
                    myVar = int.Parse(Console.ReadLine());
                }
                else if (myVar > comNum)
                {
                    Console.WriteLine($"{myVar} Too High...Guess Again!");
                    myVar = int.Parse(Console.ReadLine());
                }
                acc++;
            }
            if (myVar == comNum)
                Console.WriteLine($"{myVar} Congratulations...You Guessed Correctly");
                Console.WriteLine($"It Took You {acc + 1} Guesses");
        }
    }
}
