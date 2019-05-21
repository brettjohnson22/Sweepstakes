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
            UserInterface.Welcome();
            string managerChoice = ManagerPrompt();
            manager = ChooseAManager(managerChoice);
            SweepstakesPrompt();
        }

        //member methods (CAN DO)
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
        public void SweepstakesPrompt()
        {
            UserInterface.SweepstakesOptions();
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "insert":
                    //manager.InsertSweepstakes();
                    break;
                case "get":
                    activeSweepstake = manager.GetSweepstakes();
                    break;
            }
        }
    }
}
