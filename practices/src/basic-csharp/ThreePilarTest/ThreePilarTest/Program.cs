namespace ThreePilarTest
{

    /*
     * Define a type called StringCompare that contains two string "properties": 'First' and 'Second'.
        Next, define a class called Util that contains a method called 'compare'.
        The 'compare' method takes in a 'StringCompare' object.
        It returns null if the length of the 'first' string plus the length of the 'second' string in the StringCompare object is greater than 10.
        Otherwise, it returns the 'second' string from StringCompare.
     */
    public class StringCompare
    {
        public String First { get; set; }
        public String Second { get; set; }
    }

    public class  Util
    {
        public int? Compare(StringCompare stringCompare)
        {
            int length = stringCompare.First.Length + stringCompare.Second.Length;
            if (length > 10)
            {
                return null;
            }
            else
            {
                return length;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}