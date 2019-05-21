using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables (HAS A)
        Queue<Sweepstakes> sweepQueue;

        //constructor (SPAWNER)
        public SweepstakesQueueManager()
        {
            sweepQueue = new Queue<Sweepstakes>();
        }

        //member methods (CAN DO)
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes selection = sweepQueue.Dequeue();
            return selection;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepQueue.Enqueue(sweepstakes);
        }
    }
}
