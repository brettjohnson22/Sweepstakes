using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {        
        //member variables (HAS A)

        //constructor (SPAWNER)

        //member methods (CAN DO)
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Sweepstakes!\n\nAre you registering or managing?");
        }
        public static void PromptFirstName()
        {
            Console.WriteLine("Please Enter Your First Name:");
        }
        public static void PromptLastName()
        {
            Console.WriteLine("Please Enter Your Last Name:");
        }
        public static void PromptEmail()
        {
            Console.WriteLine("Please Enter Your Email Address:");
        }
    }
}
