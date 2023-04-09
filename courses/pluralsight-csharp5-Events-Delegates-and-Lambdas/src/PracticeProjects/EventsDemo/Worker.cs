namespace EventsDemo
{
    // Declare a delegate with delegate keyword
    public delegate void WorkPerformedDelegate(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedDelegate WorkPerformed;

        // EventHandler is built in delegates of .net 
        public event EventHandler WorkCompleted;


        // Raise events
        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }

            OnWorkCompleted();
        }

        // kept protected virtual means any one can inherite and override the method. You can keep it private
        // On is used in the method name as convention not rule
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            // You can call either way. 

            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(hours, workType);
            //}

            var del = WorkPerformed as WorkPerformedDelegate;
            if (del != null)
            {
                del(hours, workType);
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
