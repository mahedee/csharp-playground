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


            // Lambda define inline method
            // In inline method parameter, dont need to define type of the parameter.Compiler match corresponding delegate's parameter.
            // => Lambda operator uses as a Seperator between parameter and method body

            // the following inline method can handle multi line statement
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
                //Console.WriteLine("second statement");
            };

            // the following inline method handle single line statement
            worker.WorkCompleted += (s, e) =>  Console.WriteLine("Worker is done");
            

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