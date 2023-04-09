using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public class Mediator
    {
        //static member

        public static readonly Mediator _instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance() { return _instance; }

        // Instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            var jobChangedDelegate = JobChanged as EventHandler<JobChangedEventArgs>;

            if (jobChangedDelegate != null)
            {
                jobChangedDelegate(sender, new JobChangedEventArgs() { Job = job });
            }
        }


    }
}
