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
        public static void SweepstakesName()
        {
            Console.WriteLine("What will you call the new sweepstakes?");
        }
        public static void SweepstakesOptions()
        {
            Console.WriteLine("'Use' this sweepstakes or 'store' sweepstakes and create another?");
        }
        public static void UsingSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine($"Using Sweepstakes called {sweepstakes.name}");
        }
        public static void RegisterOrDraw()
        {
            Console.WriteLine("'Add' contestant to this sweepstakes or 'draw' a winner?");
        }
        public static void Congratulations(string winner)
        {
            Console.WriteLine($"Congrats, {winner}! You won the sweepstakes!");
        }
        public static void NotAWinner(string winner)
        {
            Console.WriteLine($"Unfortunately, {winner} won this sweepstakes. Try again!");
        }
    }
}
