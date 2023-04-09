using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndFuncT
{
    public delegate int BizRuleDelegate(int x, int y);

    public class Program
    {

        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() {City = "Phoenix", FirstName = "John", LastName = "Doe", Id = 1},
                new Customer() {City = "Phoenix", FirstName = "Jane", LastName = "Doe", Id = 2},
                new Customer() {City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", Id = 3},
                new Customer() {City = "Phoenix", FirstName = "Michelle", LastName = "Smith", Id = 500}
            };

            // Here p is parameter of the lambda. You don't need to add parenthesis for single input, like 2nd statement
            // Here where require a func delegate and return bool as TResult
            // Where returns a IEnumerable object

            var filterCustomers = customers
                .Where((p) => p.City == "Phoenix" && p.Id < 500)
                .OrderBy(p => p.FirstName);

            //var filterCustomers = customers.Where(p => p.City == "Phoenix");

            foreach (var customer in filterCustomers)
            {
                Console.WriteLine("First Name: " + customer.FirstName + " City: " + customer.City);
            }


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

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultipleDel = (x, y) => x * y;

            data.ProcessFunc(4, 2, funcAddDel);
            data.ProcessFunc(4, 2, funcMultipleDel);

            Console.ReadKey();
        }
    }
}

/* Output:
 * 

First Name: Jane City: Phoenix
First Name: John City: Phoenix
7
10
5
Action has been processed
6
Action has been processed
6
8

 * 
 */