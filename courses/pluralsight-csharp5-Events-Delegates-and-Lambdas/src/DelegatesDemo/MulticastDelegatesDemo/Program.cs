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

        // Create Handler 3 method with exact signature of delegate
        public static void WorkPerformedHandler3(int hour, WorkType workType)
        {
            Console.WriteLine("Work performed handler 3 with hour log: " + hour);
        }

        static void Main(string[] args)
        {
            // Instastciate delegate and bind handler method
            WorkPerformedDelegate workPerformedDelegate1 = new WorkPerformedDelegate(WorkPerformedHandler1);
 

            // Instastciate delegate and bind handler method
            WorkPerformedDelegate workPerformedDelegate2 = new WorkPerformedDelegate(WorkPerformedHandler2);

            // Instastciate delegate and bind handler method
            WorkPerformedDelegate workPerformedDelegate3 = new WorkPerformedDelegate(WorkPerformedHandler3);


            // Concatenate delegates for multicast
            // Add 3 delegates in invocation list
            workPerformedDelegate1 += workPerformedDelegate2 + workPerformedDelegate3;

            // Or
            // workPerformedDelegate1 += workPerformedDelegate2;
            // workPerformedDelegate1 += workPerformedDelegate3;

            // Now when you invoke one delegates all 3 registered handler will be called
            workPerformedDelegate1(4, WorkType.Study);


            Console.ReadKey();
        }
    }
}

/* Output:
 * 

Work performed handler 1 with hour log: 4
Work performed handler 2 with hour log: 4
Work performed handler 3 with hour log: 4

 * 
 */