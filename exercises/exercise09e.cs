using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class GetNewUser : UsersDB
    {
        public void getNewUser()
        {
        Console.Write($"Enter your name: ");
            string name = Console.ReadLine();
        Console.Write($"Enter your password: ");
            Crypto hash = new Crypto();
            string pw = hash.getCrypto(Console.ReadLine());
            daTa.Add(name, pw);
        }
    }
}
