using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables (HAS A)
        ISweepstakesManager manager;
        Sweepstakes activeSweepstake;

        //constructor (SPAWNER)
        public MarketingFirm()
        {

        }

        //member methods (CAN DO)
        public void Initialize()
        {
            UserInterface.Welcome();
            string managerChoice = ManagerPrompt();
            manager = ChooseAManager(managerChoice);
            CreateFirstSweepstakes();
            SweepstakesPrompt();
            AddOrDraw();
        }
        public string ManagerPrompt()
        {
            UserInterface.PromptManager();
            string input = Console.ReadLine();
            return input;
        }
        public ISweepstakesManager ChooseAManager(string item)
        {
            switch (item.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid selection."));
            }
        }
        public void CreateFirstSweepstakes()
        {
            UserInterface.SweepstakesName();
            string name = Console.ReadLine();
            activeSweepstake = new Sweepstakes(name);
        }
        public void SweepstakesPrompt()
        {
            bool found = false;
            while (!found)
            {
                UserInterface.SweepstakesOptions();
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "store":
                        manager.InsertSweepstakes(activeSweepstake);
                        UserInterface.SweepstakesName();
                        string name = Console.ReadLine();
                        activeSweepstake = new Sweepstakes(name);
                        break;
                    case "use":
                        found = true;
                        break;
                }
            }
        }
        public void AddOrDraw()
        {
            UserInterface.UsingSweepstakes(activeSweepstake);
            bool keepGoing = true;
            while (keepGoing)
            {
                UserInterface.RegisterOrDraw();
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "add":
                        Contestant temp = new Contestant();
                        activeSweepstake.RegisterContestant(temp);
                        break;
                    case "draw":
                        Console.WriteLine("The winner is: " + activeSweepstake.PickWinner());
                        Console.ReadLine();
                        keepGoing = false;
                        break;
                }
            }
        }
    }
}
