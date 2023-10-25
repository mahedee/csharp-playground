using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class MultiThreadDemo
    {
        public static void Test()
        {
            // Create two threads
            Thread thread1 = new Thread(DoTask1);
            Thread thread2 = new Thread(DoTask2);

            // Start the threads
            thread1.Start();
            thread2.Start();

            // Do other work in the main thread
            Console.WriteLine("Main thread is doing some work...");

            // Wait for the threads to finish
            thread1.Join();
            thread2.Join();

            Console.WriteLine("All tasks completed.");
            Console.ReadLine();
        }

        static void DoTask1()
        {
            Console.WriteLine("Task 1 is starting...");
            // Perform the task
            Console.WriteLine("Task 1 is executing...");
            Thread.Sleep(2000); // Simulating some work
            Console.WriteLine("Task 1 is completed.");
        }

        static void DoTask2()
        {
            Console.WriteLine("Task 2 is starting...");
            // Perform the task
            Console.WriteLine("Task 2 is executing...");
            Thread.Sleep(3000); // Simulating some work
            Console.WriteLine("Task 2 is completed.");
        }
    }
}
