using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class PrintUsers : UsersDB
    {
        public void printUsers()
        {
            Console.WriteLine($" NAME || PASSWORD");
            foreach (var pair in daTa)
            {
                Console.WriteLine($"{pair.Key} || {pair.Value}");
            }
        }
    }
}
