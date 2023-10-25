using System.Numerics;

namespace BasicProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };

            // remove index 2 and trim the array
            int index = 4;
            for (int i = index; i < num.Length - 1; i++)
            {
                num[i] = num[i + 1];
            }

            Array.Resize(ref num, num.Length - 1);

            Console.WriteLine(num.Length);

            Console.WriteLine(num.Sum());

            Console.WriteLine(2/2);
           
            string binarystring = "1001";

            for(int i = 0; i < binarystring.Length; i++)
            {
                int val = binarystring[i] - '0';
                Console.WriteLine(val);
            }


            Console.WriteLine(Math.Log(1)/Math.Log(4));

            Console.WriteLine(Convert.ToInt32("01010101010101010101010101010101", 2));

            Console.WriteLine(BitOperations.PopCount((uint)16));

            // 1431655765
            // 01010101010101010101010101010101

            MethodOverLoadding methodOverLoadding = new MethodOverLoadding();
            methodOverLoadding.Foo();

            TupleDemo tupleDemo = new TupleDemo();
            var tuple = tupleDemo.GetPersonaInfo();
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            var (age, name) = tupleDemo.GetPersonaInfo();
            Console.WriteLine(age);
            Console.WriteLine(name);

            //MultiThreadDemo.Test();
           

            ListNode listNode1 = new ListNode(1);
            listNode1.next = new ListNode(2);
            listNode1.next.next = new ListNode(4);

            ListNode listNode2 = new ListNode(1);
            listNode2.next = new ListNode(3);
            listNode2.next.next = new ListNode(4);

            Solution solution = new Solution();
            var result = solution.MergeTwoLists(listNode1, listNode2);

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}