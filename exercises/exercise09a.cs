using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class PrintUI
    {
        public static void printUI()
        {
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine($"PASSWORD AUTHENTICATION SYSTEM");
                Console.WriteLine($"\n");
                Console.WriteLine($"Please select one option:");
                Console.WriteLine($"\n");
                Console.WriteLine($"1. Establish an account");
                Console.WriteLine($"2. Authenticate a user");
                Console.WriteLine($"3. Print users");
                Console.WriteLine($"\n");
                Console.WriteLine($"[Enter 0 to exit the system]");
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine($"\n");
                Console.Write($"Enter selection: ");
                string response = Console.ReadLine();
                UserResponse choice = new UserResponse();
                choice.userResponse(response);
        }
    }
}
