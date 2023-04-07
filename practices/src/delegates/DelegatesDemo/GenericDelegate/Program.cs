namespace GenericDelegate
{
    public delegate T OperationDelegate<T>(T num1, T num2);

    public class Math
    {
        public static int Add (int a, int b)
        {
            return a + b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            OperationDelegate<int> addDelegate = new OperationDelegate<int>(Math.Add);
            int sum = addDelegate(5, 10); 
            Console.WriteLine(sum); // 15

            OperationDelegate<double> divideDelegate = new OperationDelegate<double>(Math.Divide);
            double result = divideDelegate(10, 5);
            Console.WriteLine(result); // 2

        }
    }
}