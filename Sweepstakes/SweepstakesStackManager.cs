using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables (HAS A)
        private Stack<Sweepstakes> sweepStack;

        //constructor (SPAWNER)
        public SweepstakesStackManager()
        {
            sweepStack = new Stack<Sweepstakes>();
        }

        //member methods (CAN DO)
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes selection = sweepStack.Pop();
            return selection;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Push(sweepstakes);
        }
    }
}
