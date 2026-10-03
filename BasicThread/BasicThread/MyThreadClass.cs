using System;
using System.Threading;

namespace BasicThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            int loopCount = 0;

            while (true)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                Thread.Sleep(1500); // sleep for 1.5 seconds

                if (loopCount == 5)
                {
                    break; 
                }

                loopCount++;
            }
        }
    }
}
