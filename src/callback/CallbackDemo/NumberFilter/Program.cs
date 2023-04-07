using System.Security.Cryptography.X509Certificates;

namespace NumberFilter
{
    // Declare a delegate which takes an integer value
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

            //The delegate (int number) syntax that you see in the Main method is creating
            //an anonymous method that matches the signature of the FilterDelegate delegate.

            /*
            List<int> evenNumbers = NumberFilter.Filter(numbers, delegate (int number)
            {
                return number % 2 == 0;
            });
            */

            // The above code can be rewrite without anonymous method as follows
            List<int> evenNumbers = NumberFilter.Filter(numbers, IsEvenNumber);

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

    /*Ouput:
     * Even numbers:
        2
        4
        6
        8
        10
        Odd numbers
        1
        3
        5
        7
        9
     * 
     */
}