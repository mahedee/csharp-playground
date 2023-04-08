using System.ComponentModel;

namespace DelegatesDemo
{
    // Declare a delegate with delegate keyword
    public delegate void WorkPerformedDelegate(int hours, WorkType workType);
    public enum WorkType
    {
        Meeting,
        Study,
        Playing
    }

    internal class Program
    {
        // Create Handler 1 method with exact signature of delegate
        public static void WorkPerformedHandler1(int  hour, WorkType workType)
        {
            Console.WriteLine("Work performed handler 1 with hour log: " + hour);
        }

        // Create Handler 2 method with exact signature of delegate
        public static void WorkPerformedHandler2(int hour, WorkType workType)
        {
            Console.WriteLine("Work performed handler 2 with hour log: " + hour);
        }

        // Create a method which can take delegate as parameter 
        // It called any delegates based on input parameter
        public static void DoWork(WorkPerformedDelegate workPerformedDelegate)
        {
            workPerformedDelegate(1, WorkType.Playing);
        }

        static void Main(string[] args)
        {
            // Instastciate delegate and bind handler method
            WorkPerformedDelegate workPerformedDelegate1 = new WorkPerformedDelegate(WorkPerformedHandler1);
            // Call handler method using delegate
            workPerformedDelegate1(2, WorkType.Meeting);

            // Instastciate delegate and bind handler method
            WorkPerformedDelegate workPerformedDelegate2 = new WorkPerformedDelegate(WorkPerformedHandler2);
            // Call handler method using delegate
            workPerformedDelegate1(4, WorkType.Study);

            // Call DoWork Method using workPerformedDelegate1 instance 
            DoWork(workPerformedDelegate1);

            Console.ReadKey();
        }
    }
}

/* Output:
 * 
 * Work performed handler 1 with hour log: 2
 * Work performed handler 1 with hour log: 4
 * Work performed handler 1 with hour log: 1
 * 
 */