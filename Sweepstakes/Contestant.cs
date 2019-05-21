using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables (HAS A)
        private string firstName;
        private string lastName;
        private string email;
        double registration;
        //bool winner?

        //constructor (SPAWNER)
        public Contestant()
        {

        }

        //member methods (CAN DO)
        public void AssignInfo()
        {
            UserInterface.PromptFirstName();
            firstName = Console.ReadLine();
            UserInterface.PromptLastName();
            lastName = Console.ReadLine();
            UserInterface.PromptEmail();
            email = Console.ReadLine();
        }
    }
}
