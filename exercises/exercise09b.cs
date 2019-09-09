using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class UserResponse : PrintUI 
    {
        
        public void userResponse(string response)
        {
            while (response != "0")
            {
                if (response == "1")
                {
                   GetNewUser now = new GetNewUser();
                   now.getNewUser();
                   printUI();
                }
                else if (response == "2")
                {
                   GetUser last = new GetUser();
                   last.getUser();
                   printUI();
                }
                else if (response == "3")
                {
                   PrintUsers all = new PrintUsers();
                   all.printUsers();
                   printUI();
                }
                else
                {
                   Console.WriteLine($"Please enter a valid number selection!");
                   printUI();
                }
            }
            Environment.Exit(0);
        }
    }
}
