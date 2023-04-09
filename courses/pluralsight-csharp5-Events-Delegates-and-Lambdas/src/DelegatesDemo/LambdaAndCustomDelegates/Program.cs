using System;

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

            Console.ReadKey();
        }
    }
}

/* Output:
 * 

7
10

 * 
 */