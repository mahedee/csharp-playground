namespace AsyncDemo
{
    class Program
    {

        public static async Task AysncMethod1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1");

                    // Delay 1000ms means 1 second
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static async Task AsyncMethod2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 2");

                    // Delay 1000ms means 1 second
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static void CallParrelAsync()
        {
            // This method will be called asynchronously
            // following 2 methods will be run in parallel
            AysncMethod1();
            AsyncMethod2();
        }


        public static async Task<int> AysncMethodReturnCounter()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1");

                    // Delay 1000ms means 1 second
                    Task.Delay(1000).Wait();
                    count += 1;
                }
            });

            return count;
        }

        public static void SyncMethod2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void SyncMethod3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        public static async void CallSyncAndAsync()
        {
            // This method will be called synchronously
            SyncMethod2();

            // This method will be called asynchronously
            var count = await AysncMethodReturnCounter();

            // This method will not call until it gets count from AysncMethodReturnCounter
            // because SyncMethod3 is dependent on count
            SyncMethod3(count);
        }


        public static async Task callMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        static async Task Main(string[] args)
        {
            // demonstrate 2 methods running in parallel
            CallParrelAsync();

            // demonstrate sync and async methods
            CallSyncAndAsync();
            Console.ReadKey();
        }
    }

    // Output
    /*
     Method 1
     Method 2
     Method 2
     Method 2
     Method 2
     Method 2
     Method 2
     Method 1
     Method 2
     Method 1
     Method 1
     Method 1
     Method 2
     Method 1
     Method 1
     Method 1
     Method 2
     Method 2
     Method 1
     Method 1
     Total count is 5
    */
}