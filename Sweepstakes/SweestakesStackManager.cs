using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweestakesStackManager : ISweepstakesManager
    {
        //member variables (HAS A)
        Stack<Sweepstakes> sweepStack;

        //constructor (SPAWNER)
        public SweestakesStackManager()
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
