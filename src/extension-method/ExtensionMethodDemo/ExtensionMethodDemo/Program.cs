//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }
}

public class Program
{
    public static void Main()
    {
        string orignialString = "Hello world";
        Console.WriteLine(orignialString);

        string reverseString = orignialString.Reverse();
        Console.WriteLine(reverseString);
    }
}
