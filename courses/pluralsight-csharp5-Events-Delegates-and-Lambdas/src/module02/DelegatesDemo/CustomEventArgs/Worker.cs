using CustomEventArgs;
using System;

namespace EventsDemo
{
    // Declare a delegate with delegate keyword. You can use like below or change using generic
    // public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed;

        // Instead of using the previous statement we can use the following code using generics
        // EventHandler<T> provides a simple way to create a custom delegate for an event
        public EventHandler<WorkPerformedEventArgs> WorkPerformed;
        
        // EventHandler is built in delegates of .net 
        public event EventHandler WorkCompleted;


        // Raise events
        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 0; i < hours; i++)
            {
                // Sleep for 1 second to see it's working. it's not mandatory
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);
            }

            OnWorkCompleted();
        }

        // kept protected virtual means any one can inherite and override the method. You can keep it private
        // On is used in the method name as convention not rule
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
     
            //var del = WorkPerformed as WorkPerformedHandler;

            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;

            if (del != null)
            {
                //del(hours, workType);
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            // You can call either way. 

            //if(WorkCompleted != null)
            //{
            //    WorkCompleted(hours, workType);
            //}

            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                // here this class is sender or raise the event
                del(this, EventArgs.Empty);
            }
        }
    }
}
