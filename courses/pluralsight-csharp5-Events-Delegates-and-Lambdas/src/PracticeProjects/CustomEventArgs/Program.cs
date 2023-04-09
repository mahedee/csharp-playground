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

            // The += operator is used to attach an event to an event handler
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);

            // instanciate and bind with event's invocation list
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);

            // Raise events
            worker.DoWork(3, WorkType.Playing);


            Console.ReadKey();
        }

        // Create Handler method with exact signature of delegate
        private static void Worker_WorkCompleted(object? sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        // Create Handler method with exact signature of delegate

        private static void Worker_WorkPerformed(object? sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
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