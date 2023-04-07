namespace TimerCallbackDemo
{
    public class TimerExample
    {
        private static int count = 0;

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("Timer callback: " + count);
            count++;
        }

        public static void Main()
        {
            TimerCallback callback = new TimerCallback(TimerCallback);
            Timer timer = new Timer(callback, null, 0, 1000);

            Console.ReadLine();
        }
    }
}