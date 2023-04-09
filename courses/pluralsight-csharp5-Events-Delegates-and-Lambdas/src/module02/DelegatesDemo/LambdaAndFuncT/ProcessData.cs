using System;

namespace LambdaAndFuncT
{
    public class ProcessData
    {
        // Result will process based on the delegates and input x and y
        // It will show different result based on delegates
        public void Process(int x, int y, BizRuleDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> del)
        {
            del(x, y);
            Console.WriteLine("Action has been processed");
        }

        public void ProcessFunc(int x, int y, Func<int, int, int> del)
        {
            var result = del(x, y);
            
            Console.WriteLine(result);
        }
    }
}
