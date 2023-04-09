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
        // Create Handler method with exact signature of delegate
        public static void WorkPerformedHandler(int hour, WorkType workType)
        {
            Console.WriteLine("Work performed handler 1 with hour log: " + hour);
        }

        // Create handler method with exact signature of EventHandler delegate
        private static void WorkCompletedHandler(object? sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }

        static void Main(string[] args)
        {
            Worker worker = new Worker();

            // instanciate and bind with event's invocation list
            worker.WorkPerformed += new WorkPerformedDelegate(WorkPerformedHandler);

            // instanciate and bind with event's invocation list
            worker.WorkCompleted += new EventHandler(WorkCompletedHandler);

            // Raise events
            worker.DoWork(3, WorkType.Playing);


            Console.ReadKey();
        }


    }
}

/* Output:
 * 

Work performed handler 1 with hour log: 1
Work performed handler 1 with hour log: 2
Work performed handler 1 with hour log: 3
Work completed

 * 
 */