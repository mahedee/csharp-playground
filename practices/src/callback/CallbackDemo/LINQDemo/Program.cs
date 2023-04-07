using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Asynchronously calculate the sum of the numbers using LINQ
        long sum = await Task.Run(() => numbers.Sum(num => num * num));

        SumCallback(sum);

        Console.WriteLine("Calculating sum asynchronously...");
        Console.ReadLine();
    }

    static void SumCallback(long sum)
    {
        Console.WriteLine("Sum: " + sum);
    }
}


// Output: 55