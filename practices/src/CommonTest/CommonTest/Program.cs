namespace CommonTest
{
    internal class Program
    {
        public static void Convert(float price)
        {
            object objPrice = price;

            // first it has to be unboxed using the same type
            // then cast it using int type

            int newPrice = (int)(float)objPrice;
            Console.WriteLine(newPrice);
        }
        static void Main(string[] args)
        {
            Convert(10.5f);
            Console.ReadKey();
        }
    }
}