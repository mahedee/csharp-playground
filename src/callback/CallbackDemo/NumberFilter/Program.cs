using System.Security.Cryptography.X509Certificates;

namespace NumberFilter
{
    public delegate bool FilterDelegate(int value);
    public class NumberFilter
    {
        public static List<int> Filter (List<int> numbers, FilterDelegate filter)
        {
            List<int> filteredNumbers = new List<int>();

            foreach (int number in numbers)
            {
                //
                if (filter(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }
    }
    public class Program
    {
        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //FilterDelegate filterDelegate = new FilterDelegate(Program.IsEvenNumber(int number));

            // what does delegate (int number) means
            List<int> evenNumbers = NumberFilter.Filter(numbers, delegate (int number)
            {
                return number % 2 == 0;
            });

            Console.WriteLine("Even numbers:");

            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            List<int> oddNumbers = NumberFilter.Filter(numbers, delegate (int number)
            {
                return number % 2 != 0;
            });

            Console.WriteLine("Odd numbers");

            foreach(int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}