using CustomEventArgs;
using System;
using System.ComponentModel;

namespace EventsDemo
{
    public enum WorkType
    {
        Meeting,
        Study,
        Playing
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Worker worker = new Worker();


            // Anonymous methods allow event handler code to be hooked directly to an event
            // Anonymous methods are defined using the delegate keyword
            
            worker.WorkPerformed += delegate (object? sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
            };


            worker.WorkCompleted += delegate (object? sender, EventArgs e) 
            {
                Console.WriteLine("Worker is done");
            };

            // Raise events
            worker.DoWork(3, WorkType.Playing);


            Console.ReadKey();
        }
    }
}

/* Output:
 * 

Hours worked: 1 Playing
Hours worked: 2 Playing
Hours worked: 3 Playing
Worker is done

 * 
 */