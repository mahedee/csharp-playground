using System;

namespace LambdaAndCustomDelegates
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
    }
}
