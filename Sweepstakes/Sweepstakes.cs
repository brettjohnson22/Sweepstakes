using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables (HAS A)
        Dictionary<double, Contestant> contestantList;

        //constructor (SPAWNER)
        public Sweepstakes(string name)
        {
            //Create a new Sweepstakes with a certain name.
        }
        //member methods (CAN DO)

        void RegisterContestant(Contestant contestant)
        {
            //Once a contestant fills out info, add them to the Dictionary.
        }
        string PickWinner()
        {
            //Randomly choose a key from the dictionary, then return its name as a string.
        }
        void PrintContestantInfo(Contestant contestant)
        {
            //Display the name and email of the winner.
        }
        
    }
}
