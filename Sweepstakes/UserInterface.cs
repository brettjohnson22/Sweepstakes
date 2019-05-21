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
            Console.WriteLine("Welcome to Sweepstakes Manager.");
        }
        public static void PromptFirstName()
        {
            Console.WriteLine("Please Enter Contestant First Name:");
        }
        public static void PromptLastName()
        {
            Console.WriteLine("Please Enter Contestant Last Name:");
        }
        public static void PromptEmail()
        {
            Console.WriteLine("Please Enter Contestant Email Address:");
        }
        public static void PromptManager()
        {
            Console.WriteLine("Will you use Stack or Queue?");
        }
        public static void SweepstakesOptions()
        {
            Console.WriteLine("Choose 'insert' sweepstakes or 'get' sweepstakes.");
        }
    }
}
