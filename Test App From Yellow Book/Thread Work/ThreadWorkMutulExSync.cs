using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Thread_Work
{
    public delegate void BusyLoopMutEx();
    public delegate void BusyLoopNoMutEx();
    class ThreadWorkMutulExSync
    {

        //token the each thread uses when it has control of the processor, to make sure that multiple
        //threads do not interact randomly with, for example, a variable which needs interacting with in turn
        public static object sync = new object();
        public static void BusyLoopMutEx()
        {
            int count = 0;
            while (count < 100000)
            {
                
                Console.WriteLine("Mutual Exclusion Used" + count.ToString());
                Monitor.Enter(sync);
                count += 1;
                Monitor.Exit(sync);
                //From Monitor.Enter() to Monitor.Exit(), this is what is done in sync, not randomly as soon
                //as a thread gets control it will be incremented in turn, which will make sure all incrementations occur for each thread
                //and not in total between all threads

            }
        }

        public static void BusyLoopNoMutEx()
        {
            int count = 0;
            while (count < 100000)
            {
                Console.WriteLine("No Mutual Exclusion Used" + count.ToString());
                Monitor.Enter(sync);
                count += 1;
            }
        }
    }
}
