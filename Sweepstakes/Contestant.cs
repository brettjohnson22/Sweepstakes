using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant 
    {
        //member variables (HAS A)
        private string firstName;
        private string lastName;
        private string email;
        public double registration;
        public bool won;

        public string Name
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public string Email { get { return email; } }

        //constructor (SPAWNER)
        public Contestant()
        {
            AssignInfo();
        }

        //member methods (CAN DO)
        public void AssignInfo()
        {
            won = false;
            UserInterface.PromptFirstName();
            firstName = Console.ReadLine();
            UserInterface.PromptLastName();
            lastName = Console.ReadLine();
            UserInterface.PromptEmail();
            email = Console.ReadLine();
        }
        public void Update(string winner)
        {
            if(won)
            {
                UserInterface.Congratulations(winner);
                
            }
            else
            {
                UserInterface.NotAWinner(winner);
            }
        }
    }
}
