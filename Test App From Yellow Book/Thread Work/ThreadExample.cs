using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_App_From_Yellow_Book.Thread_Work
{
    public delegate void BusyLoop();
    public delegate void BusyLoopTwo();
    public abstract class ThreadExample
    {
        
        public static void BusyLoop()
        {

            long count;
            for (count = 0; count < 10000000000L; count +=1)
            {
               Console.WriteLine("1 + 1");
            }
        }

        public static void BusyLoopTwo()
        {
            long count;
            for (count = 0; count < 10000000000L; count += 1)
            {
                Console.WriteLine("2 + 2");
            }
        }
    }
}
