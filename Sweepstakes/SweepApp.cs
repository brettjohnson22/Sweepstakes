using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepApp
    {
        //member variables (HAS A)

        //constructor (SPAWNER)
        public SweepApp()
        {

        }

        //member methods (CAN DO)
        public void Welcome()
        {
            UserInterface.Welcome();
            string input = Console.ReadLine();
            switch(input)
            {
                case "register":
                    break;
                case "manage":
                    break;
            }
        }
    }
}
