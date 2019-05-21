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
        string name;

        //constructor (SPAWNER)
        public Sweepstakes(string name)
        {
            this.name = name;
            contestantList = new Dictionary<double, Contestant>();
        }
        //member methods (CAN DO)

        void RegisterContestant(Contestant contestant)
        {
            contestant.registration = contestantList.Count + 1;
            contestantList.Add(contestant.registration, contestant);
        }
        string PickWinner()
        {
            string winner = "";
            Random rand = new Random();
            double winningNumber = rand.Next(contestantList.Count);
            foreach(KeyValuePair<double, Contestant> contestant in contestantList)
            {
                if (winningNumber == contestant.Key)
                {
                    contestant.Value.winner = true;
                    winner = contestant.Value.Name;
                }
            }
            return winner;
        }
        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Info on Contestant #{contestant.registration}:\nName: {contestant.Name}\nEmail: {contestant.Email}");
        }
        void SweepstakesOption()
        {

        }
    }
}
