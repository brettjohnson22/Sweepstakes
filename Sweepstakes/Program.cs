using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.Welcome();
            UserInterface.PromptManager();
            string managerChoice = Console.ReadLine();
            ISweepstakesManager manager = ManagerFactory.ChooseAManager(managerChoice);
            MarketingFirm mf = new MarketingFirm(manager);
            mf.Initialize();
        }
    }
}

