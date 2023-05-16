namespace NullChecker
{
    internal class Program
    {
        private static bool IsNull(object obj)
        {
            // check null using double equal
            if(obj == null)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //object obj = new object();
            object obj = null;
            Console.WriteLine(IsNull(obj));
            Console.ReadKey();
        }
    }
}