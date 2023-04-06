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
        // Create a string object name myString
        string myString = "Hello, world!";

        // Apply Reverse method on myString object
        string reversedString = myString.Reverse();
        Console.WriteLine(reversedString); 
        
        // Outputs "!dlrow ,olleH"
    }
}
