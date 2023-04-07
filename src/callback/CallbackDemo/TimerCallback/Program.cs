using System;
using System.Threading;

namespace TimerCallbackDemo
{
    public class TimerExample
    {
        private static int count = 0;

        private static void CallTimer(Object o)
        {
            Console.WriteLine("Timer callback: " + count);
            count++;
        }

        public static void Main()
        {
            // Declare a delegate
            TimerCallback callback = new TimerCallback(CallTimer);

            Timer timer = new Timer(callback, null, 0, 1000);

            Console.ReadLine();
        }
    }
}

//Output:
/*

Timer callback: 0
Timer callback: 1
Timer callback: 2
Timer callback: 3
Timer callback: 4

*/