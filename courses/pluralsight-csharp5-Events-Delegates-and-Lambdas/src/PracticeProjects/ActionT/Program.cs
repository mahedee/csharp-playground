using System;
using System.Reflection.Metadata;

namespace LambdaAndCustomDelegates
{
    public delegate int BizRuleDelegate(int x, int y);

    public class Program
    {

        static void Main(string[] args)
        {
            BizRuleDelegate addDel = (x, y) => x + y;
            BizRuleDelegate mulDel = (x, y) => x * y;

            var data = new ProcessData();

            // Call with add delegate
            data.Process(5, 2, addDel);

            // Call with multiply delegate
            data.Process(5, 2, mulDel);

            //The.NET framework provides several different delegates that provide flexible options:
            //  -Action < T > -Accept a single parameter and returns no value
            //  - Func < T, TResult > -Accept a single parameter and return a value of type TResult

            Action<int, int> addAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> mulAction = (x, y) => Console.WriteLine(x * y);

            data.ProcessAction(3, 2, addAction);
            data.ProcessAction(3, 2, mulAction);



            Console.ReadKey();
        }
    }
}

/* Output:
 * 

7
10
5
Action has been processed
6
Action has been processed

 * 
 */