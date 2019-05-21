using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
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
    }
}
