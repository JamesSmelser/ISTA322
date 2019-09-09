using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class GetUser : UsersDB
    {
        public void getUser()
        {
        Console.Write($"Authenticate your name: ");
            string name = Console.ReadLine();
        Console.Write($"Authenticate your password: ");
            Crypto hash = new Crypto();
            string pw = hash.getCrypto(Console.ReadLine());
            foreach (var pair in daTa) 
            if (daTa.ContainsKey(name) && daTa.ContainsValue(pw))
            {
                Console.WriteLine($"****User Authenticated****");
            }
            else
                Console.WriteLine($"****Invalid Username/Password****");
        }
    }
}
